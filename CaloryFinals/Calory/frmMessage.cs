using Fake.Business.Services;
using Fake.DAL.Entities;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Fake.DAL.Entities.Message;

namespace Calory
{
    public partial class frmMessage : Form
    {
        User _user;
        MessageService messageService;
        string typeControl;
       
        public frmMessage()
        {
            InitializeComponent();
            messageService = new MessageService();
        }
        public frmMessage(User user,string type)
        {
            InitializeComponent();
            _user = user;
            typeControl = type;
            messageService = new MessageService();
        }
        private void frmMessage_Load(object sender, EventArgs e)
        {
            if (typeControl == "Sent")
            {
                FillSent();
            }
            else
            {
                FillInbox();
            }
        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            Message message = (Message)btn.Tag;
            if (_user.UserStatus==Fake.DAL.Enums.UserStatus.User)
            {
                message.MessageStatusForUser = Fake.DAL.Enums.MessageStatus.Read;
            }
            else
            {
                message.MessageStatusForExpert = Fake.DAL.Enums.MessageStatus.Read;
            }
            messageService.UpdateMessage(message);
            frmMessageDetail frmMessageDetail = new frmMessageDetail(message, "Inbox", _user);
            this.Hide();
            DialogResult dr = frmMessageDetail.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillInbox();
            }
        }
        private void Btn_Click(object sender, EventArgs e) 
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            Message message = (Message)btn.Tag;
            frmMessageDetail frmMessageDetail = new frmMessageDetail(message,"Sent",_user);
            this.Hide();
            DialogResult dr = frmMessageDetail.ShowDialog();
            if (dr==DialogResult.OK)
            {
                this.Show();
                FillSent();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }
        public void FillSent()
        {
            flpMessages.Controls.Clear();
            List<Message> list = messageService.GetMessageBySenderId(_user.Id);
            foreach (var item in list)
            {
                RJCodeAdvance.RJControls.RJButton btn = new RJCodeAdvance.RJControls.RJButton();
                ButtonProperties(btn);
                btn.Text = $"{item.Receiver.FirstName.ToUpper()} {item.Receiver.LastName.ToUpper()}\nSubject : {item.Subject}\n{item.MessageDetail}";
                btn.Tag = item;
                flpMessages.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.MouseEnter += Btn_MouseEnter;
                btn.MouseLeave += Btn_MouseLeave;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.Black;
        }

        public void FillInbox()
        {
            flpMessages.Controls.Clear();
            List<Message> list = messageService.GetMessageByRecieverId(_user.Id);
            foreach (var item in list)
            {
                RJCodeAdvance.RJControls.RJButton btn = new RJCodeAdvance.RJControls.RJButton();
                ButtonProperties(btn);
                if (item.MessageStatusForExpert == Fake.DAL.Enums.MessageStatus.Unread || item.MessageStatusForUser == Fake.DAL.Enums.MessageStatus.Unread)
                {
                    btn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Text = $"{item.Sender.FirstName.ToUpper()} {item.Sender.LastName.ToUpper()} ( UNREAD )\nSubject : {item.Subject}\n{item.MessageDetail}";
                }
                else
                {
                    btn.Text = $"{item.Sender.FirstName.ToUpper()} {item.Sender.LastName.ToUpper()}\nSubject : {item.Subject}\n{item.MessageDetail}";
                }
                btn.Tag = item;
                flpMessages.Controls.Add(btn);
                btn.Click += Btn_Click1;
                btn.MouseEnter += Btn_MouseEnter1;
                btn.MouseLeave += Btn_MouseLeave1;
            }
        }

        private void Btn_MouseLeave1(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
        }

        private void Btn_MouseEnter1(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.Black;
        }

        public void ButtonProperties(RJCodeAdvance.RJControls.RJButton button)
        {
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            button.BorderColor = System.Drawing.Color.Black;
            button.BorderRadius = 20;
            button.BorderSize = 0;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(3, 3);
            button.Size = new System.Drawing.Size(750, 105);
            button.TabIndex = 14;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.TextColor = System.Drawing.Color.White;
            button.UseVisualStyleBackColor = false;
        }
    }
}
