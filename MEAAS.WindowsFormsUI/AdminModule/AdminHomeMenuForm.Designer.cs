
using MEAAS.WindowsFormsUI.HomeModule;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    partial class AdminHomeMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeMenuForm));
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnMovieCategory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnAdminLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.btnMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMovie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMovie.FlatAppearance.BorderSize = 3;
            this.btnMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMovie.ForeColor = System.Drawing.Color.Black;
            this.btnMovie.Location = new System.Drawing.Point(126, 224);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(388, 100);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.Text = "Movie";
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.BtnMovie_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.BorderSize = 3;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(126, 356);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(388, 100);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(604, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 34);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMovieCategory
            // 
            this.btnMovieCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(12)))));
            this.btnMovieCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMovieCategory.FlatAppearance.BorderSize = 3;
            this.btnMovieCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnMovieCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieCategory.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMovieCategory.ForeColor = System.Drawing.Color.Black;
            this.btnMovieCategory.Location = new System.Drawing.Point(126, 486);
            this.btnMovieCategory.Name = "btnMovieCategory";
            this.btnMovieCategory.Size = new System.Drawing.Size(388, 100);
            this.btnMovieCategory.TabIndex = 4;
            this.btnMovieCategory.Text = "Movie Category";
            this.btnMovieCategory.UseVisualStyleBackColor = false;
            this.btnMovieCategory.Click += new System.EventHandler(this.BtnMovieCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 79);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lblAdminName.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminName.Location = new System.Drawing.Point(130, 10);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(78, 28);
            this.lblAdminName.TabIndex = 6;
            this.lblAdminName.Text = "label1";
            // 
            // btnAdminLogOut
            // 
            this.btnAdminLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnAdminLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdminLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdminLogOut.FlatAppearance.BorderSize = 3;
            this.btnAdminLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnAdminLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogOut.Location = new System.Drawing.Point(101, 41);
            this.btnAdminLogOut.Name = "btnAdminLogOut";
            this.btnAdminLogOut.Size = new System.Drawing.Size(130, 41);
            this.btnAdminLogOut.TabIndex = 7;
            this.btnAdminLogOut.Text = "Log out";
            this.btnAdminLogOut.UseVisualStyleBackColor = false;
            this.btnAdminLogOut.Click += new System.EventHandler(this.BtnAdminLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAdminLogOut);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 86);
            this.panel1.TabIndex = 8;
            // 
            // AdminHomeMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMovieCategory);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminHomeMenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminHomeMenuForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminHomeMenuForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminHomeMenuForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminHomeMenuForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnMovieCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button btnAdminLogOut;
        private System.Windows.Forms.Panel panel1;
    }
}