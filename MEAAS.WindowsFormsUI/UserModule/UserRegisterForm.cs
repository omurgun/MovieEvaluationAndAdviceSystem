using System;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;

namespace MEAAS.WindowsFormsUI.UserModule
{
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            this.Hide();
        }

        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        private void BtnUserRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = tbxFirstName.Text;
                var lastName = tbxLastName.Text;
                var email = tbxEmail.Text;
                var gender = "";
                if (rbnMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                var userName = tbxUsername.Text;
                var password = tbxPassword.Text;


                if (firstName == string.Empty || lastName == string.Empty || email == string.Empty || userName == string.Empty || password == string.Empty)
                {
                    MessageBox.Show("can't be blank");
                }
                else
                {
                    var user = _userService.GetUserByUserName(userName);
                    if (user == null)
                    {
                        var savedUser = _userService.AddUser(new User
                        {
                            UserFirstName = firstName,
                            UserLastName = lastName,
                            UserGender = gender,
                            UserEmail = email,
                            UserName = userName,
                            UserPassword = password
                        });
                        if (savedUser != null)
                        {
                           UserForm userForm = new UserForm();
                           userForm.Show();
                           this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Couldn't add new user!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("this user has already been added");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
