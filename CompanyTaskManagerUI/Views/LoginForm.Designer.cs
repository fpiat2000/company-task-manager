namespace ZadanieGUI
{
    partial class LoginForm
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
            this.txtboxLoginField = new System.Windows.Forms.TextBox();
            this.txtboxPasswordField = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxLoginField
            // 
            this.txtboxLoginField.AccessibleName = "LoginField";
            this.txtboxLoginField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxLoginField.Location = new System.Drawing.Point(64, 3);
            this.txtboxLoginField.Name = "txtboxLoginField";
            this.txtboxLoginField.Size = new System.Drawing.Size(192, 20);
            this.txtboxLoginField.TabIndex = 0;
            // 
            // txtboxPasswordField
            // 
            this.txtboxPasswordField.AccessibleName = "PasswordField";
            this.txtboxPasswordField.Location = new System.Drawing.Point(62, 3);
            this.txtboxPasswordField.Name = "txtboxPasswordField";
            this.txtboxPasswordField.PasswordChar = '*';
            this.txtboxPasswordField.Size = new System.Drawing.Size(194, 20);
            this.txtboxPasswordField.TabIndex = 1;
            this.txtboxPasswordField.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "LoginButton";
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(111, 78);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(55, 13);
            this.label1.MinimumSize = new System.Drawing.Size(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.MaximumSize = new System.Drawing.Size(53, 13);
            this.label2.MinimumSize = new System.Drawing.Size(53, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtboxLoginField);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtboxPasswordField);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 48);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLogin);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxLoginField;
        private System.Windows.Forms.TextBox txtboxPasswordField;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}