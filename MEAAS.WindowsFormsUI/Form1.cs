using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;

namespace MEAAS.WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _userService.AddUser(new User
            {
                
                UserFirstName = tbxName.Text,
                UserLastName = tbxSurname.Text,
                UserName = tbxUsername.Text
            });
            LoadUsers();
            MessageBox.Show("User Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _userService.UpdateUser(new User
            {
                Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value),
                UserFirstName = tbxNameUpdate.Text,
                UserLastName = tbxSurnameUpdate.Text,
                UserName = tbxUsernameUpdate.Text
            });
            LoadUsers();
            MessageBox.Show("User Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwUsers.CurrentRow != null)
            {
                tbxNameUpdate.Text = dgwUsers.CurrentRow.Cells[1].Value.ToString();
                tbxSurnameUpdate.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
                tbxUsernameUpdate.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void tbxRemove_Click(object sender, EventArgs e)
        {
            _userService.DeleteUser(new User
            {
                Id = Convert.ToInt32(dgwUsers.CurrentRow.Cells[0].Value)
            });
            LoadUsers();
            MessageBox.Show("User Deleted!");
        }
    }
}
