using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEAAS.WindowsFormsUI.HomeModule;

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
            ResetAdminInfo();
            Application.Exit();
        }

        private void BtnMovieCategory_Click(object sender, EventArgs e)
        {
            AdminMovieCategoryForm adminMovieCategoryForm = new AdminMovieCategoryForm();
            adminMovieCategoryForm.Show();
            this.Hide();
        }

        private void BtnAdminLogOut_Click(object sender, EventArgs e)
        {

            ResetAdminInfo();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void AdminHomeMenuForm_Load(object sender, EventArgs e)
        {
            bool isThereAdminName = (bool)Properties.Settings.Default["IsThereAdminName"];
            if (!isThereAdminName)
            {
                var adminName = lblAdminName.Text;
                Properties.Settings.Default["AdminName"] = adminName;
                Properties.Settings.Default["IsThereAdminName"] = true;
            }
            SetAdminInfo();
        }

        private void SetAdminInfo()
        {
            lblAdminName.Text = Properties.Settings.Default["AdminName"].ToString();
            
        }

        private void ResetAdminInfo()
        {
            Properties.Settings.Default["AdminName"] = "";
            Properties.Settings.Default["IsThereAdminName"] = false;
        }

        private bool move;
        private int mouse_x;
        private int mouse_y;


        private void AdminHomeMenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void AdminHomeMenuForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AdminHomeMenuForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
