namespace ZadanieGUI.Views
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.listTaskList = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTaskPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAssignedEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshTasks = new System.Windows.Forms.Button();
            this.TaskListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(66, 13);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Hello <user>";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(15, 306);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(115, 31);
            this.btnNewTask.TabIndex = 3;
            this.btnNewTask.Text = "Create Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.OnNewTaskButtonClicked);
            // 
            // listTaskList
            // 
            this.listTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listTaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnTaskName,
            this.columnTaskPriority,
            this.columnAssignedEmployee,
            this.columnCreationDate});
            this.listTaskList.FullRowSelect = true;
            this.listTaskList.HideSelection = false;
            this.listTaskList.Location = new System.Drawing.Point(15, 75);
            this.listTaskList.MultiSelect = false;
            this.listTaskList.Name = "listTaskList";
            this.listTaskList.Size = new System.Drawing.Size(777, 225);
            this.listTaskList.TabIndex = 4;
            this.listTaskList.UseCompatibleStateImageBehavior = false;
            this.listTaskList.View = System.Windows.Forms.View.Details;
            this.listTaskList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTaskListMouseClick);
            // 
            // columnID
            // 
            this.columnID.Text = "Task ID";
            // 
            // columnTaskName
            // 
            this.columnTaskName.Text = "Task Name";
            this.columnTaskName.Width = 120;
            // 
            // columnTaskPriority
            // 
            this.columnTaskPriority.Text = "Priority";
            // 
            // columnAssignedEmployee
            // 
            this.columnAssignedEmployee.Text = "Assigned Employee";
            this.columnAssignedEmployee.Width = 200;
            // 
            // columnCreationDate
            // 
            this.columnCreationDate.Text = "Created Date";
            this.columnCreationDate.Width = 88;
            // 
            // TaskListContextMenu
            // 
            this.TaskListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.TaskListContextMenu.Name = "TaskListContextMenu";
            this.TaskListContextMenu.ShowImageMargin = false;
            this.TaskListContextMenu.Size = new System.Drawing.Size(83, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnRefreshTasks
            // 
            this.btnRefreshTasks.Location = new System.Drawing.Point(15, 38);
            this.btnRefreshTasks.Name = "btnRefreshTasks";
            this.btnRefreshTasks.Size = new System.Drawing.Size(115, 31);
            this.btnRefreshTasks.TabIndex = 5;
            this.btnRefreshTasks.Text = "Refresh Task List";
            this.btnRefreshTasks.UseVisualStyleBackColor = true;
            this.btnRefreshTasks.Click += new System.EventHandler(this.btnRefreshTasks_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btnRefreshTasks);
            this.Controls.Add(this.listTaskList);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "EmployeeView";
            this.Text = "Task Management Utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeView_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            this.TaskListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.ListView listTaskList;
        private System.Windows.Forms.ColumnHeader columnTaskName;
        private System.Windows.Forms.ColumnHeader columnTaskPriority;
        private System.Windows.Forms.ColumnHeader columnAssignedEmployee;
        private System.Windows.Forms.ContextMenuStrip TaskListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button btnRefreshTasks;
        private System.Windows.Forms.ColumnHeader columnCreationDate;
    }
}