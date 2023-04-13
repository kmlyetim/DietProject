namespace Calory
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lblDescription = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblPhone = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblGender = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblBirthDate = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblPassword = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblEmail = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblLastName = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblFirstName = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtFirstName = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtLastName = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new RJCodeAdvance.RJControls.RJDatePicker();
            this.rdbMale = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rdbFemale = new RJCodeAdvance.RJControls.RJRadioButton();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnPicture = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxBMI = new ReaLTaiizor.Controls.GroupBox();
            this.cmbActivite = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblActiveState = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblDescription2 = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtWeight = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtHeight = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblWeight = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblHeight = new ReaLTaiizor.Controls.HeaderLabel();
            this.pbxUserPicture = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rdbExpert = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rdbUser = new RJCodeAdvance.RJControls.RJRadioButton();
            this.lblUserStatus = new ReaLTaiizor.Controls.HeaderLabel();
            this.gbxUserStatus = new ReaLTaiizor.Controls.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxBMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPicture)).BeginInit();
            this.gbxUserStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(154, 382);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(289, 79);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "*Password size must be at least 8 characters and it must contain at least 2 upper" +
    "case letters, 2 lowercase letters and 2 special characters like (!,*,+,;).";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhone.Location = new System.Drawing.Point(58, 539);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 19);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone : ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.DimGray;
            this.lblGender.Location = new System.Drawing.Point(52, 500);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 19);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender : ";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblBirthDate.Location = new System.Drawing.Point(45, 461);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(72, 19);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Birthdate :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(33, 353);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(65, 303);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email : ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DimGray;
            this.lblLastName.Location = new System.Drawing.Point(34, 258);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 19);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name : ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.lblFirstName.Location = new System.Drawing.Point(33, 211);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 19);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderColor = System.Drawing.Color.DimGray;
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.Location = new System.Drawing.Point(144, 203);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.Size = new System.Drawing.Size(316, 36);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderColor = System.Drawing.Color.DimGray;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(144, 249);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(316, 36);
            this.txtLastName.TabIndex = 30;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Black;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(144, 295);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(316, 36);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(144, 341);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(316, 36);
            this.txtPassword.TabIndex = 32;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtPhone.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPhone.Location = new System.Drawing.Point(144, 537);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(316, 25);
            this.mtxtPhone.TabIndex = 33;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpBirthDate.BorderSize = 0;
            this.dtpBirthDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(144, 454);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(316, 35);
            this.dtpBirthDate.SkinColor = System.Drawing.Color.Gray;
            this.dtpBirthDate.TabIndex = 34;
            this.dtpBirthDate.TextColor = System.Drawing.Color.WhiteSmoke;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.CheckedColor = System.Drawing.Color.DimGray;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMale.Location = new System.Drawing.Point(144, 497);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMale.MinimumSize = new System.Drawing.Size(0, 25);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rdbMale.Size = new System.Drawing.Size(72, 25);
            this.rdbMale.TabIndex = 35;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.CheckedColor = System.Drawing.Color.DimGray;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbFemale.Location = new System.Drawing.Point(224, 497);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemale.MinimumSize = new System.Drawing.Size(0, 25);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rdbFemale.Size = new System.Drawing.Size(87, 25);
            this.rdbFemale.TabIndex = 36;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(157, 851);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 47);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Gray;
            this.btnPicture.BackgroundColor = System.Drawing.Color.Gray;
            this.btnPicture.BorderColor = System.Drawing.Color.Black;
            this.btnPicture.BorderRadius = 15;
            this.btnPicture.BorderSize = 0;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPicture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicture.Location = new System.Drawing.Point(190, 165);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(130, 29);
            this.btnPicture.TabIndex = 40;
            this.btnPicture.Text = "Choose Picture ...";
            this.btnPicture.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 864);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(450, 864);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 44;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxBMI
            // 
            this.gbxBMI.BackColor = System.Drawing.Color.Transparent;
            this.gbxBMI.BackGColor = System.Drawing.Color.DarkGray;
            this.gbxBMI.BaseColor = System.Drawing.Color.Transparent;
            this.gbxBMI.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxBMI.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxBMI.Controls.Add(this.cmbActivite);
            this.gbxBMI.Controls.Add(this.lblActiveState);
            this.gbxBMI.Controls.Add(this.lblDescription2);
            this.gbxBMI.Controls.Add(this.txtWeight);
            this.gbxBMI.Controls.Add(this.txtHeight);
            this.gbxBMI.Controls.Add(this.lblWeight);
            this.gbxBMI.Controls.Add(this.lblHeight);
            this.gbxBMI.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxBMI.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxBMI.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxBMI.Location = new System.Drawing.Point(37, 569);
            this.gbxBMI.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxBMI.Name = "gbxBMI";
            this.gbxBMI.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxBMI.Size = new System.Drawing.Size(440, 211);
            this.gbxBMI.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxBMI.TabIndex = 71;
            this.gbxBMI.Text = "BMI & Daily Calory Needed Calculation";
            // 
            // cmbActivite
            // 
            this.cmbActivite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbActivite.BorderColor = System.Drawing.Color.DimGray;
            this.cmbActivite.BorderSize = 2;
            this.cmbActivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbActivite.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbActivite.ForeColor = System.Drawing.Color.DimGray;
            this.cmbActivite.IconColor = System.Drawing.Color.DimGray;
            this.cmbActivite.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbActivite.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbActivite.Location = new System.Drawing.Point(112, 161);
            this.cmbActivite.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbActivite.Name = "cmbActivite";
            this.cmbActivite.Padding = new System.Windows.Forms.Padding(2);
            this.cmbActivite.Size = new System.Drawing.Size(266, 30);
            this.cmbActivite.TabIndex = 70;
            this.cmbActivite.Texts = "";
            // 
            // lblActiveState
            // 
            this.lblActiveState.AutoSize = true;
            this.lblActiveState.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveState.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActiveState.ForeColor = System.Drawing.Color.DimGray;
            this.lblActiveState.Location = new System.Drawing.Point(8, 164);
            this.lblActiveState.Name = "lblActiveState";
            this.lblActiveState.Size = new System.Drawing.Size(98, 19);
            this.lblActiveState.TabIndex = 69;
            this.lblActiveState.Text = "Activite State :";
            // 
            // lblDescription2
            // 
            this.lblDescription2.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription2.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription2.Location = new System.Drawing.Point(15, 24);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(396, 52);
            this.lblDescription2.TabIndex = 68;
            this.lblDescription2.Text = "*Please enter your height and weight information so that we can prepare a better " +
    "program for you.";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWeight.BorderColor = System.Drawing.Color.DimGray;
            this.txtWeight.BorderFocusColor = System.Drawing.Color.Black;
            this.txtWeight.BorderRadius = 15;
            this.txtWeight.BorderSize = 2;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeight.Location = new System.Drawing.Point(107, 120);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Multiline = false;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWeight.PasswordChar = false;
            this.txtWeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.Size = new System.Drawing.Size(271, 34);
            this.txtWeight.TabIndex = 67;
            this.txtWeight.Texts = "";
            this.txtWeight.UnderlinedStyle = false;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHeight.BorderColor = System.Drawing.Color.DimGray;
            this.txtHeight.BorderFocusColor = System.Drawing.Color.Black;
            this.txtHeight.BorderRadius = 15;
            this.txtHeight.BorderSize = 2;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeight.Location = new System.Drawing.Point(107, 78);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Multiline = false;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHeight.PasswordChar = false;
            this.txtHeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHeight.PlaceholderText = "";
            this.txtHeight.Size = new System.Drawing.Size(271, 34);
            this.txtHeight.TabIndex = 66;
            this.txtHeight.Texts = "";
            this.txtHeight.UnderlinedStyle = false;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.ForeColor = System.Drawing.Color.DimGray;
            this.lblWeight.Location = new System.Drawing.Point(8, 125);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(60, 19);
            this.lblWeight.TabIndex = 64;
            this.lblWeight.Text = "Weight :";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeight.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeight.Location = new System.Drawing.Point(6, 83);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 19);
            this.lblHeight.TabIndex = 65;
            this.lblHeight.Text = "Height :";
            // 
            // pbxUserPicture
            // 
            this.pbxUserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUserPicture.BackgroundImage")));
            this.pbxUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserPicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxUserPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.pbxUserPicture.BorderColor2 = System.Drawing.Color.DarkCyan;
            this.pbxUserPicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxUserPicture.BorderSize = 1;
            this.pbxUserPicture.GradientAngle = 50F;
            this.pbxUserPicture.Location = new System.Drawing.Point(180, 12);
            this.pbxUserPicture.Name = "pbxUserPicture";
            this.pbxUserPicture.Size = new System.Drawing.Size(146, 146);
            this.pbxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUserPicture.TabIndex = 72;
            this.pbxUserPicture.TabStop = false;
            // 
            // rdbExpert
            // 
            this.rdbExpert.AutoSize = true;
            this.rdbExpert.BackColor = System.Drawing.Color.DarkGray;
            this.rdbExpert.CheckedColor = System.Drawing.Color.DimGray;
            this.rdbExpert.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbExpert.Location = new System.Drawing.Point(232, 28);
            this.rdbExpert.Margin = new System.Windows.Forms.Padding(4);
            this.rdbExpert.MinimumSize = new System.Drawing.Size(0, 25);
            this.rdbExpert.Name = "rdbExpert";
            this.rdbExpert.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rdbExpert.Size = new System.Drawing.Size(82, 25);
            this.rdbExpert.TabIndex = 75;
            this.rdbExpert.TabStop = true;
            this.rdbExpert.Text = "Expert";
            this.rdbExpert.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbExpert.UseVisualStyleBackColor = false;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.BackColor = System.Drawing.Color.DarkGray;
            this.rdbUser.Checked = true;
            this.rdbUser.CheckedColor = System.Drawing.Color.DimGray;
            this.rdbUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbUser.Location = new System.Drawing.Point(119, 28);
            this.rdbUser.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUser.MinimumSize = new System.Drawing.Size(0, 25);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rdbUser.Size = new System.Drawing.Size(69, 25);
            this.rdbUser.TabIndex = 74;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "User";
            this.rdbUser.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbUser.UseVisualStyleBackColor = false;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUserStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserStatus.Location = new System.Drawing.Point(3, 31);
            this.lblUserStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(87, 19);
            this.lblUserStatus.TabIndex = 73;
            this.lblUserStatus.Text = "User Status :";
            // 
            // gbxUserStatus
            // 
            this.gbxUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbxUserStatus.BackGColor = System.Drawing.Color.DarkGray;
            this.gbxUserStatus.BaseColor = System.Drawing.Color.Transparent;
            this.gbxUserStatus.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxUserStatus.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxUserStatus.Controls.Add(this.rdbUser);
            this.gbxUserStatus.Controls.Add(this.rdbExpert);
            this.gbxUserStatus.Controls.Add(this.lblUserStatus);
            this.gbxUserStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUserStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxUserStatus.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxUserStatus.Location = new System.Drawing.Point(38, 782);
            this.gbxUserStatus.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxUserStatus.Name = "gbxUserStatus";
            this.gbxUserStatus.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxUserStatus.Size = new System.Drawing.Size(438, 62);
            this.gbxUserStatus.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxUserStatus.TabIndex = 72;
            this.gbxUserStatus.Text = "User Status Selection";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(488, 902);
            this.Controls.Add(this.gbxUserStatus);
            this.Controls.Add(this.pbxUserPicture);
            this.Controls.Add(this.gbxBMI);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxBMI.ResumeLayout(false);
            this.gbxBMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPicture)).EndInit();
            this.gbxUserStatus.ResumeLayout(false);
            this.gbxUserStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.HeaderLabel lblDescription;
        private ReaLTaiizor.Controls.HeaderLabel lblPhone;
        private ReaLTaiizor.Controls.HeaderLabel lblGender;
        private ReaLTaiizor.Controls.HeaderLabel lblBirthDate;
        private ReaLTaiizor.Controls.HeaderLabel lblPassword;
        private ReaLTaiizor.Controls.HeaderLabel lblEmail;
        private ReaLTaiizor.Controls.HeaderLabel lblLastName;
        private ReaLTaiizor.Controls.HeaderLabel lblFirstName;
        private RJCodeAdvance.RJControls.RJTextBox txtFirstName;
        private RJCodeAdvance.RJControls.RJTextBox txtLastName;
        private RJCodeAdvance.RJControls.RJTextBox txtEmail;
        private RJCodeAdvance.RJControls.RJTextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private RJCodeAdvance.RJControls.RJDatePicker dtpBirthDate;
        private RJCodeAdvance.RJControls.RJRadioButton rdbMale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbFemale;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private ReaLTaiizor.Controls.GroupBox gbxBMI;
        private RJCodeAdvance.RJControls.RJComboBox cmbActivite;
        private ReaLTaiizor.Controls.HeaderLabel lblActiveState;
        private ReaLTaiizor.Controls.HeaderLabel lblDescription2;
        private RJCodeAdvance.RJControls.RJTextBox txtWeight;
        private RJCodeAdvance.RJControls.RJTextBox txtHeight;
        private ReaLTaiizor.Controls.HeaderLabel lblWeight;
        private ReaLTaiizor.Controls.HeaderLabel lblHeight;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxUserPicture;
        private RJCodeAdvance.RJControls.RJRadioButton rdbExpert;
        private RJCodeAdvance.RJControls.RJRadioButton rdbUser;
        private ReaLTaiizor.Controls.HeaderLabel lblUserStatus;
        private ReaLTaiizor.Controls.GroupBox gbxUserStatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}