using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieGUI.Views
{
    public partial class TaskCreationForm : Form
    {
        public WorkTask CreatedTask { get; set; } = null;
        public event Action OnFormClosedSuccessfully;
        private RestClient Client;
        private Employee CurrentEmployee { get; set; }
        private WorkTask TaskInEdition { get; set; }

        public TaskCreationForm()
        {
            CreatedTask = null;
            InitializeComponent();
        }

        public TaskCreationForm(RestClient client, Employee signedInUser)
        {
            Client = client;
            CreatedTask = null;
            CurrentEmployee = signedInUser;
            InitializeComponent();
            btnCreate.Text = "Create";
        }

        public TaskCreationForm(RestClient client, WorkTask existingTask)
        {
            Client = client;
            CreatedTask = null;
            InitializeComponent();
            TaskInEdition = existingTask;
            txtboxHeader.Text = existingTask.Header;
            txtboxPriority.Value = existingTask.Priority;
            txtboxDescription.Text = existingTask.Description;
            cmbEmployeeSelect.SelectedItem = existingTask.AssignedEmployee;
            Text = "Update existing task";
            btnCreate.Text = "Update";
        }

        public TaskCreationForm(RestClient client, ListViewItem taskAsItem)
        {
            Client = client;
            CreatedTask = null;
            InitializeComponent();
            TaskInEdition = new WorkTask()
            {
                Id = long.Parse(taskAsItem.SubItems[0].Text),
                Header = taskAsItem.SubItems[1].Text,
                Priority = int.Parse(taskAsItem.SubItems[2].Text),
                AssignedEmployee = taskAsItem.SubItems[3].Text == string.Empty ? null : new Employee()
                {
                    FirstName = taskAsItem.SubItems[3].Text.Split(' ')[0],
                    LastName = taskAsItem.SubItems[3].Text.Split(' ')[1]
                },
                CreationDate = taskAsItem.SubItems[4].Text == string.Empty ? DateTime.Now : DateTime.Parse(taskAsItem.SubItems[4].Text)
            };
            txtboxHeader.Text = TaskInEdition.Header;
            txtboxPriority.Value = TaskInEdition.Priority;
            cmbEmployeeSelect.SelectedItem = TaskInEdition.AssignedEmployee;
            btnCreate.Text = "Update";
        }

        private async void TaskCreationForm_Load(object sender, EventArgs e)
        {
            cmbEmployeeSelect.Items.Clear();
            var getEmployeesReq = new RestRequest("/api/employees");
            var employeesResp = await Client.ExecuteGetAsync<List<Employee>>(getEmployeesReq);
            if (!employeesResp.IsSuccessful)
            {
                MessageBox.Show("API error occurred when downloading employees list.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var emp in employeesResp.Data)
                cmbEmployeeSelect.Items.Add(emp);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (btnCreate.Text)
            {
                case "Update":
                    EditExistingTask();
                    return;
                case "Create":
                    CreateNewTask();
                    return;
            }
        }

        private async void CreateNewTask()
        {
            var task = new WorkTask
            {
                Header = txtboxHeader.Text,
                Priority = (int)txtboxPriority.Value,
                Description = txtboxDescription.Text,
                AssignedEmployee = (Employee)cmbEmployeeSelect.SelectedItem,
                CreationDate = DateTime.Now
            };
            var createRequest = new RestRequest("/api/tasks");
            createRequest.AddBody(task, ContentType.Json);
            var createResponse = await Client.ExecutePostAsync(createRequest);
            if (!createResponse.IsSuccessful)
            {
                MessageBox.Show(createResponse.ErrorException.ToString(), "API Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreatedTask = task;
                OnFormClosedSuccessfully?.Invoke();
                Close();
            }
        }

        private async void EditExistingTask()
        {
            var updatedTask = new WorkTask
            {
                Header = txtboxHeader.Text,
                Priority = (int)txtboxPriority.Value,
                Description = txtboxDescription.Text,
                AssignedEmployee = (Employee)cmbEmployeeSelect.SelectedItem,
                CreationDate = TaskInEdition.CreationDate
            };
            if (updatedTask == TaskInEdition)
                return;
            var editRequest = new RestRequest($"/api/tasks/{TaskInEdition.Id}");
            editRequest.AddBody(updatedTask, ContentType.Json);
            var editResp = await Client.ExecutePutAsync(editRequest);
            if (!editResp.IsSuccessful)
            {
                MessageBox.Show(editResp.ErrorMessage, "API Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CreatedTask = updatedTask;
            OnFormClosedSuccessfully?.Invoke();
            Close();
        }
    }
}
