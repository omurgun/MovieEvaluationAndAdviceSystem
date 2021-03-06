﻿using System;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;
using MEAAS.WindowsFormsUI.HomeModule;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
        }
        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgwUsers.DataSource = _userService.GetAllUsers();
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text)){
                dgwUsers.DataSource = _userService.GetUsersByUserName(tbxSearch.Text);
            }
            else
            {
                LoadUsers();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminHomeMenuForm adminHomeMenuForm = new AdminHomeMenuForm();
            adminHomeMenuForm.Show();
            this.Hide();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var updateFirstName = tbxFirstName.Text;
                var updateLastName = tbxLastName.Text;
                var updateEmail = tbxEmail.Text;
                var updateGender = "";
                if (rbnMale.Checked)
                {
                    updateGender = "Male";
                }
                else
                {
                    updateGender = "Female";
                }

                var updateUserName = tbxUsername.Text;
                var updatePassword = tbxPassword.Text;


                if (updateFirstName == string.Empty || updateLastName == string.Empty || updateEmail == string.Empty ||
                    updateUserName == string.Empty || updatePassword == string.Empty)
                {
                    MessageBox.Show(@"can't be blank");
                }
                else
                {
                    var user = _userService.GetUserByUserName(updateUserName);
                    if (user != null)
                    {
                        var updatedUser = _userService.UpdateUser(new User
                        {
                            Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value),
                            UserFirstName = tbxUpdateFirstName.Text,
                            UserLastName = tbxUpdateLastName.Text,
                            UserEmail = tbxUpdateEmail.Text,
                            UserGender = rbnUpdateFemale.Text,
                            UserName = tbxUpdateUserName.Text,
                            UserPassword = tbxUpdatePassword.Text
                        });
                        if (updatedUser != null)
                        {
                            LoadUsers();
                            MessageBox.Show(@"user updated.");
                        }
                        else
                        {
                            MessageBox.Show(@"Couldn't update user!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show(@"There is no such user");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgwUsers.CurrentRow != null)
            {
                _userService.DeleteUser(new User
                {
                    Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value)
                });
                LoadUsers();
                MessageBox.Show(@"User Deleted!");
            }
            else
            {
                MessageBox.Show(@"Please Select User!");
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
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
                    MessageBox.Show(@"can't be blank");
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
                            LoadUsers();
                            tbxFirstName.Text = "";
                            tbxLastName.Text = "";
                            tbxEmail.Text = "";
                            tbxUsername.Text = "";
                            tbxPassword.Text = "";
                            rbnMale.Checked = false;
                            rbnFemale.Checked = false;


                            MessageBox.Show(@"new user added.");
                        }
                        else
                        {
                            MessageBox.Show(@"Couldn't add new user!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"this user has already been added");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwUsers.CurrentRow != null)
            {
                tbxUpdateFirstName.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
                tbxUpdateLastName.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
                tbxUpdateEmail.Text = dgwUsers.CurrentRow.Cells[4].Value.ToString();
                tbxUpdateUserName.Text = dgwUsers.CurrentRow.Cells[1].Value.ToString();
                tbxUpdatePassword.Text = dgwUsers.CurrentRow.Cells[6].Value.ToString();
                if (dgwUsers.CurrentRow.Cells[5].Value.ToString() == "Male")
                {
                    rbnUpdateMale.Checked = true;

                }
                else
                {
                    rbnUpdateFemale.Checked = true;
                }
            }
        }

        private bool move;
        private int mouse_x;
        private int mouse_y;


        private void AdminUserForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AdminUserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void AdminUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
    }
}
