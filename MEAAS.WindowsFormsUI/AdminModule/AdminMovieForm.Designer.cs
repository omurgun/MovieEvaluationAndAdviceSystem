
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.cbxMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.tbxThumbnailUrl = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxMovieSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblUpdateThumbnailUrl = new System.Windows.Forms.Label();
            this.tbxUpdateThumbnailUrl = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.tbxUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.tbxRemoveMovie = new System.Windows.Forms.Button();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.cbxMovieCategory);
            this.gbxAdd.Controls.Add(this.lblThumbnail);
            this.gbxAdd.Controls.Add(this.tbxThumbnailUrl);
            this.gbxAdd.Controls.Add(this.btnAddMovie);
            this.gbxAdd.Controls.Add(this.lblTitle);
            this.gbxAdd.Controls.Add(this.tbxTitle);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Location = new System.Drawing.Point(469, 335);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(250, 232);
            this.gbxAdd.TabIndex = 34;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New Movie";
            // 
            // cbxMovieCategory
            // 
            this.cbxMovieCategory.FormattingEnabled = true;
            this.cbxMovieCategory.Location = new System.Drawing.Point(133, 87);
            this.cbxMovieCategory.Name = "cbxMovieCategory";
            this.cbxMovieCategory.Size = new System.Drawing.Size(100, 21);
            this.cbxMovieCategory.TabIndex = 11;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(36, 136);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(72, 13);
            this.lblThumbnail.TabIndex = 9;
            this.lblThumbnail.Text = "Thumbnail Url";
            this.lblThumbnail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxThumbnailUrl
            // 
            this.tbxThumbnailUrl.Location = new System.Drawing.Point(133, 133);
            this.tbxThumbnailUrl.Name = "tbxThumbnailUrl";
            this.tbxThumbnailUrl.Size = new System.Drawing.Size(100, 20);
            this.tbxThumbnailUrl.TabIndex = 10;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(73, 182);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(88, 29);
            this.btnAddMovie.TabIndex = 8;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(133, 39);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxTitle.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(36, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Category";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxMovieSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(213, 335);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(250, 100);
            this.gbxSearch.TabIndex = 37;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Movie Title";
            // 
            // tbxMovieSearch
            // 
            this.tbxMovieSearch.Location = new System.Drawing.Point(73, 48);
            this.tbxMovieSearch.Name = "tbxMovieSearch";
            this.tbxMovieSearch.Size = new System.Drawing.Size(156, 20);
            this.tbxMovieSearch.TabIndex = 2;
            this.tbxMovieSearch.TextChanged += new System.EventHandler(this.TbxMovieSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
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
            this.dgwMovies.BackgroundColor = System.Drawing.Color.Black;
            this.dgwMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMovies.ColumnHeadersHeight = 30;
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMovies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMovies.EnableHeadersVisualStyles = false;
            this.dgwMovies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.dgwMovies.Location = new System.Drawing.Point(119, 21);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.ReadOnly = true;
            this.dgwMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwMovies.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwMovies.Size = new System.Drawing.Size(765, 278);
            this.dgwMovies.TabIndex = 33;
            this.dgwMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwMovies_CellClick);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxUpdateMovieCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateThumbnailUrl);
            this.gbxUpdate.Controls.Add(this.tbxUpdateThumbnailUrl);
            this.gbxUpdate.Controls.Add(this.lblUpdateTitle);
            this.gbxUpdate.Controls.Add(this.tbxUpdateTitle);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdate.Controls.Add(this.btnUpdateMovie);
            this.gbxUpdate.Location = new System.Drawing.Point(725, 335);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(250, 232);
            this.gbxUpdate.TabIndex = 35;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Movie";
            // 
            // cbxUpdateMovieCategory
            // 
            this.cbxUpdateMovieCategory.FormattingEnabled = true;
            this.cbxUpdateMovieCategory.Location = new System.Drawing.Point(120, 87);
            this.cbxUpdateMovieCategory.Name = "cbxUpdateMovieCategory";
            this.cbxUpdateMovieCategory.Size = new System.Drawing.Size(100, 21);
            this.cbxUpdateMovieCategory.TabIndex = 17;
            // 
            // lblUpdateThumbnailUrl
            // 
            this.lblUpdateThumbnailUrl.AutoSize = true;
            this.lblUpdateThumbnailUrl.Location = new System.Drawing.Point(23, 136);
            this.lblUpdateThumbnailUrl.Name = "lblUpdateThumbnailUrl";
            this.lblUpdateThumbnailUrl.Size = new System.Drawing.Size(72, 13);
            this.lblUpdateThumbnailUrl.TabIndex = 15;
            this.lblUpdateThumbnailUrl.Text = "Thumbnail Url";
            this.lblUpdateThumbnailUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpdateThumbnailUrl
            // 
            this.tbxUpdateThumbnailUrl.Location = new System.Drawing.Point(120, 133);
            this.tbxUpdateThumbnailUrl.Name = "tbxUpdateThumbnailUrl";
            this.tbxUpdateThumbnailUrl.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateThumbnailUrl.TabIndex = 16;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(23, 42);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(27, 13);
            this.lblUpdateTitle.TabIndex = 12;
            this.lblUpdateTitle.Text = "Title";
            // 
            // tbxUpdateTitle
            // 
            this.tbxUpdateTitle.Location = new System.Drawing.Point(120, 39);
            this.tbxUpdateTitle.Name = "tbxUpdateTitle";
            this.tbxUpdateTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateTitle.TabIndex = 13;
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(23, 90);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateCategory.TabIndex = 14;
            this.lblUpdateCategory.Text = "Category";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(69, 182);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(88, 29);
            this.btnUpdateMovie.TabIndex = 8;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // tbxRemoveMovie
            // 
            this.tbxRemoveMovie.Location = new System.Drawing.Point(224, 463);
            this.tbxRemoveMovie.Name = "tbxRemoveMovie";
            this.tbxRemoveMovie.Size = new System.Drawing.Size(88, 29);
            this.tbxRemoveMovie.TabIndex = 36;
            this.tbxRemoveMovie.Text = "Remove Movie";
            this.tbxRemoveMovie.UseVisualStyleBackColor = true;
            this.tbxRemoveMovie.Click += new System.EventHandler(this.TbxRemoveMovie_Click);
            // 
            // AdminMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1018, 817);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgwMovies);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.tbxRemoveMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMovieForm";
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
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxMovieSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button tbxRemoveMovie;
        private System.Windows.Forms.ComboBox cbxMovieCategory;
        private System.Windows.Forms.ComboBox cbxUpdateMovieCategory;
        private System.Windows.Forms.Label lblUpdateThumbnailUrl;
        private System.Windows.Forms.TextBox tbxUpdateThumbnailUrl;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox tbxUpdateTitle;
        private System.Windows.Forms.Label lblUpdateCategory;
    }
}