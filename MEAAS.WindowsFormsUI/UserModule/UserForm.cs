using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEAAS.WindowsFormsUI.UserModule
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUserLogOut_Click(object sender, EventArgs e)
        {
            SetUserInfo();
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            bool isThereUserName = (bool)Properties.Settings.Default["IsThereUserName"];
            if (!isThereUserName)
            {
                var userName = lblUserName.Text;
                Properties.Settings.Default["UserName"] = userName;
                Properties.Settings.Default["IsThereUserName"] = true;
            }
            SetUserInfo();
        }
        private void SetUserInfo()
        {
            lblUserName.Text = Properties.Settings.Default["UserName"].ToString();

        }

        private void ResetUserInfo()
        {
            Properties.Settings.Default["UserName"] = "";
            Properties.Settings.Default["IsThereUserName"] = false;
        }

    }
}
