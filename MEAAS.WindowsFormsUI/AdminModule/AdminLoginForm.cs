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
                MessageBox.Show("can't be blank");
            }
            else
            {
                var admin = _adminService.GetAdminByAdminNameAndPassword(adminName, password);
                if (admin != null)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Admin name or password is incorrect!");
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
