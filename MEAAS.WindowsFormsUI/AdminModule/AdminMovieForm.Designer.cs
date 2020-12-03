
namespace MEAAS.WindowsFormsUI.AdminModule
{
    partial class AdminMovieForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMovieForm));
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.cbxMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.tbxThumbnailUrl = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxMovieSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.cbxUpdateMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblUpdateThumbnailUrl = new System.Windows.Forms.Label();
            this.tbxUpdateThumbnailUrl = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.tbxUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxAdd.Controls.Add(this.btnAddMovie);
            this.gbxAdd.Controls.Add(this.cbxMovieCategory);
            this.gbxAdd.Controls.Add(this.lblThumbnail);
            this.gbxAdd.Controls.Add(this.tbxThumbnailUrl);
            this.gbxAdd.Controls.Add(this.lblTitle);
            this.gbxAdd.Controls.Add(this.tbxTitle);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.Location = new System.Drawing.Point(9, 354);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(390, 300);
            this.gbxAdd.TabIndex = 34;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New Movie";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Lime;
            this.btnAddMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMovie.FlatAppearance.BorderSize = 3;
            this.btnAddMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.Location = new System.Drawing.Point(76, 210);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(258, 75);
            this.btnAddMovie.TabIndex = 40;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // cbxMovieCategory
            // 
            this.cbxMovieCategory.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMovieCategory.FormattingEnabled = true;
            this.cbxMovieCategory.Location = new System.Drawing.Point(208, 97);
            this.cbxMovieCategory.Name = "cbxMovieCategory";
            this.cbxMovieCategory.Size = new System.Drawing.Size(170, 31);
            this.cbxMovieCategory.TabIndex = 11;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThumbnail.Location = new System.Drawing.Point(36, 159);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(160, 27);
            this.lblThumbnail.TabIndex = 9;
            this.lblThumbnail.Text = "Thumbnail Url";
            this.lblThumbnail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxThumbnailUrl
            // 
            this.tbxThumbnailUrl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxThumbnailUrl.Location = new System.Drawing.Point(208, 156);
            this.tbxThumbnailUrl.Name = "tbxThumbnailUrl";
            this.tbxThumbnailUrl.Size = new System.Drawing.Size(170, 30);
            this.tbxThumbnailUrl.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(36, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTitle.Location = new System.Drawing.Point(208, 42);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(170, 30);
            this.tbxTitle.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(36, 97);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(108, 27);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Category";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxSearch.Controls.Add(this.tbxMovieSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.Location = new System.Drawing.Point(801, 354);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(349, 100);
            this.gbxSearch.TabIndex = 37;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Movie Title";
            // 
            // tbxMovieSearch
            // 
            this.tbxMovieSearch.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMovieSearch.Location = new System.Drawing.Point(127, 49);
            this.tbxMovieSearch.Name = "tbxMovieSearch";
            this.tbxMovieSearch.Size = new System.Drawing.Size(216, 30);
            this.tbxMovieSearch.TabIndex = 2;
            this.tbxMovieSearch.TextChanged += new System.EventHandler(this.TbxMovieSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(101, 28);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search :";
            // 
            // dgwMovies
            // 
            this.dgwMovies.AllowUserToAddRows = false;
            this.dgwMovies.AllowUserToDeleteRows = false;
            this.dgwMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.dgwMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMovies.ColumnHeadersHeight = 30;
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMovies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMovies.EnableHeadersVisualStyles = false;
            this.dgwMovies.Location = new System.Drawing.Point(9, 52);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.ReadOnly = true;
            this.dgwMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwMovies.Size = new System.Drawing.Size(1141, 296);
            this.dgwMovies.TabIndex = 0;
            this.dgwMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwMovies_CellClick);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxUpdate.Controls.Add(this.btnUpdateMovie);
            this.gbxUpdate.Controls.Add(this.cbxUpdateMovieCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateThumbnailUrl);
            this.gbxUpdate.Controls.Add(this.tbxUpdateThumbnailUrl);
            this.gbxUpdate.Controls.Add(this.lblUpdateTitle);
            this.gbxUpdate.Controls.Add(this.tbxUpdateTitle);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdate.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(405, 354);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(390, 300);
            this.gbxUpdate.TabIndex = 35;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Movie";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateMovie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateMovie.FlatAppearance.BorderSize = 3;
            this.btnUpdateMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMovie.Location = new System.Drawing.Point(66, 210);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(258, 75);
            this.btnUpdateMovie.TabIndex = 41;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // cbxUpdateMovieCategory
            // 
            this.cbxUpdateMovieCategory.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUpdateMovieCategory.FormattingEnabled = true;
            this.cbxUpdateMovieCategory.Location = new System.Drawing.Point(195, 96);
            this.cbxUpdateMovieCategory.Name = "cbxUpdateMovieCategory";
            this.cbxUpdateMovieCategory.Size = new System.Drawing.Size(179, 31);
            this.cbxUpdateMovieCategory.TabIndex = 17;
            // 
            // lblUpdateThumbnailUrl
            // 
            this.lblUpdateThumbnailUrl.AutoSize = true;
            this.lblUpdateThumbnailUrl.Location = new System.Drawing.Point(23, 157);
            this.lblUpdateThumbnailUrl.Name = "lblUpdateThumbnailUrl";
            this.lblUpdateThumbnailUrl.Size = new System.Drawing.Size(167, 28);
            this.lblUpdateThumbnailUrl.TabIndex = 15;
            this.lblUpdateThumbnailUrl.Text = "Thumbnail Url";
            this.lblUpdateThumbnailUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpdateThumbnailUrl
            // 
            this.tbxUpdateThumbnailUrl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateThumbnailUrl.Location = new System.Drawing.Point(195, 154);
            this.tbxUpdateThumbnailUrl.Name = "tbxUpdateThumbnailUrl";
            this.tbxUpdateThumbnailUrl.Size = new System.Drawing.Size(179, 30);
            this.tbxUpdateThumbnailUrl.TabIndex = 16;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(23, 42);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(62, 28);
            this.lblUpdateTitle.TabIndex = 12;
            this.lblUpdateTitle.Text = "Title";
            // 
            // tbxUpdateTitle
            // 
            this.tbxUpdateTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateTitle.Location = new System.Drawing.Point(195, 39);
            this.tbxUpdateTitle.Name = "tbxUpdateTitle";
            this.tbxUpdateTitle.Size = new System.Drawing.Size(179, 30);
            this.tbxUpdateTitle.TabIndex = 13;
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(23, 99);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(111, 28);
            this.lblUpdateCategory.TabIndex = 14;
            this.lblUpdateCategory.Text = "Category";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(34, 34);
            this.BtnBack.TabIndex = 39;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(1118, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 34);
            this.BtnExit.TabIndex = 38;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveMovie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveMovie.FlatAppearance.BorderSize = 3;
            this.btnRemoveMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnRemoveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMovie.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveMovie.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveMovie.Location = new System.Drawing.Point(844, 478);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(258, 75);
            this.btnRemoveMovie.TabIndex = 42;
            this.btnRemoveMovie.Text = "Delete";
            this.btnRemoveMovie.UseVisualStyleBackColor = false;
            this.btnRemoveMovie.Click += new System.EventHandler(this.BtnRemoveMovie_Click);
            // 
            // AdminMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1164, 667);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgwMovies);
            this.Controls.Add(this.gbxUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-Moive Panel";
            this.Load += new System.EventHandler(this.AdminMovieForm_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.TextBox tbxThumbnailUrl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxMovieSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxMovieCategory;
        private System.Windows.Forms.ComboBox cbxUpdateMovieCategory;
        private System.Windows.Forms.Label lblUpdateThumbnailUrl;
        private System.Windows.Forms.TextBox tbxUpdateThumbnailUrl;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox tbxUpdateTitle;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
    }
}