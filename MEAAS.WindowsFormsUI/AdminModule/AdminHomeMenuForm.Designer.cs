
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
            this.btnMovie.Location = new System.Drawing.Point(125, 124);
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
            this.btnUser.Location = new System.Drawing.Point(125, 256);
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
            this.BtnExit.Location = new System.Drawing.Point(588, 12);
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
            this.btnMovieCategory.Location = new System.Drawing.Point(125, 386);
            this.btnMovieCategory.Name = "btnMovieCategory";
            this.btnMovieCategory.Size = new System.Drawing.Size(388, 100);
            this.btnMovieCategory.TabIndex = 4;
            this.btnMovieCategory.Text = "Movie Category";
            this.btnMovieCategory.UseVisualStyleBackColor = false;
            this.btnMovieCategory.Click += new System.EventHandler(this.BtnMovieCategory_Click);
            // 
            // AdminHomeMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(650, 650);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnMovieCategory;
    }
}