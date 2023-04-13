namespace Calory
{
    partial class frmSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSend));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTo = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblSubject = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblFrom = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtSubject = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtFrom = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSend = new RJCodeAdvance.RJControls.RJButton();
            this.txtMessage = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbToOrFrom = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(420, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 60;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTo.Location = new System.Drawing.Point(49, 25);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 19);
            this.lblTo.TabIndex = 62;
            this.lblTo.Text = "To :";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubject.Location = new System.Drawing.Point(16, 125);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 63;
            this.lblSubject.Text = "Subject :";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.DimGray;
            this.lblFrom.Location = new System.Drawing.Point(30, 75);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 19);
            this.lblFrom.TabIndex = 64;
            this.lblFrom.Text = "From :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderColor = System.Drawing.Color.DimGray;
            this.txtSubject.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSubject.BorderRadius = 15;
            this.txtSubject.BorderSize = 2;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubject.Location = new System.Drawing.Point(91, 119);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubject.PasswordChar = false;
            this.txtSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubject.PlaceholderText = "";
            this.txtSubject.Size = new System.Drawing.Size(349, 34);
            this.txtSubject.TabIndex = 66;
            this.txtSubject.Texts = "";
            this.txtSubject.UnderlinedStyle = false;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFrom.BorderColor = System.Drawing.Color.DimGray;
            this.txtFrom.BorderFocusColor = System.Drawing.Color.Black;
            this.txtFrom.BorderRadius = 15;
            this.txtFrom.BorderSize = 2;
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrom.Location = new System.Drawing.Point(91, 68);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.Size = new System.Drawing.Size(349, 34);
            this.txtFrom.TabIndex = 67;
            this.txtFrom.Texts = "";
            this.txtFrom.UnderlinedStyle = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkGray;
            this.btnSend.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnSend.BorderColor = System.Drawing.Color.DimGray;
            this.btnSend.BorderRadius = 10;
            this.btnSend.BorderSize = 1;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(282, 343);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(158, 40);
            this.btnSend.TabIndex = 69;
            this.btnSend.Text = "Send";
            this.btnSend.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseEnter += new System.EventHandler(this.btnSend_MouseEnter);
            this.btnSend.MouseLeave += new System.EventHandler(this.btnSend_MouseLeave);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.BorderColor = System.Drawing.Color.DimGray;
            this.txtMessage.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMessage.BorderRadius = 15;
            this.txtMessage.BorderSize = 2;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMessage.Location = new System.Drawing.Point(20, 161);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMessage.PasswordChar = false;
            this.txtMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMessage.PlaceholderText = "";
            this.txtMessage.Size = new System.Drawing.Size(420, 175);
            this.txtMessage.TabIndex = 74;
            this.txtMessage.Texts = "";
            this.txtMessage.UnderlinedStyle = false;
            // 
            // cmbToOrFrom
            // 
            this.cmbToOrFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbToOrFrom.BorderColor = System.Drawing.Color.DimGray;
            this.cmbToOrFrom.BorderSize = 2;
            this.cmbToOrFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbToOrFrom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbToOrFrom.ForeColor = System.Drawing.Color.DimGray;
            this.cmbToOrFrom.IconColor = System.Drawing.Color.DimGray;
            this.cmbToOrFrom.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbToOrFrom.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbToOrFrom.Location = new System.Drawing.Point(94, 20);
            this.cmbToOrFrom.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbToOrFrom.Name = "cmbToOrFrom";
            this.cmbToOrFrom.Padding = new System.Windows.Forms.Padding(2);
            this.cmbToOrFrom.Size = new System.Drawing.Size(340, 30);
            this.cmbToOrFrom.TabIndex = 75;
            this.cmbToOrFrom.Texts = "";
            // 
            // frmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.cmbToOrFrom);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSend";
            this.Load += new System.EventHandler(this.frmSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HeaderLabel lblTo;
        private ReaLTaiizor.Controls.HeaderLabel lblSubject;
        private ReaLTaiizor.Controls.HeaderLabel lblFrom;
        private RJCodeAdvance.RJControls.RJTextBox txtSubject;
        private RJCodeAdvance.RJControls.RJTextBox txtFrom;
        private RJCodeAdvance.RJControls.RJButton btnSend;
        private RJCodeAdvance.RJControls.RJTextBox txtMessage;
        private RJCodeAdvance.RJControls.RJComboBox cmbToOrFrom;
    }
}