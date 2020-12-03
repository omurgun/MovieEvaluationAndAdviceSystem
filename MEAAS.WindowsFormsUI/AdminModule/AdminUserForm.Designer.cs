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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Firstname ";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(180, 222);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(204, 30);
            this.tbxUsername.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(180, 39);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(204, 30);
            this.tbxFirstName.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 222);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 28);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(36, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(118, 28);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Lastname";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(180, 87);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(204, 30);
            this.tbxLastName.TabIndex = 4;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxUpdate.Controls.Add(this.btnUpdateUser);
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
            this.gbxUpdate.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(408, 271);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(390, 408);
            this.gbxUpdate.TabIndex = 13;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update User";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateUser.FlatAppearance.BorderSize = 3;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(69, 324);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(258, 75);
            this.btnUpdateUser.TabIndex = 42;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // rbnUpdateFemale
            // 
            this.rbnUpdateFemale.AutoSize = true;
            this.rbnUpdateFemale.Location = new System.Drawing.Point(247, 171);
            this.rbnUpdateFemale.Name = "rbnUpdateFemale";
            this.rbnUpdateFemale.Size = new System.Drawing.Size(108, 32);
            this.rbnUpdateFemale.TabIndex = 29;
            this.rbnUpdateFemale.TabStop = true;
            this.rbnUpdateFemale.Text = "Female";
            this.rbnUpdateFemale.UseVisualStyleBackColor = true;
            // 
            // rbnUpdateMale
            // 
            this.rbnUpdateMale.AutoSize = true;
            this.rbnUpdateMale.Location = new System.Drawing.Point(162, 172);
            this.rbnUpdateMale.Name = "rbnUpdateMale";
            this.rbnUpdateMale.Size = new System.Drawing.Size(82, 32);
            this.rbnUpdateMale.TabIndex = 28;
            this.rbnUpdateMale.TabStop = true;
            this.rbnUpdateMale.Text = "Male";
            this.rbnUpdateMale.UseVisualStyleBackColor = true;
            // 
            // tbxUpdatePassword
            // 
            this.tbxUpdatePassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdatePassword.Location = new System.Drawing.Point(162, 267);
            this.tbxUpdatePassword.Name = "tbxUpdatePassword";
            this.tbxUpdatePassword.Size = new System.Drawing.Size(193, 30);
            this.tbxUpdatePassword.TabIndex = 27;
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Location = new System.Drawing.Point(23, 267);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(116, 28);
            this.lblUpdatePassword.TabIndex = 26;
            this.lblUpdatePassword.Text = "Password";
            // 
            // lblUpdateGender
            // 
            this.lblUpdateGender.AutoSize = true;
            this.lblUpdateGender.Location = new System.Drawing.Point(23, 171);
            this.lblUpdateGender.Name = "lblUpdateGender";
            this.lblUpdateGender.Size = new System.Drawing.Size(90, 28);
            this.lblUpdateGender.TabIndex = 25;
            this.lblUpdateGender.Text = "Gender";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(23, 133);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(73, 28);
            this.lblUpdateEmail.TabIndex = 23;
            this.lblUpdateEmail.Text = "Email";
            // 
            // tbxUpdateEmail
            // 
            this.tbxUpdateEmail.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateEmail.Location = new System.Drawing.Point(162, 130);
            this.tbxUpdateEmail.Name = "tbxUpdateEmail";
            this.tbxUpdateEmail.Size = new System.Drawing.Size(193, 30);
            this.tbxUpdateEmail.TabIndex = 24;
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(23, 39);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(128, 28);
            this.lblUpdateFirstName.TabIndex = 17;
            this.lblUpdateFirstName.Text = "Firstname ";
            // 
            // tbxUpdateUserName
            // 
            this.tbxUpdateUserName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateUserName.Location = new System.Drawing.Point(162, 219);
            this.tbxUpdateUserName.Name = "tbxUpdateUserName";
            this.tbxUpdateUserName.Size = new System.Drawing.Size(193, 30);
            this.tbxUpdateUserName.TabIndex = 22;
            // 
            // tbxUpdateFirstName
            // 
            this.tbxUpdateFirstName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateFirstName.Location = new System.Drawing.Point(162, 36);
            this.tbxUpdateFirstName.Name = "tbxUpdateFirstName";
            this.tbxUpdateFirstName.Size = new System.Drawing.Size(193, 30);
            this.tbxUpdateFirstName.TabIndex = 18;
            // 
            // lblUpdateUserName
            // 
            this.lblUpdateUserName.AutoSize = true;
            this.lblUpdateUserName.Location = new System.Drawing.Point(23, 219);
            this.lblUpdateUserName.Name = "lblUpdateUserName";
            this.lblUpdateUserName.Size = new System.Drawing.Size(123, 28);
            this.lblUpdateUserName.TabIndex = 21;
            this.lblUpdateUserName.Text = "Username";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(23, 87);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(118, 28);
            this.lblUpdateLastName.TabIndex = 19;
            this.lblUpdateLastName.Text = "Lastname";
            // 
            // tbxUpdateLastName
            // 
            this.tbxUpdateLastName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateLastName.Location = new System.Drawing.Point(162, 84);
            this.tbxUpdateLastName.Name = "tbxUpdateLastName";
            this.tbxUpdateLastName.Size = new System.Drawing.Size(193, 30);
            this.tbxUpdateLastName.TabIndex = 20;
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxAdd.Controls.Add(this.btnAddUser);
            this.gbxAdd.Controls.Add(this.rbnFemale);
            this.gbxAdd.Controls.Add(this.rbnMale);
            this.gbxAdd.Controls.Add(this.tbxPassword);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.lblGender);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.tbxEmail);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxUsername);
            this.gbxAdd.Controls.Add(this.tbxFirstName);
            this.gbxAdd.Controls.Add(this.lblUsername);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(12, 271);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(390, 408);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Lime;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.FlatAppearance.BorderSize = 3;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(76, 324);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(258, 75);
            this.btnAddUser.TabIndex = 43;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(279, 175);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(108, 32);
            this.rbnFemale.TabIndex = 16;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(180, 175);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(82, 32);
            this.rbnMale.TabIndex = 15;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(180, 270);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(204, 30);
            this.tbxPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(36, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 28);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.Location = new System.Drawing.Point(180, 133);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(204, 30);
            this.tbxEmail.TabIndex = 10;
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.Location = new System.Drawing.Point(812, 271);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(341, 100);
            this.gbxSearch.TabIndex = 32;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Username";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(136, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(199, 30);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
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
            this.BtnBack.TabIndex = 41;
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
            this.BtnExit.TabIndex = 40;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            this.dgwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwUsers.ColumnHeadersHeight = 30;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(204)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwUsers.EnableHeadersVisualStyles = false;
            this.dgwUsers.Location = new System.Drawing.Point(10, 52);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwUsers.Size = new System.Drawing.Size(1142, 213);
            this.dgwUsers.TabIndex = 42;
            this.dgwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsers_CellClick);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Red;
            this.btnRemoveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveUser.FlatAppearance.BorderSize = 3;
            this.btnRemoveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveUser.Location = new System.Drawing.Point(855, 378);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(258, 75);
            this.btnRemoveUser.TabIndex = 43;
            this.btnRemoveUser.Text = "Delete";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1165, 711);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.dgwUsers);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-User Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminUserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminUserForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminUserForm_MouseUp);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
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
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnRemoveUser;
    }
}

