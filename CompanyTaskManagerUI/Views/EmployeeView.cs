using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;

namespace ZadanieGUI.Views
{
    public partial class EmployeeView : Form
    {
        private LoginForm LoginFormStorage { get; set; }
        private Employee SignedInUser
        {
            get
            {
                return LoginFormStorage?.SignedInUser;
            }
        }
        private RestClient Client { get; set; }

        public EmployeeView()
        {
            InitializeComponent();
        }

        public EmployeeView(LoginForm loginForm, RestClient client)
        {
            LoginFormStorage = loginForm;
            Client = client;
            InitializeComponent();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Hello {SignedInUser.FirstName}";
            LoadTaskList();
        }

        private void OnTaskListMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            TaskListContextMenu.Show(MousePosition);
        }

        private void EmployeeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginFormStorage.Close();
        }

        private void OnNewTaskButtonClicked(object sender, EventArgs e)
        {
            var taskForm = new TaskCreationForm(Client, SignedInUser);
            taskForm.Show();
            taskForm.FormClosed += LoadTaskList;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var taskForm = new TaskCreationForm(Client, listTaskList.SelectedItems[0]);
            taskForm.Show();
            taskForm.FormClosed += LoadTaskList;
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTasks = listTaskList.SelectedItems;
            foreach (ListViewItem task in selectedTasks)
            {
                var deleteReq = new RestRequest($"/api/tasks/{task.Text}");
                var deleteResp = await Client.ExecuteDeleteAsync(deleteReq);
                if (!deleteResp.IsSuccessful)
                {
                    MessageBox.Show($"Error deleting task '{task.SubItems[1]}'", "API Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadTaskList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTaskList();
        }

        private void btnRefreshTasks_Click(object sender, EventArgs e)
        {
            LoadTaskList();
        }

        private void LoadTaskList(object sender, FormClosedEventArgs e)
        {
            LoadTaskList();
        }

        private async void LoadTaskList()
        {
            var getTasksReq = new RestRequest($"/api/tasks/worker={SignedInUser.Id}");
            var getTasks = await Client.ExecuteGetAsync<List<WorkTask>>(getTasksReq);
            if (!getTasks.IsSuccessStatusCode)
            {
                MessageBox.Show(getTasks.StatusCode.ToString(), "API Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetupTasklist(getTasks.Data);
        }

        private void SetupTasklist(List<WorkTask> tasks)
        {
            listTaskList.Items.Clear();
            foreach (var task in tasks)
            {
                string[] taskToItems = new string[]
                {
                    task.Id.ToString(),
                    task.Header,
                    task.Priority.ToString(),
                    (task.AssignedEmployee ?? SignedInUser).ToString(),
                    task.CreationDate?.ToString()
                };
                listTaskList.Items.Add(new ListViewItem(taskToItems));
            }
        }
    }
}
