using RestSharp;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using ZadanieGUI.Views;

namespace ZadanieGUI
{
    public partial class LoginForm : Form
    {
        public Employee SignedInUser { get; set; } = null;
        private string ApiURL => ConfigurationManager.AppSettings.Get("apiURL");
        private RestClient Client { get; set; }

        public LoginForm()
        {
            Client = new RestClient(ApiURL);
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxLoginField.Text == string.Empty)
            {
                MessageBox.Show("No email address provided.", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((Button)sender).Enabled = false;
            string emailB6 = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtboxLoginField.Text)).TrimEnd('=');
            string reqUrl = $"/api/employees/email={emailB6}";
            var employeeReq = new RestRequest(reqUrl);
            var employeeResp = await Client.ExecuteGetAsync<Employee>(employeeReq);
            if (!employeeResp.IsSuccessful)
            {
                if (employeeResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                    MessageBox.Show("Entered email address is incorrect.", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("API connection failed.", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Button)sender).Enabled = true;
                return;
            }
            SignedInUser = employeeResp.Data;
            new EmployeeView(this, Client).Show();
            Hide();
        }
    }
}
