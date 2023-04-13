namespace Calory
{
    partial class frmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.btnPicture = new RJCodeAdvance.RJControls.RJButton();
            this.txtPicture = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblPicture = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblPortionType = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblFoodCategory = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblName = new ReaLTaiizor.Controls.HeaderLabel();
            this.cmbCategory = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbPortion = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtCalory = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblCalory = new ReaLTaiizor.Controls.HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFat = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblFat = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtProtein = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblProtein = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtCarbonhydrate = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblCarbonhydrate = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblDescription = new ReaLTaiizor.Controls.HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Gray;
            this.btnPicture.BackgroundColor = System.Drawing.Color.Gray;
            this.btnPicture.BorderColor = System.Drawing.Color.DimGray;
            this.btnPicture.BorderRadius = 15;
            this.btnPicture.BorderSize = 1;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPicture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicture.Location = new System.Drawing.Point(332, 299);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(41, 31);
            this.btnPicture.TabIndex = 60;
            this.btnPicture.Text = "...";
            this.btnPicture.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            this.btnPicture.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnPicture.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtPicture
            // 
            this.txtPicture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPicture.BorderColor = System.Drawing.Color.DimGray;
            this.txtPicture.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPicture.BorderRadius = 15;
            this.txtPicture.BorderSize = 2;
            this.txtPicture.Enabled = false;
            this.txtPicture.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPicture.Location = new System.Drawing.Point(129, 299);
            this.txtPicture.Margin = new System.Windows.Forms.Padding(4);
            this.txtPicture.Multiline = false;
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPicture.PasswordChar = false;
            this.txtPicture.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPicture.PlaceholderText = "";
            this.txtPicture.Size = new System.Drawing.Size(197, 34);
            this.txtPicture.TabIndex = 59;
            this.txtPicture.Texts = "";
            this.txtPicture.UnderlinedStyle = false;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.BackColor = System.Drawing.Color.Transparent;
            this.lblPicture.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPicture.ForeColor = System.Drawing.Color.DimGray;
            this.lblPicture.Location = new System.Drawing.Point(59, 307);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(59, 19);
            this.lblPicture.TabIndex = 58;
            this.lblPicture.Text = "Picture :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(115, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 38);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderColor = System.Drawing.Color.DimGray;
            this.txtName.BorderFocusColor = System.Drawing.Color.Black;
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(130, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(248, 34);
            this.txtName.TabIndex = 49;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lblPortionType
            // 
            this.lblPortionType.AutoSize = true;
            this.lblPortionType.BackColor = System.Drawing.Color.Transparent;
            this.lblPortionType.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortionType.ForeColor = System.Drawing.Color.DimGray;
            this.lblPortionType.Location = new System.Drawing.Point(26, 99);
            this.lblPortionType.Name = "lblPortionType";
            this.lblPortionType.Size = new System.Drawing.Size(94, 19);
            this.lblPortionType.TabIndex = 43;
            this.lblPortionType.Text = "Portion Type :";
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodCategory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoodCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblFoodCategory.Location = new System.Drawing.Point(14, 63);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(107, 19);
            this.lblFoodCategory.TabIndex = 41;
            this.lblFoodCategory.Text = "Food Category :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(33, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 19);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Food Name :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.BorderColor = System.Drawing.Color.DimGray;
            this.cmbCategory.BorderSize = 2;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.IconColor = System.Drawing.Color.DimGray;
            this.cmbCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCategory.Location = new System.Drawing.Point(130, 58);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Size = new System.Drawing.Size(248, 30);
            this.cmbCategory.TabIndex = 61;
            this.cmbCategory.Texts = "";
            // 
            // cmbPortion
            // 
            this.cmbPortion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPortion.BorderColor = System.Drawing.Color.DimGray;
            this.cmbPortion.BorderSize = 2;
            this.cmbPortion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPortion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPortion.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPortion.IconColor = System.Drawing.Color.DimGray;
            this.cmbPortion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPortion.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPortion.Location = new System.Drawing.Point(130, 94);
            this.cmbPortion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPortion.Name = "cmbPortion";
            this.cmbPortion.Padding = new System.Windows.Forms.Padding(2);
            this.cmbPortion.Size = new System.Drawing.Size(248, 30);
            this.cmbPortion.TabIndex = 63;
            this.cmbPortion.Texts = "";
            // 
            // txtCalory
            // 
            this.txtCalory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCalory.BorderColor = System.Drawing.Color.DimGray;
            this.txtCalory.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCalory.BorderRadius = 15;
            this.txtCalory.BorderSize = 2;
            this.txtCalory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCalory.Location = new System.Drawing.Point(129, 257);
            this.txtCalory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalory.Multiline = false;
            this.txtCalory.Name = "txtCalory";
            this.txtCalory.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalory.PasswordChar = false;
            this.txtCalory.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalory.PlaceholderText = "";
            this.txtCalory.Size = new System.Drawing.Size(251, 34);
            this.txtCalory.TabIndex = 65;
            this.txtCalory.Texts = "";
            this.txtCalory.UnderlinedStyle = false;
            // 
            // lblCalory
            // 
            this.lblCalory.AutoSize = true;
            this.lblCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblCalory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCalory.Location = new System.Drawing.Point(66, 265);
            this.lblCalory.Name = "lblCalory";
            this.lblCalory.Size = new System.Drawing.Size(55, 19);
            this.lblCalory.TabIndex = 64;
            this.lblCalory.Text = "Calory :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(356, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 67;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFat
            // 
            this.txtFat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFat.BorderColor = System.Drawing.Color.DimGray;
            this.txtFat.BorderFocusColor = System.Drawing.Color.Black;
            this.txtFat.BorderRadius = 15;
            this.txtFat.BorderSize = 2;
            this.txtFat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFat.Location = new System.Drawing.Point(130, 215);
            this.txtFat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFat.Multiline = false;
            this.txtFat.Name = "txtFat";
            this.txtFat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFat.PasswordChar = false;
            this.txtFat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFat.PlaceholderText = "";
            this.txtFat.Size = new System.Drawing.Size(248, 34);
            this.txtFat.TabIndex = 69;
            this.txtFat.Texts = "";
            this.txtFat.UnderlinedStyle = false;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.BackColor = System.Drawing.Color.Transparent;
            this.lblFat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFat.ForeColor = System.Drawing.Color.DimGray;
            this.lblFat.Location = new System.Drawing.Point(85, 219);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(35, 19);
            this.lblFat.TabIndex = 68;
            this.lblFat.Text = "Fat :";
            // 
            // txtProtein
            // 
            this.txtProtein.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProtein.BorderColor = System.Drawing.Color.DimGray;
            this.txtProtein.BorderFocusColor = System.Drawing.Color.Black;
            this.txtProtein.BorderRadius = 15;
            this.txtProtein.BorderSize = 2;
            this.txtProtein.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProtein.Location = new System.Drawing.Point(130, 173);
            this.txtProtein.Margin = new System.Windows.Forms.Padding(4);
            this.txtProtein.Multiline = false;
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProtein.PasswordChar = false;
            this.txtProtein.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProtein.PlaceholderText = "";
            this.txtProtein.Size = new System.Drawing.Size(248, 34);
            this.txtProtein.TabIndex = 71;
            this.txtProtein.Texts = "";
            this.txtProtein.UnderlinedStyle = false;
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtein.ForeColor = System.Drawing.Color.DimGray;
            this.lblProtein.Location = new System.Drawing.Point(60, 181);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(60, 19);
            this.lblProtein.TabIndex = 70;
            this.lblProtein.Text = "Protein :";
            // 
            // txtCarbonhydrate
            // 
            this.txtCarbonhydrate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCarbonhydrate.BorderColor = System.Drawing.Color.DimGray;
            this.txtCarbonhydrate.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCarbonhydrate.BorderRadius = 15;
            this.txtCarbonhydrate.BorderSize = 2;
            this.txtCarbonhydrate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCarbonhydrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCarbonhydrate.Location = new System.Drawing.Point(130, 131);
            this.txtCarbonhydrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarbonhydrate.Multiline = false;
            this.txtCarbonhydrate.Name = "txtCarbonhydrate";
            this.txtCarbonhydrate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCarbonhydrate.PasswordChar = false;
            this.txtCarbonhydrate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCarbonhydrate.PlaceholderText = "";
            this.txtCarbonhydrate.Size = new System.Drawing.Size(248, 34);
            this.txtCarbonhydrate.TabIndex = 73;
            this.txtCarbonhydrate.Texts = "";
            this.txtCarbonhydrate.UnderlinedStyle = false;
            // 
            // lblCarbonhydrate
            // 
            this.lblCarbonhydrate.AutoSize = true;
            this.lblCarbonhydrate.BackColor = System.Drawing.Color.Transparent;
            this.lblCarbonhydrate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarbonhydrate.ForeColor = System.Drawing.Color.DimGray;
            this.lblCarbonhydrate.Location = new System.Drawing.Point(20, 138);
            this.lblCarbonhydrate.Name = "lblCarbonhydrate";
            this.lblCarbonhydrate.Size = new System.Drawing.Size(100, 19);
            this.lblCarbonhydrate.TabIndex = 72;
            this.lblCarbonhydrate.Text = "Carbohydrate :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(129, 341);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(249, 34);
            this.txtDescription.TabIndex = 75;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(32, 349);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 74;
            this.lblDescription.Text = "Description :";
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(395, 466);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCarbonhydrate);
            this.Controls.Add(this.lblCarbonhydrate);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCalory);
            this.Controls.Add(this.lblCalory);
            this.Controls.Add(this.cmbPortion);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPortionType);
            this.Controls.Add(this.lblFoodCategory);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddFood";
            this.Load += new System.EventHandler(this.frmAddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnPicture;
        private RJCodeAdvance.RJControls.RJTextBox txtPicture;
        private ReaLTaiizor.Controls.HeaderLabel lblPicture;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private ReaLTaiizor.Controls.HeaderLabel lblPortionType;
        private ReaLTaiizor.Controls.HeaderLabel lblFoodCategory;
        private ReaLTaiizor.Controls.HeaderLabel lblName;
        private RJCodeAdvance.RJControls.RJComboBox cmbCategory;
        private RJCodeAdvance.RJControls.RJComboBox cmbPortion;
        private RJCodeAdvance.RJControls.RJTextBox txtCalory;
        private ReaLTaiizor.Controls.HeaderLabel lblCalory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private RJCodeAdvance.RJControls.RJTextBox txtFat;
        private ReaLTaiizor.Controls.HeaderLabel lblFat;
        private RJCodeAdvance.RJControls.RJTextBox txtProtein;
        private ReaLTaiizor.Controls.HeaderLabel lblProtein;
        private RJCodeAdvance.RJControls.RJTextBox txtCarbonhydrate;
        private ReaLTaiizor.Controls.HeaderLabel lblCarbonhydrate;
        private RJCodeAdvance.RJControls.RJTextBox txtDescription;
        private ReaLTaiizor.Controls.HeaderLabel lblDescription;
    }
}