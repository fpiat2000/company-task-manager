namespace ZadanieGUI.Views
{
    partial class TaskCreationForm
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
            this.txtboxHeader = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPriority = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.txtboxPriority = new System.Windows.Forms.NumericUpDown();
            this.cmbEmployeeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxHeader
            // 
            this.txtboxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxHeader.Location = new System.Drawing.Point(67, 35);
            this.txtboxHeader.Name = "txtboxHeader";
            this.txtboxHeader.Size = new System.Drawing.Size(278, 20);
            this.txtboxHeader.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(-2, 92);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblDesc.Size = new System.Drawing.Size(65, 13);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Description";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDescription.Location = new System.Drawing.Point(0, 108);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(345, 89);
            this.txtboxDescription.TabIndex = 8;
            this.txtboxDescription.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(101, 222);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(-2, 64);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPriority.Size = new System.Drawing.Size(43, 13);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority";
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(-2, 38);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelHeader.Size = new System.Drawing.Size(47, 13);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Header";
            // 
            // txtboxPriority
            // 
            this.txtboxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPriority.Location = new System.Drawing.Point(67, 62);
            this.txtboxPriority.Name = "txtboxPriority";
            this.txtboxPriority.Size = new System.Drawing.Size(278, 20);
            this.txtboxPriority.TabIndex = 6;
            // 
            // cmbEmployeeSelect
            // 
            this.cmbEmployeeSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployeeSelect.FormattingEnabled = true;
            this.cmbEmployeeSelect.Location = new System.Drawing.Point(67, 8);
            this.cmbEmployeeSelect.Name = "cmbEmployeeSelect";
            this.cmbEmployeeSelect.Size = new System.Drawing.Size(278, 21);
            this.cmbEmployeeSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee";
            // 
            // TaskCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployeeSelect);
            this.Controls.Add(this.txtboxPriority);
            this.Controls.Add(this.txtboxHeader);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.labelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "TaskCreationForm";
            this.Text = "Create a new task";
            this.Load += new System.EventHandler(this.TaskCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtboxPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxHeader;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox txtboxDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.NumericUpDown txtboxPriority;
        private System.Windows.Forms.ComboBox cmbEmployeeSelect;
        private System.Windows.Forms.Label label1;
    }
}