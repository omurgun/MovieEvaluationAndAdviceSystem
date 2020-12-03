using System;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.WindowsFormsUI.HomeModule;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private readonly IAdminService _adminService = InstanceFactory.GetInstance<IAdminService>();

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            var adminName = tbxAdminName.Text;
            var password = tbxPassword.Text;

            if (adminName == string.Empty || password == string.Empty)
            {
                MessageBox.Show(@"can't be blank");
            }
            else
            {
                var admin = _adminService.GetAdminByAdminNameAndPassword(adminName, password);
                if (admin != null)
                {
                    
                    AdminHomeMenuForm adminHomeMenuForm = new AdminHomeMenuForm();
                    adminHomeMenuForm.lblAdminName.Text = adminName;
                    adminHomeMenuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(@"Admin name or password is incorrect!");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private bool move;
        private int mouse_x;
        private int mouse_y;


        private void AdminLoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void AdminLoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void AdminLoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
