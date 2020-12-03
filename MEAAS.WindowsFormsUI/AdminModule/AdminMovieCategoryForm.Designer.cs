
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMovieCategoryForm));
            this.gbxSearchMovieCategory = new System.Windows.Forms.GroupBox();
            this.tbxSearchMovieCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxUpdateMovieCategory = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUpdateMovieCategoryName = new System.Windows.Forms.TextBox();
            this.btnUpdateMovieCategory = new System.Windows.Forms.Button();
            this.gbxAddNewMovieCategory = new System.Windows.Forms.GroupBox();
            this.lblMovieCategoryName = new System.Windows.Forms.Label();
            this.tbxMovieCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddMovieCategory = new System.Windows.Forms.Button();
            this.dgwMovieCategory = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnDeleteMovieCategory = new System.Windows.Forms.Button();
            this.gbxSearchMovieCategory.SuspendLayout();
            this.gbxUpdateMovieCategory.SuspendLayout();
            this.gbxAddNewMovieCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearchMovieCategory
            // 
            this.gbxSearchMovieCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxSearchMovieCategory.Controls.Add(this.tbxSearchMovieCategory);
            this.gbxSearchMovieCategory.Controls.Add(this.label2);
            this.gbxSearchMovieCategory.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchMovieCategory.Location = new System.Drawing.Point(747, 355);
            this.gbxSearchMovieCategory.Name = "gbxSearchMovieCategory";
            this.gbxSearchMovieCategory.Size = new System.Drawing.Size(389, 124);
            this.gbxSearchMovieCategory.TabIndex = 42;
            this.gbxSearchMovieCategory.TabStop = false;
            this.gbxSearchMovieCategory.Text = "Search By Movie Category Name";
            // 
            // tbxSearchMovieCategory
            // 
            this.tbxSearchMovieCategory.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchMovieCategory.Location = new System.Drawing.Point(152, 48);
            this.tbxSearchMovieCategory.Name = "tbxSearchMovieCategory";
            this.tbxSearchMovieCategory.Size = new System.Drawing.Size(200, 30);
            this.tbxSearchMovieCategory.TabIndex = 2;
            this.tbxSearchMovieCategory.TextChanged += new System.EventHandler(this.TbxSearchMovieCategory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search ";
            // 
            // gbxUpdateMovieCategory
            // 
            this.gbxUpdateMovieCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxUpdateMovieCategory.Controls.Add(this.label1);
            this.gbxUpdateMovieCategory.Controls.Add(this.tbxUpdateMovieCategoryName);
            this.gbxUpdateMovieCategory.Controls.Add(this.btnUpdateMovieCategory);
            this.gbxUpdateMovieCategory.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdateMovieCategory.Location = new System.Drawing.Point(389, 355);
            this.gbxUpdateMovieCategory.Name = "gbxUpdateMovieCategory";
            this.gbxUpdateMovieCategory.Size = new System.Drawing.Size(352, 230);
            this.gbxUpdateMovieCategory.TabIndex = 43;
            this.gbxUpdateMovieCategory.TabStop = false;
            this.gbxUpdateMovieCategory.Text = "Update Movie Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbxUpdateMovieCategoryName
            // 
            this.tbxUpdateMovieCategoryName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateMovieCategoryName.Location = new System.Drawing.Point(133, 39);
            this.tbxUpdateMovieCategoryName.Name = "tbxUpdateMovieCategoryName";
            this.tbxUpdateMovieCategoryName.Size = new System.Drawing.Size(189, 30);
            this.tbxUpdateMovieCategoryName.TabIndex = 2;
            // 
            // btnUpdateMovieCategory
            // 
            this.btnUpdateMovieCategory.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateMovieCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateMovieCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateMovieCategory.FlatAppearance.BorderSize = 3;
            this.btnUpdateMovieCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnUpdateMovieCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovieCategory.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMovieCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMovieCategory.Location = new System.Drawing.Point(41, 121);
            this.btnUpdateMovieCategory.Name = "btnUpdateMovieCategory";
            this.btnUpdateMovieCategory.Size = new System.Drawing.Size(258, 75);
            this.btnUpdateMovieCategory.TabIndex = 49;
            this.btnUpdateMovieCategory.Text = "Update";
            this.btnUpdateMovieCategory.UseVisualStyleBackColor = false;
            this.btnUpdateMovieCategory.Click += new System.EventHandler(this.BtnUpdateMovieCategory_Click);
            // 
            // gbxAddNewMovieCategory
            // 
            this.gbxAddNewMovieCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxAddNewMovieCategory.Controls.Add(this.lblMovieCategoryName);
            this.gbxAddNewMovieCategory.Controls.Add(this.tbxMovieCategoryName);
            this.gbxAddNewMovieCategory.Controls.Add(this.btnAddMovieCategory);
            this.gbxAddNewMovieCategory.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAddNewMovieCategory.Location = new System.Drawing.Point(23, 355);
            this.gbxAddNewMovieCategory.Name = "gbxAddNewMovieCategory";
            this.gbxAddNewMovieCategory.Size = new System.Drawing.Size(360, 230);
            this.gbxAddNewMovieCategory.TabIndex = 41;
            this.gbxAddNewMovieCategory.TabStop = false;
            this.gbxAddNewMovieCategory.Text = "Add New Movie Category";
            // 
            // lblMovieCategoryName
            // 
            this.lblMovieCategoryName.AutoSize = true;
            this.lblMovieCategoryName.Location = new System.Drawing.Point(36, 42);
            this.lblMovieCategoryName.Name = "lblMovieCategoryName";
            this.lblMovieCategoryName.Size = new System.Drawing.Size(75, 28);
            this.lblMovieCategoryName.TabIndex = 1;
            this.lblMovieCategoryName.Text = "Name";
            // 
            // tbxMovieCategoryName
            // 
            this.tbxMovieCategoryName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMovieCategoryName.Location = new System.Drawing.Point(133, 39);
            this.tbxMovieCategoryName.Name = "tbxMovieCategoryName";
            this.tbxMovieCategoryName.Size = new System.Drawing.Size(183, 30);
            this.tbxMovieCategoryName.TabIndex = 2;
            // 
            // btnAddMovieCategory
            // 
            this.btnAddMovieCategory.BackColor = System.Drawing.Color.Lime;
            this.btnAddMovieCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMovieCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMovieCategory.FlatAppearance.BorderSize = 3;
            this.btnAddMovieCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnAddMovieCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovieCategory.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMovieCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovieCategory.Location = new System.Drawing.Point(41, 121);
            this.btnAddMovieCategory.Name = "btnAddMovieCategory";
            this.btnAddMovieCategory.Size = new System.Drawing.Size(258, 75);
            this.btnAddMovieCategory.TabIndex = 48;
            this.btnAddMovieCategory.Text = "Add";
            this.btnAddMovieCategory.UseVisualStyleBackColor = false;
            this.btnAddMovieCategory.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // dgwMovieCategory
            // 
            this.dgwMovieCategory.AllowUserToAddRows = false;
            this.dgwMovieCategory.AllowUserToDeleteRows = false;
            this.dgwMovieCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMovieCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovieCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwMovieCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.dgwMovieCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMovieCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwMovieCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovieCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMovieCategory.ColumnHeadersHeight = 30;
            this.dgwMovieCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMovieCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMovieCategory.EnableHeadersVisualStyles = false;
            this.dgwMovieCategory.Location = new System.Drawing.Point(23, 52);
            this.dgwMovieCategory.Name = "dgwMovieCategory";
            this.dgwMovieCategory.ReadOnly = true;
            this.dgwMovieCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMovieCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwMovieCategory.Size = new System.Drawing.Size(1113, 294);
            this.dgwMovieCategory.TabIndex = 3;
            this.dgwMovieCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwMovieCategory_CellClick);
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
            this.BtnBack.TabIndex = 47;
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
            this.BtnExit.TabIndex = 46;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDeleteMovieCategory
            // 
            this.btnDeleteMovieCategory.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMovieCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteMovieCategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteMovieCategory.FlatAppearance.BorderSize = 3;
            this.btnDeleteMovieCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnDeleteMovieCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovieCategory.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMovieCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMovieCategory.Location = new System.Drawing.Point(828, 496);
            this.btnDeleteMovieCategory.Name = "btnDeleteMovieCategory";
            this.btnDeleteMovieCategory.Size = new System.Drawing.Size(258, 75);
            this.btnDeleteMovieCategory.TabIndex = 50;
            this.btnDeleteMovieCategory.Text = "Delete";
            this.btnDeleteMovieCategory.UseVisualStyleBackColor = false;
            this.btnDeleteMovieCategory.Click += new System.EventHandler(this.BtnDeleteMovieCategory_Click);
            // 
            // AdminMovieCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1158, 665);
            this.Controls.Add(this.btnDeleteMovieCategory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dgwMovieCategory);
            this.Controls.Add(this.gbxSearchMovieCategory);
            this.Controls.Add(this.gbxUpdateMovieCategory);
            this.Controls.Add(this.gbxAddNewMovieCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMovieCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMovieCategoryForm";
            this.Load += new System.EventHandler(this.AdminMovieCategoryForm_Load);
            this.gbxSearchMovieCategory.ResumeLayout(false);
            this.gbxSearchMovieCategory.PerformLayout();
            this.gbxUpdateMovieCategory.ResumeLayout(false);
            this.gbxUpdateMovieCategory.PerformLayout();
            this.gbxAddNewMovieCategory.ResumeLayout(false);
            this.gbxAddNewMovieCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchMovieCategory;
        private System.Windows.Forms.TextBox tbxSearchMovieCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxUpdateMovieCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUpdateMovieCategoryName;
        private System.Windows.Forms.GroupBox gbxAddNewMovieCategory;
        private System.Windows.Forms.Label lblMovieCategoryName;
        private System.Windows.Forms.TextBox tbxMovieCategoryName;
        private System.Windows.Forms.DataGridView dgwMovieCategory;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnAddMovieCategory;
        private System.Windows.Forms.Button btnDeleteMovieCategory;
        private System.Windows.Forms.Button btnUpdateMovieCategory;
    }
}