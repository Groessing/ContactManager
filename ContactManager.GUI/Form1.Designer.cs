namespace ContactManager.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAllContacts = new System.Windows.Forms.ListBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.lblTitleList = new System.Windows.Forms.Label();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.tbxCompanyTelephoneNumber = new System.Windows.Forms.TextBox();
            this.tbxCompanyAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompanyBirthday = new System.Windows.Forms.Button();
            this.tbxCompanyFirstName = new System.Windows.Forms.TextBox();
            this.tbxCompanyLastName = new System.Windows.Forms.TextBox();
            this.tbxCompanyAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.btnCompanyChange = new System.Windows.Forms.Button();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.tabPrivate = new System.Windows.Forms.TabPage();
            this.tbxPrivateEmail = new System.Windows.Forms.TextBox();
            this.lblPrivateFirstEmail = new System.Windows.Forms.Label();
            this.btnPrivateBirthday = new System.Windows.Forms.Button();
            this.tbxPrivateLastName = new System.Windows.Forms.TextBox();
            this.tbxPrivateAge = new System.Windows.Forms.TextBox();
            this.lblPrivateLastName = new System.Windows.Forms.Label();
            this.lblPrivateAge = new System.Windows.Forms.Label();
            this.btnPrivateAdd = new System.Windows.Forms.Button();
            this.btnPrivateChange = new System.Windows.Forms.Button();
            this.btnPrivateDelete = new System.Windows.Forms.Button();
            this.tbxPrivateFirstName = new System.Windows.Forms.TextBox();
            this.lblPrivateFirstName = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnBirthday = new System.Windows.Forms.Button();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabContact = new System.Windows.Forms.TabControl();
            this.tabCompany.SuspendLayout();
            this.tabPrivate.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllContacts
            // 
            this.lstAllContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllContacts.FormattingEnabled = true;
            this.lstAllContacts.ItemHeight = 44;
            this.lstAllContacts.Location = new System.Drawing.Point(1024, 194);
            this.lstAllContacts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstAllContacts.Name = "lstAllContacts";
            this.lstAllContacts.Size = new System.Drawing.Size(482, 532);
            this.lstAllContacts.TabIndex = 9;
            this.lstAllContacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstAllContacts_MouseDoubleClick);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteList.Location = new System.Drawing.Point(1146, 767);
            this.btnDeleteList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(262, 63);
            this.btnDeleteList.TabIndex = 10;
            this.btnDeleteList.Text = "Delete List...";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.BtnDeleteList_Click);
            this.btnDeleteList.MouseEnter += new System.EventHandler(this.BtnDeleteList_MouseEnter);
            this.btnDeleteList.MouseLeave += new System.EventHandler(this.BtnDeleteList_MouseLeave);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(356, 17);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 63);
            this.lblWelcome.TabIndex = 11;
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProgram.Location = new System.Drawing.Point(36, 779);
            this.btnCloseProgram.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(342, 63);
            this.btnCloseProgram.TabIndex = 12;
            this.btnCloseProgram.Text = "Close Program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.BtnCloseProgram_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(36, 617);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 63);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(36, 692);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(186, 63);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // tbxFileName
            // 
            this.tbxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFileName.Location = new System.Drawing.Point(258, 669);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(240, 51);
            this.tbxFileName.TabIndex = 15;
            // 
            // lblTitleList
            // 
            this.lblTitleList.AutoSize = true;
            this.lblTitleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleList.Location = new System.Drawing.Point(1098, 121);
            this.lblTitleList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitleList.Name = "lblTitleList";
            this.lblTitleList.Size = new System.Drawing.Size(343, 44);
            this.lblTitleList.TabIndex = 18;
            this.lblTitleList.Text = "List Of All Contacts";
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.tbxCompanyTelephoneNumber);
            this.tabCompany.Controls.Add(this.tbxCompanyAdress);
            this.tabCompany.Controls.Add(this.label9);
            this.tabCompany.Controls.Add(this.label8);
            this.tabCompany.Controls.Add(this.label5);
            this.tabCompany.Controls.Add(this.btnCompanyBirthday);
            this.tabCompany.Controls.Add(this.tbxCompanyFirstName);
            this.tabCompany.Controls.Add(this.tbxCompanyLastName);
            this.tabCompany.Controls.Add(this.tbxCompanyAge);
            this.tabCompany.Controls.Add(this.label6);
            this.tabCompany.Controls.Add(this.label7);
            this.tabCompany.Controls.Add(this.btnCompanyAdd);
            this.tabCompany.Controls.Add(this.btnCompanyChange);
            this.tabCompany.Controls.Add(this.btnCompanyDelete);
            this.tabCompany.Location = new System.Drawing.Point(8, 39);
            this.tabCompany.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Size = new System.Drawing.Size(896, 490);
            this.tabCompany.TabIndex = 2;
            this.tabCompany.Text = "Company Contact";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // tbxCompanyTelephoneNumber
            // 
            this.tbxCompanyTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompanyTelephoneNumber.Location = new System.Drawing.Point(424, 323);
            this.tbxCompanyTelephoneNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompanyTelephoneNumber.Name = "tbxCompanyTelephoneNumber";
            this.tbxCompanyTelephoneNumber.Size = new System.Drawing.Size(240, 51);
            this.tbxCompanyTelephoneNumber.TabIndex = 30;
            // 
            // tbxCompanyAdress
            // 
            this.tbxCompanyAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompanyAdress.Location = new System.Drawing.Point(424, 250);
            this.tbxCompanyAdress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompanyAdress.Name = "tbxCompanyAdress";
            this.tbxCompanyAdress.Size = new System.Drawing.Size(240, 51);
            this.tbxCompanyAdress.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 44);
            this.label9.TabIndex = 28;
            this.label9.Text = "Telephone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 44);
            this.label8.TabIndex = 27;
            this.label8.Text = "Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "First name:";
            // 
            // btnCompanyBirthday
            // 
            this.btnCompanyBirthday.BackColor = System.Drawing.Color.Red;
            this.btnCompanyBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyBirthday.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompanyBirthday.Location = new System.Drawing.Point(680, 348);
            this.btnCompanyBirthday.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCompanyBirthday.Name = "btnCompanyBirthday";
            this.btnCompanyBirthday.Size = new System.Drawing.Size(186, 133);
            this.btnCompanyBirthday.TabIndex = 26;
            this.btnCompanyBirthday.Text = "Happy Birthday";
            this.btnCompanyBirthday.UseVisualStyleBackColor = false;
            this.btnCompanyBirthday.Click += new System.EventHandler(this.BtnCompanyBirthday_Click);
            // 
            // tbxCompanyFirstName
            // 
            this.tbxCompanyFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompanyFirstName.Location = new System.Drawing.Point(424, 52);
            this.tbxCompanyFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompanyFirstName.Name = "tbxCompanyFirstName";
            this.tbxCompanyFirstName.Size = new System.Drawing.Size(240, 51);
            this.tbxCompanyFirstName.TabIndex = 20;
            // 
            // tbxCompanyLastName
            // 
            this.tbxCompanyLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompanyLastName.Location = new System.Drawing.Point(424, 119);
            this.tbxCompanyLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompanyLastName.Name = "tbxCompanyLastName";
            this.tbxCompanyLastName.Size = new System.Drawing.Size(240, 51);
            this.tbxCompanyLastName.TabIndex = 21;
            // 
            // tbxCompanyAge
            // 
            this.tbxCompanyAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompanyAge.Location = new System.Drawing.Point(424, 185);
            this.tbxCompanyAge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompanyAge.Name = "tbxCompanyAge";
            this.tbxCompanyAge.Size = new System.Drawing.Size(240, 51);
            this.tbxCompanyAge.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 44);
            this.label6.TabIndex = 19;
            this.label6.Text = "Last name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 44);
            this.label7.TabIndex = 18;
            this.label7.Text = "Age:";
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyAdd.Location = new System.Drawing.Point(38, 390);
            this.btnCompanyAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(186, 63);
            this.btnCompanyAdd.TabIndex = 23;
            this.btnCompanyAdd.Text = "Add";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.BtnCompanyAdd_Click);
            // 
            // btnCompanyChange
            // 
            this.btnCompanyChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyChange.Location = new System.Drawing.Point(236, 390);
            this.btnCompanyChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCompanyChange.Name = "btnCompanyChange";
            this.btnCompanyChange.Size = new System.Drawing.Size(238, 63);
            this.btnCompanyChange.TabIndex = 24;
            this.btnCompanyChange.Text = "Change...";
            this.btnCompanyChange.UseVisualStyleBackColor = true;
            this.btnCompanyChange.Click += new System.EventHandler(this.BtnCompanyChange_Click);
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyDelete.Location = new System.Drawing.Point(482, 390);
            this.btnCompanyDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(186, 63);
            this.btnCompanyDelete.TabIndex = 25;
            this.btnCompanyDelete.Text = "Delete";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.BtnCompanyDelete_Click);
            this.btnCompanyDelete.MouseEnter += new System.EventHandler(this.BtnCompanyDelete_MouseEnter);
            this.btnCompanyDelete.MouseLeave += new System.EventHandler(this.BtnCompanyDelete_MouseLeave);
            // 
            // tabPrivate
            // 
            this.tabPrivate.Controls.Add(this.tbxPrivateEmail);
            this.tabPrivate.Controls.Add(this.lblPrivateFirstEmail);
            this.tabPrivate.Controls.Add(this.btnPrivateBirthday);
            this.tabPrivate.Controls.Add(this.tbxPrivateLastName);
            this.tabPrivate.Controls.Add(this.tbxPrivateAge);
            this.tabPrivate.Controls.Add(this.lblPrivateLastName);
            this.tabPrivate.Controls.Add(this.lblPrivateAge);
            this.tabPrivate.Controls.Add(this.btnPrivateAdd);
            this.tabPrivate.Controls.Add(this.btnPrivateChange);
            this.tabPrivate.Controls.Add(this.btnPrivateDelete);
            this.tabPrivate.Controls.Add(this.tbxPrivateFirstName);
            this.tabPrivate.Controls.Add(this.lblPrivateFirstName);
            this.tabPrivate.Location = new System.Drawing.Point(8, 39);
            this.tabPrivate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPrivate.Name = "tabPrivate";
            this.tabPrivate.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPrivate.Size = new System.Drawing.Size(896, 490);
            this.tabPrivate.TabIndex = 1;
            this.tabPrivate.Text = "Private Contact";
            this.tabPrivate.UseVisualStyleBackColor = true;
            // 
            // tbxPrivateEmail
            // 
            this.tbxPrivateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrivateEmail.Location = new System.Drawing.Point(230, 273);
            this.tbxPrivateEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPrivateEmail.Name = "tbxPrivateEmail";
            this.tbxPrivateEmail.Size = new System.Drawing.Size(240, 51);
            this.tbxPrivateEmail.TabIndex = 26;
            // 
            // lblPrivateFirstEmail
            // 
            this.lblPrivateFirstEmail.AutoSize = true;
            this.lblPrivateFirstEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateFirstEmail.Location = new System.Drawing.Point(16, 273);
            this.lblPrivateFirstEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrivateFirstEmail.Name = "lblPrivateFirstEmail";
            this.lblPrivateFirstEmail.Size = new System.Drawing.Size(139, 44);
            this.lblPrivateFirstEmail.TabIndex = 25;
            this.lblPrivateFirstEmail.Text = "E-Mail:";
            // 
            // btnPrivateBirthday
            // 
            this.btnPrivateBirthday.BackColor = System.Drawing.Color.Red;
            this.btnPrivateBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateBirthday.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrivateBirthday.Location = new System.Drawing.Point(662, 327);
            this.btnPrivateBirthday.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrivateBirthday.Name = "btnPrivateBirthday";
            this.btnPrivateBirthday.Size = new System.Drawing.Size(186, 133);
            this.btnPrivateBirthday.TabIndex = 24;
            this.btnPrivateBirthday.Text = "Happy Birthday";
            this.btnPrivateBirthday.UseVisualStyleBackColor = false;
            this.btnPrivateBirthday.Click += new System.EventHandler(this.BtnPrivateBirthday_Click);
            // 
            // tbxPrivateLastName
            // 
            this.tbxPrivateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrivateLastName.Location = new System.Drawing.Point(230, 125);
            this.tbxPrivateLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPrivateLastName.Name = "tbxPrivateLastName";
            this.tbxPrivateLastName.Size = new System.Drawing.Size(240, 51);
            this.tbxPrivateLastName.TabIndex = 19;
            // 
            // tbxPrivateAge
            // 
            this.tbxPrivateAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrivateAge.Location = new System.Drawing.Point(230, 202);
            this.tbxPrivateAge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPrivateAge.Name = "tbxPrivateAge";
            this.tbxPrivateAge.Size = new System.Drawing.Size(240, 51);
            this.tbxPrivateAge.TabIndex = 20;
            // 
            // lblPrivateLastName
            // 
            this.lblPrivateLastName.AutoSize = true;
            this.lblPrivateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateLastName.Location = new System.Drawing.Point(16, 125);
            this.lblPrivateLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrivateLastName.Name = "lblPrivateLastName";
            this.lblPrivateLastName.Size = new System.Drawing.Size(208, 44);
            this.lblPrivateLastName.TabIndex = 18;
            this.lblPrivateLastName.Text = "Last name:";
            // 
            // lblPrivateAge
            // 
            this.lblPrivateAge.AutoSize = true;
            this.lblPrivateAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateAge.Location = new System.Drawing.Point(16, 202);
            this.lblPrivateAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrivateAge.Name = "lblPrivateAge";
            this.lblPrivateAge.Size = new System.Drawing.Size(97, 44);
            this.lblPrivateAge.TabIndex = 17;
            this.lblPrivateAge.Text = "Age:";
            // 
            // btnPrivateAdd
            // 
            this.btnPrivateAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateAdd.Location = new System.Drawing.Point(12, 362);
            this.btnPrivateAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrivateAdd.Name = "btnPrivateAdd";
            this.btnPrivateAdd.Size = new System.Drawing.Size(186, 63);
            this.btnPrivateAdd.TabIndex = 21;
            this.btnPrivateAdd.Text = "Add";
            this.btnPrivateAdd.UseVisualStyleBackColor = true;
            this.btnPrivateAdd.Click += new System.EventHandler(this.BtnPrivateAdd_Click);
            // 
            // btnPrivateChange
            // 
            this.btnPrivateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateChange.Location = new System.Drawing.Point(214, 362);
            this.btnPrivateChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrivateChange.Name = "btnPrivateChange";
            this.btnPrivateChange.Size = new System.Drawing.Size(238, 63);
            this.btnPrivateChange.TabIndex = 22;
            this.btnPrivateChange.Text = "Change...";
            this.btnPrivateChange.UseVisualStyleBackColor = true;
            this.btnPrivateChange.Click += new System.EventHandler(this.BtnPrivateChange_Click);
            // 
            // btnPrivateDelete
            // 
            this.btnPrivateDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateDelete.Location = new System.Drawing.Point(464, 362);
            this.btnPrivateDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrivateDelete.Name = "btnPrivateDelete";
            this.btnPrivateDelete.Size = new System.Drawing.Size(186, 63);
            this.btnPrivateDelete.TabIndex = 23;
            this.btnPrivateDelete.Text = "Delete";
            this.btnPrivateDelete.UseVisualStyleBackColor = true;
            this.btnPrivateDelete.Click += new System.EventHandler(this.BtnPrivateDelete_Click);
            this.btnPrivateDelete.MouseEnter += new System.EventHandler(this.BtnPrivateDelete_MouseEnter);
            this.btnPrivateDelete.MouseLeave += new System.EventHandler(this.BtnPrivateDelete_MouseLeave);
            // 
            // tbxPrivateFirstName
            // 
            this.tbxPrivateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrivateFirstName.Location = new System.Drawing.Point(230, 52);
            this.tbxPrivateFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPrivateFirstName.Name = "tbxPrivateFirstName";
            this.tbxPrivateFirstName.Size = new System.Drawing.Size(240, 51);
            this.tbxPrivateFirstName.TabIndex = 4;
            // 
            // lblPrivateFirstName
            // 
            this.lblPrivateFirstName.AutoSize = true;
            this.lblPrivateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateFirstName.Location = new System.Drawing.Point(12, 52);
            this.lblPrivateFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrivateFirstName.Name = "lblPrivateFirstName";
            this.lblPrivateFirstName.Size = new System.Drawing.Size(211, 44);
            this.lblPrivateFirstName.TabIndex = 1;
            this.lblPrivateFirstName.Text = "First name:";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lblFirstname);
            this.tabGeneral.Controls.Add(this.btnBirthday);
            this.tabGeneral.Controls.Add(this.tbxFirstname);
            this.tabGeneral.Controls.Add(this.tbxLastname);
            this.tabGeneral.Controls.Add(this.tbxAge);
            this.tabGeneral.Controls.Add(this.lblLastname);
            this.tabGeneral.Controls.Add(this.lblAge);
            this.tabGeneral.Controls.Add(this.btnAdd);
            this.tabGeneral.Controls.Add(this.btnChange);
            this.tabGeneral.Controls.Add(this.btnDelete);
            this.tabGeneral.Location = new System.Drawing.Point(8, 39);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGeneral.Size = new System.Drawing.Size(896, 490);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(12, 79);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(211, 44);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First name:";
            // 
            // btnBirthday
            // 
            this.btnBirthday.BackColor = System.Drawing.Color.Red;
            this.btnBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirthday.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBirthday.Location = new System.Drawing.Point(662, 302);
            this.btnBirthday.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBirthday.Name = "btnBirthday";
            this.btnBirthday.Size = new System.Drawing.Size(186, 133);
            this.btnBirthday.TabIndex = 16;
            this.btnBirthday.Text = "Happy Birthday";
            this.btnBirthday.UseVisualStyleBackColor = false;
            this.btnBirthday.Click += new System.EventHandler(this.BtnBirthday_Click);
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstname.Location = new System.Drawing.Point(406, 79);
            this.tbxFirstname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(240, 51);
            this.tbxFirstname.TabIndex = 3;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastname.Location = new System.Drawing.Point(406, 146);
            this.tbxLastname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(240, 51);
            this.tbxLastname.TabIndex = 4;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.Location = new System.Drawing.Point(406, 212);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(240, 51);
            this.tbxAge.TabIndex = 5;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(16, 140);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(208, 44);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Last name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(16, 212);
            this.lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(97, 44);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 302);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 63);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(214, 302);
            this.btnChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(238, 63);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(464, 302);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.BtnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.BtnDelete_MouseLeave);
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.tabGeneral);
            this.tabContact.Controls.Add(this.tabPrivate);
            this.tabContact.Controls.Add(this.tabCompany);
            this.tabContact.Location = new System.Drawing.Point(36, 83);
            this.tabContact.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabContact.Name = "tabContact";
            this.tabContact.SelectedIndex = 0;
            this.tabContact.Size = new System.Drawing.Size(912, 537);
            this.tabContact.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tabContact);
            this.Controls.Add(this.lblTitleList);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.lstAllContacts);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCompany.ResumeLayout(false);
            this.tabCompany.PerformLayout();
            this.tabPrivate.ResumeLayout(false);
            this.tabPrivate.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstAllContacts;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCloseProgram;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Label lblTitleList;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.TabPage tabPrivate;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnBirthday;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabContact;
        private System.Windows.Forms.TextBox tbxPrivateEmail;
        private System.Windows.Forms.Label lblPrivateFirstEmail;
        private System.Windows.Forms.Button btnPrivateBirthday;
        private System.Windows.Forms.TextBox tbxPrivateLastName;
        private System.Windows.Forms.TextBox tbxPrivateAge;
        private System.Windows.Forms.Label lblPrivateLastName;
        private System.Windows.Forms.Label lblPrivateAge;
        private System.Windows.Forms.Button btnPrivateAdd;
        private System.Windows.Forms.Button btnPrivateChange;
        private System.Windows.Forms.Button btnPrivateDelete;
        private System.Windows.Forms.TextBox tbxPrivateFirstName;
        private System.Windows.Forms.Label lblPrivateFirstName;
        private System.Windows.Forms.TextBox tbxCompanyTelephoneNumber;
        private System.Windows.Forms.TextBox tbxCompanyAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompanyBirthday;
        private System.Windows.Forms.TextBox tbxCompanyFirstName;
        private System.Windows.Forms.TextBox tbxCompanyLastName;
        private System.Windows.Forms.TextBox tbxCompanyAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Button btnCompanyChange;
        private System.Windows.Forms.Button btnCompanyDelete;
    }
}

