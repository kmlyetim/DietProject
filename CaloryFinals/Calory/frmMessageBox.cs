using Fake.Business.Services;
using Fake.DAL.Entities;
using Fake.DAL.Enums;
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
    public partial class frmMessageBox : Form
    {
        User _user;
        MessageService messageService;
        public frmMessageBox()
        {
            InitializeComponent();
            messageService = new MessageService();
        }
        public frmMessageBox(User user)
        {
            InitializeComponent();
            _user = user;
            messageService = new MessageService();
        }
        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            FillLabels();
            FillNotification();
        }
        private void btnInbox_Click(object sender, EventArgs e)
        {
            frmMessage frmMessage = new frmMessage(_user, "Inbox");
            this.Hide();
            DialogResult dr = frmMessage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillLabels();
                FillNotification();
            }
        }
        private void btnSent_Click(object sender, EventArgs e)
        {
            frmMessage frmMessage = new frmMessage(_user, "Sent");
            this.Hide();
            DialogResult dr = frmMessage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillLabels();
                FillNotification();
            }
        }
        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            frmSend frmSend = new frmSend(_user);
            this.Hide();
            DialogResult dr = frmSend.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillLabels();
                FillNotification();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }
        public void FillLabels()
        {
            List<Message> inboxlist = messageService.GetMessageByRecieverId(_user.Id);
            lblInbox.Text = inboxlist.Count.ToString();
            List<Message> sentlist = messageService.GetMessageBySenderId(_user.Id);
            lblSent.Text = sentlist.Count.ToString();
        }
        public void FillNotification()
        {
            messageService = new MessageService();
            int counter = 0;
            var list = messageService.GetMessageByRecieverId(_user.Id);
            foreach (var item in list)
            {
                if (item.MessageStatusForUser == Fake.DAL.Enums.MessageStatus.Unread || item.MessageStatusForExpert == Fake.DAL.Enums.MessageStatus.Unread)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                btnNotification.Visible = false;
            }
            else
            {
                btnNotification.Text = counter.ToString();
            }
        }

        private void btnInbox_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnInbox_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
        }
    }
}
