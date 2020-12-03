using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEAAS.WindowsFormsUI.AdminModule;
using MEAAS.WindowsFormsUI.UserModule;

namespace MEAAS.WindowsFormsUI.HomeModule
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool move;
        private int mouse_x;
        private int mouse_y;

       

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void HomeForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            
        }

    }
}
