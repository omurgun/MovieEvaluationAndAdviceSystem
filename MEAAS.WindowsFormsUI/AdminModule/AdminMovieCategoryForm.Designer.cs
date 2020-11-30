
namespace MEAAS.WindowsFormsUI.AdminModule
{
    partial class AdminMovieCategoryForm
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
            this.gbxSearchMovieCategory = new System.Windows.Forms.GroupBox();
            this.tbxSearchMovieCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveMovieCategory = new System.Windows.Forms.Button();
            this.dgwMovieCategory = new System.Windows.Forms.DataGridView();
            this.gbxUpdateMovieCategory = new System.Windows.Forms.GroupBox();
            this.btnUpdateMovieCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUpdateMovieCategoryName = new System.Windows.Forms.TextBox();
            this.gbxAddNewMovieCategory = new System.Windows.Forms.GroupBox();
            this.btnAddMovieCategory = new System.Windows.Forms.Button();
            this.lblMovieCategoryName = new System.Windows.Forms.Label();
            this.tbxMovieCategoryName = new System.Windows.Forms.TextBox();
            this.gbxSearchMovieCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).BeginInit();
            this.gbxUpdateMovieCategory.SuspendLayout();
            this.gbxAddNewMovieCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearchMovieCategory
            // 
            this.gbxSearchMovieCategory.Controls.Add(this.tbxSearchMovieCategory);
            this.gbxSearchMovieCategory.Controls.Add(this.label2);
            this.gbxSearchMovieCategory.Location = new System.Drawing.Point(464, 255);
            this.gbxSearchMovieCategory.Name = "gbxSearchMovieCategory";
            this.gbxSearchMovieCategory.Size = new System.Drawing.Size(250, 100);
            this.gbxSearchMovieCategory.TabIndex = 42;
            this.gbxSearchMovieCategory.TabStop = false;
            this.gbxSearchMovieCategory.Text = "Search By Movie Category Name";
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
            // btnRemoveMovieCategory
            // 
            this.btnRemoveMovieCategory.Location = new System.Drawing.Point(487, 501);
            this.btnRemoveMovieCategory.Name = "btnRemoveMovieCategory";
            this.btnRemoveMovieCategory.Size = new System.Drawing.Size(150, 40);
            this.btnRemoveMovieCategory.TabIndex = 45;
            this.btnRemoveMovieCategory.Text = "Remove Movie Category";
            this.btnRemoveMovieCategory.UseVisualStyleBackColor = true;
            // 
            // dgwMovieCategory
            // 
            this.dgwMovieCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovieCategory.BackgroundColor = System.Drawing.Color.Black;
            this.dgwMovieCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovieCategory.Location = new System.Drawing.Point(743, 113);
            this.dgwMovieCategory.Name = "dgwMovieCategory";
            this.dgwMovieCategory.Size = new System.Drawing.Size(250, 200);
            this.dgwMovieCategory.TabIndex = 44;
            // 
            // gbxUpdateMovieCategory
            // 
            this.gbxUpdateMovieCategory.Controls.Add(this.btnUpdateMovieCategory);
            this.gbxUpdateMovieCategory.Controls.Add(this.label1);
            this.gbxUpdateMovieCategory.Controls.Add(this.tbxUpdateMovieCategoryName);
            this.gbxUpdateMovieCategory.Location = new System.Drawing.Point(323, 361);
            this.gbxUpdateMovieCategory.Name = "gbxUpdateMovieCategory";
            this.gbxUpdateMovieCategory.Size = new System.Drawing.Size(250, 120);
            this.gbxUpdateMovieCategory.TabIndex = 43;
            this.gbxUpdateMovieCategory.TabStop = false;
            this.gbxUpdateMovieCategory.Text = "Update Movie Category";
            // 
            // btnUpdateMovieCategory
            // 
            this.btnUpdateMovieCategory.Location = new System.Drawing.Point(73, 81);
            this.btnUpdateMovieCategory.Name = "btnUpdateMovieCategory";
            this.btnUpdateMovieCategory.Size = new System.Drawing.Size(88, 29);
            this.btnUpdateMovieCategory.TabIndex = 8;
            this.btnUpdateMovieCategory.Text = "Update";
            this.btnUpdateMovieCategory.UseVisualStyleBackColor = true;
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
            // tbxUpdateMovieCategoryName
            // 
            this.tbxUpdateMovieCategoryName.Location = new System.Drawing.Point(133, 39);
            this.tbxUpdateMovieCategoryName.Name = "tbxUpdateMovieCategoryName";
            this.tbxUpdateMovieCategoryName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateMovieCategoryName.TabIndex = 2;
            // 
            // gbxAddNewMovieCategory
            // 
            this.gbxAddNewMovieCategory.Controls.Add(this.btnAddMovieCategory);
            this.gbxAddNewMovieCategory.Controls.Add(this.lblMovieCategoryName);
            this.gbxAddNewMovieCategory.Controls.Add(this.tbxMovieCategoryName);
            this.gbxAddNewMovieCategory.Location = new System.Drawing.Point(77, 203);
            this.gbxAddNewMovieCategory.Name = "gbxAddNewMovieCategory";
            this.gbxAddNewMovieCategory.Size = new System.Drawing.Size(250, 120);
            this.gbxAddNewMovieCategory.TabIndex = 41;
            this.gbxAddNewMovieCategory.TabStop = false;
            this.gbxAddNewMovieCategory.Text = "Add New Movie Category";
            // 
            // btnAddMovieCategory
            // 
            this.btnAddMovieCategory.Location = new System.Drawing.Point(73, 81);
            this.btnAddMovieCategory.Name = "btnAddMovieCategory";
            this.btnAddMovieCategory.Size = new System.Drawing.Size(88, 29);
            this.btnAddMovieCategory.TabIndex = 8;
            this.btnAddMovieCategory.Text = "Add";
            this.btnAddMovieCategory.UseVisualStyleBackColor = true;
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
            // AdminMovieCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 770);
            this.Controls.Add(this.gbxSearchMovieCategory);
            this.Controls.Add(this.btnRemoveMovieCategory);
            this.Controls.Add(this.dgwMovieCategory);
            this.Controls.Add(this.gbxUpdateMovieCategory);
            this.Controls.Add(this.gbxAddNewMovieCategory);
            this.Name = "AdminMovieCategoryForm";
            this.Text = "AdminMovieCategoryForm";
            this.Load += new System.EventHandler(this.AdminMovieCategoryForm_Load);
            this.gbxSearchMovieCategory.ResumeLayout(false);
            this.gbxSearchMovieCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).EndInit();
            this.gbxUpdateMovieCategory.ResumeLayout(false);
            this.gbxUpdateMovieCategory.PerformLayout();
            this.gbxAddNewMovieCategory.ResumeLayout(false);
            this.gbxAddNewMovieCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchMovieCategory;
        private System.Windows.Forms.TextBox tbxSearchMovieCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveMovieCategory;
        private System.Windows.Forms.DataGridView dgwMovieCategory;
        private System.Windows.Forms.GroupBox gbxUpdateMovieCategory;
        private System.Windows.Forms.Button btnUpdateMovieCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUpdateMovieCategoryName;
        private System.Windows.Forms.GroupBox gbxAddNewMovieCategory;
        private System.Windows.Forms.Button btnAddMovieCategory;
        private System.Windows.Forms.Label lblMovieCategoryName;
        private System.Windows.Forms.TextBox tbxMovieCategoryName;
    }
}