using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    public partial class AdminHomeMenuForm : Form
    {
        public AdminHomeMenuForm()
        {
            InitializeComponent();
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            AdminMovieForm adminMovieForm = new AdminMovieForm();
            adminMovieForm.Show();
            this.Hide();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            AdminUserForm adminUserForm = new AdminUserForm();
            adminUserForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMovieCategory_Click(object sender, EventArgs e)
        {
            AdminMovieCategoryForm adminMovieCategoryForm = new AdminMovieCategoryForm();
            adminMovieCategoryForm.Show();
            this.Hide();
        }
    }
}
