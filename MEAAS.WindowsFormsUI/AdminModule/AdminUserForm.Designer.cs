namespace MEAAS.WindowsFormsUI.AdminModule
{
    partial class AdminUserForm
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.rbnUpdateFemale = new System.Windows.Forms.RadioButton();
            this.rbnUpdateMale = new System.Windows.Forms.RadioButton();
            this.tbxUpdatePassword = new System.Windows.Forms.TextBox();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdateGender = new System.Windows.Forms.Label();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.tbxUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.tbxUpdateUserName = new System.Windows.Forms.TextBox();
            this.tbxUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateUserName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.tbxUpdateLastName = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxRemove
            // 
            this.tbxRemove.Location = new System.Drawing.Point(677, 310);
            this.tbxRemove.Name = "tbxRemove";
            this.tbxRemove.Size = new System.Drawing.Size(88, 29);
            this.tbxRemove.TabIndex = 14;
            this.tbxRemove.Text = "Remove";
            this.tbxRemove.UseVisualStyleBackColor = true;
            this.tbxRemove.Click += new System.EventHandler(this.TbxRemove_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(65, 311);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 29);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Firstname ";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(133, 222);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(133, 39);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstName.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 222);
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
            this.lblSurname.Size = new System.Drawing.Size(53, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Lastname";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(133, 87);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.rbnUpdateFemale);
            this.gbxUpdate.Controls.Add(this.rbnUpdateMale);
            this.gbxUpdate.Controls.Add(this.tbxUpdatePassword);
            this.gbxUpdate.Controls.Add(this.lblUpdatePassword);
            this.gbxUpdate.Controls.Add(this.lblUpdateGender);
            this.gbxUpdate.Controls.Add(this.lblUpdateEmail);
            this.gbxUpdate.Controls.Add(this.tbxUpdateEmail);
            this.gbxUpdate.Controls.Add(this.lblUpdateFirstName);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUserName);
            this.gbxUpdate.Controls.Add(this.tbxUpdateFirstName);
            this.gbxUpdate.Controls.Add(this.lblUpdateUserName);
            this.gbxUpdate.Controls.Add(this.lblUpdateLastName);
            this.gbxUpdate.Controls.Add(this.tbxUpdateLastName);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(260, 205);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(250, 350);
            this.gbxUpdate.TabIndex = 13;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update User";
            // 
            // rbnUpdateFemale
            // 
            this.rbnUpdateFemale.AutoSize = true;
            this.rbnUpdateFemale.Location = new System.Drawing.Point(174, 171);
            this.rbnUpdateFemale.Name = "rbnUpdateFemale";
            this.rbnUpdateFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnUpdateFemale.TabIndex = 29;
            this.rbnUpdateFemale.TabStop = true;
            this.rbnUpdateFemale.Text = "Female";
            this.rbnUpdateFemale.UseVisualStyleBackColor = true;
            // 
            // rbnUpdateMale
            // 
            this.rbnUpdateMale.AutoSize = true;
            this.rbnUpdateMale.Location = new System.Drawing.Point(120, 171);
            this.rbnUpdateMale.Name = "rbnUpdateMale";
            this.rbnUpdateMale.Size = new System.Drawing.Size(48, 17);
            this.rbnUpdateMale.TabIndex = 28;
            this.rbnUpdateMale.TabStop = true;
            this.rbnUpdateMale.Text = "Male";
            this.rbnUpdateMale.UseVisualStyleBackColor = true;
            // 
            // tbxUpdatePassword
            // 
            this.tbxUpdatePassword.Location = new System.Drawing.Point(120, 267);
            this.tbxUpdatePassword.Name = "tbxUpdatePassword";
            this.tbxUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePassword.TabIndex = 27;
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Location = new System.Drawing.Point(23, 267);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(53, 13);
            this.lblUpdatePassword.TabIndex = 26;
            this.lblUpdatePassword.Text = "Password";
            // 
            // lblUpdateGender
            // 
            this.lblUpdateGender.AutoSize = true;
            this.lblUpdateGender.Location = new System.Drawing.Point(23, 171);
            this.lblUpdateGender.Name = "lblUpdateGender";
            this.lblUpdateGender.Size = new System.Drawing.Size(42, 13);
            this.lblUpdateGender.TabIndex = 25;
            this.lblUpdateGender.Text = "Gender";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(23, 133);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUpdateEmail.TabIndex = 23;
            this.lblUpdateEmail.Text = "Email";
            // 
            // tbxUpdateEmail
            // 
            this.tbxUpdateEmail.Location = new System.Drawing.Point(120, 130);
            this.tbxUpdateEmail.Name = "tbxUpdateEmail";
            this.tbxUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateEmail.TabIndex = 24;
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(23, 39);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateFirstName.TabIndex = 17;
            this.lblUpdateFirstName.Text = "Firstname ";
            // 
            // tbxUpdateUserName
            // 
            this.tbxUpdateUserName.Location = new System.Drawing.Point(120, 219);
            this.tbxUpdateUserName.Name = "tbxUpdateUserName";
            this.tbxUpdateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUserName.TabIndex = 22;
            // 
            // tbxUpdateFirstName
            // 
            this.tbxUpdateFirstName.Location = new System.Drawing.Point(120, 36);
            this.tbxUpdateFirstName.Name = "tbxUpdateFirstName";
            this.tbxUpdateFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateFirstName.TabIndex = 18;
            // 
            // lblUpdateUserName
            // 
            this.lblUpdateUserName.AutoSize = true;
            this.lblUpdateUserName.Location = new System.Drawing.Point(23, 219);
            this.lblUpdateUserName.Name = "lblUpdateUserName";
            this.lblUpdateUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateUserName.TabIndex = 21;
            this.lblUpdateUserName.Text = "Username";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(23, 87);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(53, 13);
            this.lblUpdateLastName.TabIndex = 19;
            this.lblUpdateLastName.Text = "Lastname";
            // 
            // tbxUpdateLastName
            // 
            this.tbxUpdateLastName.Location = new System.Drawing.Point(120, 84);
            this.tbxUpdateLastName.Name = "tbxUpdateLastName";
            this.tbxUpdateLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateLastName.TabIndex = 20;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.rbnFemale);
            this.gbxAdd.Controls.Add(this.rbnMale);
            this.gbxAdd.Controls.Add(this.tbxPassword);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.lblGender);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.tbxEmail);
            this.gbxAdd.Controls.Add(this.btnAddUser);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxUsername);
            this.gbxAdd.Controls.Add(this.tbxFirstName);
            this.gbxAdd.Controls.Add(this.lblUsername);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Location = new System.Drawing.Point(5, 205);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(250, 350);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New User";
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(187, 174);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnFemale.TabIndex = 16;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(133, 174);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(48, 17);
            this.rbnMale.TabIndex = 15;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(133, 270);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(36, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(133, 133);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 10;
            // 
            // dgwUsers
            // 
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(0, 0);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(765, 200);
            this.dgwUsers.TabIndex = 11;
            this.dgwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwProducts_CellClick);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(515, 205);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(250, 100);
            this.gbxSearch.TabIndex = 32;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Username";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(73, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(156, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 600);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.tbxRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwUsers);
            this.Name = "AdminForm";
            this.Text = "Admin-User Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbxRemove;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.RadioButton rbnUpdateFemale;
        private System.Windows.Forms.RadioButton rbnUpdateMale;
        private System.Windows.Forms.TextBox tbxUpdatePassword;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdateGender;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.TextBox tbxUpdateEmail;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.TextBox tbxUpdateUserName;
        private System.Windows.Forms.TextBox tbxUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateUserName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.TextBox tbxUpdateLastName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

