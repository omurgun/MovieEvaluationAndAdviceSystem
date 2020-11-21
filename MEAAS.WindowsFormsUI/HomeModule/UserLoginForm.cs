using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.WindowsFormsUI.AdminModule;
using MEAAS.WindowsFormsUI.UserModule;

namespace MEAAS.WindowsFormsUI.HomeModule
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        
        private void BtnUserLogin_Click(object sender, EventArgs e)
        {
            var userName = tbxUserName.Text;
            var password = tbxPassword.Text;

            if (userName == string.Empty || password == string.Empty)
            {
                MessageBox.Show("can't be blank");
            }
            else
            {
                var user = _userService.GetUserByUserNameAndPassword(userName, password);
                if (user != null)
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User name or password is incorrect!");
                }
            }
        }
        private void BtnGoRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm userRegisterForm = new UserRegisterForm();
            userRegisterForm.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
