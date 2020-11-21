
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
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.cbxMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.tbxThumbnailUrl = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateMovieCategory = new System.Windows.Forms.ComboBox();
            this.lblUpdateThumbnailUrl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.tbxRemoveMovie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddMovieCategory = new System.Windows.Forms.Button();
            this.lblMovieCategoryName = new System.Windows.Forms.Label();
            this.tbxMovieCategoryName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateMovieCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUpdateMovieCategory = new System.Windows.Forms.TextBox();
            this.dgwMovieCategory = new System.Windows.Forms.DataGridView();
            this.btnRemoveMovieCategory = new System.Windows.Forms.Button();
            this.gbxMovieCategory = new System.Windows.Forms.GroupBox();
            this.tbxSearchMovieCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).BeginInit();
            this.gbxMovieCategory.SuspendLayout();
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
            this.gbxAdd.Location = new System.Drawing.Point(-3, 211);
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
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(509, 211);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(250, 100);
            this.gbxSearch.TabIndex = 37;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Movie Title";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(73, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(156, 20);
            this.tbxSearch.TabIndex = 2;
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
            this.dgwMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovies.Location = new System.Drawing.Point(-3, 5);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.Size = new System.Drawing.Size(765, 200);
            this.dgwMovies.TabIndex = 33;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxUpdateMovieCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateThumbnailUrl);
            this.gbxUpdate.Controls.Add(this.textBox1);
            this.gbxUpdate.Controls.Add(this.lblUpdateTitle);
            this.gbxUpdate.Controls.Add(this.textBox2);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdate.Controls.Add(this.btnUpdateMovie);
            this.gbxUpdate.Location = new System.Drawing.Point(253, 211);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
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
            this.tbxRemoveMovie.Location = new System.Drawing.Point(509, 317);
            this.tbxRemoveMovie.Name = "tbxRemoveMovie";
            this.tbxRemoveMovie.Size = new System.Drawing.Size(88, 29);
            this.tbxRemoveMovie.TabIndex = 36;
            this.tbxRemoveMovie.Text = "Remove Movie";
            this.tbxRemoveMovie.UseVisualStyleBackColor = true;
            this.tbxRemoveMovie.Click += new System.EventHandler(this.TbxRemoveMovie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMovieCategory);
            this.groupBox1.Controls.Add(this.lblMovieCategoryName);
            this.groupBox1.Controls.Add(this.tbxMovieCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(765, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 123);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Movie Category";
            // 
            // btnAddMovieCategory
            // 
            this.btnAddMovieCategory.Location = new System.Drawing.Point(73, 81);
            this.btnAddMovieCategory.Name = "btnAddMovieCategory";
            this.btnAddMovieCategory.Size = new System.Drawing.Size(88, 29);
            this.btnAddMovieCategory.TabIndex = 8;
            this.btnAddMovieCategory.Text = "Add";
            this.btnAddMovieCategory.UseVisualStyleBackColor = true;
            this.btnAddMovieCategory.Click += new System.EventHandler(this.BtnAddMovieCategory_Click);
            // 
            // lblMovieCategoryName
            // 
            this.lblMovieCategoryName.AutoSize = true;
            this.lblMovieCategoryName.Location = new System.Drawing.Point(36, 42);
            this.lblMovieCategoryName.Name = "lblMovieCategoryName";
            this.lblMovieCategoryName.Size = new System.Drawing.Size(35, 13);
            this.lblMovieCategoryName.TabIndex = 1;
            this.lblMovieCategoryName.Text = "Name";
            // 
            // tbxMovieCategoryName
            // 
            this.tbxMovieCategoryName.Location = new System.Drawing.Point(133, 39);
            this.tbxMovieCategoryName.Name = "tbxMovieCategoryName";
            this.tbxMovieCategoryName.Size = new System.Drawing.Size(100, 20);
            this.tbxMovieCategoryName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateMovieCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxUpdateMovieCategory);
            this.groupBox2.Location = new System.Drawing.Point(765, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 123);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Movie Category";
            // 
            // btnUpdateMovieCategory
            // 
            this.btnUpdateMovieCategory.Location = new System.Drawing.Point(73, 81);
            this.btnUpdateMovieCategory.Name = "btnUpdateMovieCategory";
            this.btnUpdateMovieCategory.Size = new System.Drawing.Size(88, 29);
            this.btnUpdateMovieCategory.TabIndex = 8;
            this.btnUpdateMovieCategory.Text = "Update";
            this.btnUpdateMovieCategory.UseVisualStyleBackColor = true;
            this.btnUpdateMovieCategory.Click += new System.EventHandler(this.BtnUpdateMovieCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbxUpdateMovieCategory
            // 
            this.tbxUpdateMovieCategory.Location = new System.Drawing.Point(133, 39);
            this.tbxUpdateMovieCategory.Name = "tbxUpdateMovieCategory";
            this.tbxUpdateMovieCategory.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateMovieCategory.TabIndex = 2;
            // 
            // dgwMovieCategory
            // 
            this.dgwMovieCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovieCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovieCategory.Location = new System.Drawing.Point(768, 5);
            this.dgwMovieCategory.Name = "dgwMovieCategory";
            this.dgwMovieCategory.Size = new System.Drawing.Size(247, 200);
            this.dgwMovieCategory.TabIndex = 39;
            // 
            // btnRemoveMovieCategory
            // 
            this.btnRemoveMovieCategory.Location = new System.Drawing.Point(765, 575);
            this.btnRemoveMovieCategory.Name = "btnRemoveMovieCategory";
            this.btnRemoveMovieCategory.Size = new System.Drawing.Size(158, 42);
            this.btnRemoveMovieCategory.TabIndex = 40;
            this.btnRemoveMovieCategory.Text = "Remove Movie Category";
            this.btnRemoveMovieCategory.UseVisualStyleBackColor = true;
            this.btnRemoveMovieCategory.Click += new System.EventHandler(this.BtnRemoveMovieCategory_Click);
            // 
            // gbxMovieCategory
            // 
            this.gbxMovieCategory.Controls.Add(this.tbxSearchMovieCategory);
            this.gbxMovieCategory.Controls.Add(this.label2);
            this.gbxMovieCategory.Location = new System.Drawing.Point(765, 469);
            this.gbxMovieCategory.Name = "gbxMovieCategory";
            this.gbxMovieCategory.Size = new System.Drawing.Size(250, 100);
            this.gbxMovieCategory.TabIndex = 38;
            this.gbxMovieCategory.TabStop = false;
            this.gbxMovieCategory.Text = "Search By Movie Category Name";
            // 
            // tbxSearchMovieCategory
            // 
            this.tbxSearchMovieCategory.Location = new System.Drawing.Point(73, 48);
            this.tbxSearchMovieCategory.Name = "tbxSearchMovieCategory";
            this.tbxSearchMovieCategory.Size = new System.Drawing.Size(156, 20);
            this.tbxSearchMovieCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search :";
            // 
            // AdminMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 750);
            this.Controls.Add(this.gbxMovieCategory);
            this.Controls.Add(this.btnRemoveMovieCategory);
            this.Controls.Add(this.dgwMovieCategory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgwMovies);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.tbxRemoveMovie);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).EndInit();
            this.gbxMovieCategory.ResumeLayout(false);
            this.gbxMovieCategory.PerformLayout();
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
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwMovies;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button tbxRemoveMovie;
        private System.Windows.Forms.ComboBox cbxMovieCategory;
        private System.Windows.Forms.ComboBox cbxUpdateMovieCategory;
        private System.Windows.Forms.Label lblUpdateThumbnailUrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMovieCategory;
        private System.Windows.Forms.Label lblMovieCategoryName;
        private System.Windows.Forms.TextBox tbxMovieCategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateMovieCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUpdateMovieCategory;
        private System.Windows.Forms.DataGridView dgwMovieCategory;
        private System.Windows.Forms.Button btnRemoveMovieCategory;
        private System.Windows.Forms.GroupBox gbxMovieCategory;
        private System.Windows.Forms.TextBox tbxSearchMovieCategory;
        private System.Windows.Forms.Label label2;
    }
}