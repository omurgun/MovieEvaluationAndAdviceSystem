namespace MEAAS.WindowsFormsUI
{
    partial class Form1
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
            this.tbxRemove = new System.Windows.Forms.Button();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxUsernameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUsernameUpdate = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRemove
            // 
            this.tbxRemove.Location = new System.Drawing.Point(743, 331);
            this.tbxRemove.Name = "tbxRemove";
            this.tbxRemove.Size = new System.Drawing.Size(88, 29);
            this.tbxRemove.TabIndex = 14;
            this.tbxRemove.Text = "Remove";
            this.tbxRemove.UseVisualStyleBackColor = true;
            this.tbxRemove.Click += new System.EventHandler(this.tbxRemove_Click);
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(36, 90);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(49, 13);
            this.lblSurnameUpdate.TabIndex = 3;
            this.lblSurnameUpdate.Text = "Surname";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name ";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(133, 139);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(133, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 139);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(36, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // tbxUsernameUpdate
            // 
            this.tbxUsernameUpdate.Location = new System.Drawing.Point(133, 139);
            this.tbxUsernameUpdate.Name = "tbxUsernameUpdate";
            this.tbxUsernameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxUsernameUpdate.TabIndex = 6;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(133, 39);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lblUsernameUpdate
            // 
            this.lblUsernameUpdate.AutoSize = true;
            this.lblUsernameUpdate.Location = new System.Drawing.Point(36, 139);
            this.lblUsernameUpdate.Name = "lblUsernameUpdate";
            this.lblUsernameUpdate.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameUpdate.TabIndex = 5;
            this.lblUsernameUpdate.Text = "Username";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(133, 87);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(83, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUsernameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblUsernameUpdate);
            this.gbxUpdate.Controls.Add(this.lblSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxSurnameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(401, 331);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(256, 212);
            this.gbxUpdate.TabIndex = 13;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a user";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(36, 42);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(38, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name ";
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(133, 87);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxSurnameUpdate.TabIndex = 4;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxUsername);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblUsername);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxSurname);
            this.gbxAdd.Location = new System.Drawing.Point(34, 331);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(256, 212);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a user";
            // 
            // dgwUsers
            // 
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(34, 37);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(823, 197);
            this.dgwUsers.TabIndex = 11;
            this.dgwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.tbxRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwUsers);
            this.Name = "Form1";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbxRemove;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxUsernameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblUsernameUpdate;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.DataGridView dgwUsers;
    }
}

