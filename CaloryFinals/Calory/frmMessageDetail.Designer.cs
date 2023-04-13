namespace Calory
{
    partial class frmMessageDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageDetail));
            this.txtToOrFrom = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblToOrFrom = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtSubject = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblSubject = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnReply = new RJCodeAdvance.RJControls.RJButton();
            this.txtMessage = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToOrFrom
            // 
            this.txtToOrFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtToOrFrom.BorderColor = System.Drawing.Color.DimGray;
            this.txtToOrFrom.BorderFocusColor = System.Drawing.Color.Black;
            this.txtToOrFrom.BorderRadius = 15;
            this.txtToOrFrom.BorderSize = 2;
            this.txtToOrFrom.Enabled = false;
            this.txtToOrFrom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToOrFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtToOrFrom.Location = new System.Drawing.Point(84, 13);
            this.txtToOrFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtToOrFrom.Multiline = false;
            this.txtToOrFrom.Name = "txtToOrFrom";
            this.txtToOrFrom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtToOrFrom.PasswordChar = false;
            this.txtToOrFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtToOrFrom.PlaceholderText = "";
            this.txtToOrFrom.Size = new System.Drawing.Size(349, 34);
            this.txtToOrFrom.TabIndex = 67;
            this.txtToOrFrom.Texts = "";
            this.txtToOrFrom.UnderlinedStyle = false;
            // 
            // lblToOrFrom
            // 
            this.lblToOrFrom.AutoSize = true;
            this.lblToOrFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblToOrFrom.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToOrFrom.ForeColor = System.Drawing.Color.DimGray;
            this.lblToOrFrom.Location = new System.Drawing.Point(42, 20);
            this.lblToOrFrom.Name = "lblToOrFrom";
            this.lblToOrFrom.Size = new System.Drawing.Size(35, 19);
            this.lblToOrFrom.TabIndex = 66;
            this.lblToOrFrom.Text = "To :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderColor = System.Drawing.Color.DimGray;
            this.txtSubject.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSubject.BorderRadius = 15;
            this.txtSubject.BorderSize = 2;
            this.txtSubject.Enabled = false;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubject.Location = new System.Drawing.Point(84, 63);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubject.PasswordChar = false;
            this.txtSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubject.PlaceholderText = "";
            this.txtSubject.Size = new System.Drawing.Size(349, 34);
            this.txtSubject.TabIndex = 69;
            this.txtSubject.Texts = "";
            this.txtSubject.UnderlinedStyle = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubject.Location = new System.Drawing.Point(9, 71);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 68;
            this.lblSubject.Text = "Subject :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(13, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 40);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete Message";
            this.btnDelete.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.DarkGray;
            this.btnReply.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnReply.BorderColor = System.Drawing.Color.DimGray;
            this.btnReply.BorderRadius = 10;
            this.btnReply.BorderSize = 1;
            this.btnReply.FlatAppearance.BorderSize = 0;
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReply.Location = new System.Drawing.Point(302, 300);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(131, 40);
            this.btnReply.TabIndex = 72;
            this.btnReply.Text = "Reply";
            this.btnReply.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            this.btnReply.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnReply.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.BorderColor = System.Drawing.Color.DimGray;
            this.txtMessage.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMessage.BorderRadius = 15;
            this.txtMessage.BorderSize = 2;
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMessage.Location = new System.Drawing.Point(13, 118);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMessage.PasswordChar = false;
            this.txtMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMessage.PlaceholderText = "";
            this.txtMessage.Size = new System.Drawing.Size(420, 175);
            this.txtMessage.TabIndex = 73;
            this.txtMessage.Texts = "";
            this.txtMessage.UnderlinedStyle = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(412, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 75;
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
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // frmMessageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtToOrFrom);
            this.Controls.Add(this.lblToOrFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageDetail";
            this.Load += new System.EventHandler(this.frmMessageDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox txtToOrFrom;
        private ReaLTaiizor.Controls.HeaderLabel lblToOrFrom;
        private RJCodeAdvance.RJControls.RJTextBox txtSubject;
        private ReaLTaiizor.Controls.HeaderLabel lblSubject;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnReply;
        private RJCodeAdvance.RJControls.RJTextBox txtMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}