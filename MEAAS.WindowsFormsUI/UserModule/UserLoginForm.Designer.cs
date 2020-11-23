
namespace MEAAS.WindowsFormsUI.UserModule
{
    partial class UserLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.btnGoRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.BackColor = System.Drawing.Color.Aqua;
            this.btnUserLogin.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserLogin.Location = new System.Drawing.Point(59, 409);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(250, 100);
            this.btnUserLogin.TabIndex = 21;
            this.btnUserLogin.Text = "Login";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.BtnUserLogin_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserLogin.Location = new System.Drawing.Point(127, 24);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(369, 63);
            this.lblUserLogin.TabIndex = 19;
            this.lblUserLogin.Text = "USER LOGIN";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(380, 256);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(196, 45);
            this.tbxPassword.TabIndex = 20;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 54);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(50, 161);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(285, 54);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "User Name :";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.Location = new System.Drawing.Point(380, 171);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(196, 45);
            this.tbxUserName.TabIndex = 17;
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGoRegister.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoRegister.Location = new System.Drawing.Point(326, 409);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(250, 100);
            this.btnGoRegister.TabIndex = 22;
            this.btnGoRegister.Text = "Go Register";
            this.btnGoRegister.UseVisualStyleBackColor = false;
            this.btnGoRegister.Click += new System.EventHandler(this.BtnGoRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aqua;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ImageIndex = 0;
            this.btnBack.ImageList = this.ımageList1;
            this.btnBack.Location = new System.Drawing.Point(12, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 35);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "left-arrow.png");
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoRegister);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Button btnGoRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList ımageList1;
    }
}