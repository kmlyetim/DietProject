using Fake.Business.Services;
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
    public partial class frmSend : Form
    {
        User _user;
        Message userMessage;
        UserService userService;
        MessageService messageService;
        public frmSend()
        {
            InitializeComponent();
        }
        public frmSend(User userLogined, Message message)
        {
            _user = userLogined;
            userMessage = message;
            userService = new UserService();
            messageService = new MessageService();
            InitializeComponent();
        }
        public frmSend(User userLogined)
        {
            _user = userLogined;
            userService = new UserService();
            messageService = new MessageService();
            InitializeComponent();
        }

        private void frmSend_Load(object sender, EventArgs e)
        {
            if (_user.UserStatus==Fake.DAL.Enums.UserStatus.Expert)
            {
                if (userMessage != null)
                {
                    FillUsers();
                    cmbToOrFrom.SelectedItem = userMessage.Sender;
                    cmbToOrFrom.Texts = userMessage.Sender.Email;
                    cmbToOrFrom.Enabled = false;
                    txtFrom.Texts = _user.Email;
                    txtSubject.Texts = userMessage.Subject;
                    txtSubject.Enabled = false;
                    txtFrom.Enabled = false;
                }
                else
                {
                    txtFrom.Texts = _user.Email;
                    FillUsers();
                    cmbToOrFrom.Enabled = true;
                    txtFrom.Enabled = false;
                }
            }
            else 
            {
                if (userMessage != null)
                {
                    FillExperts();
                    cmbToOrFrom.SelectedItem = userMessage.Sender;
                    cmbToOrFrom.Texts = userMessage.Sender.Email;
                    cmbToOrFrom.Enabled = false;
                    txtFrom.Texts = _user.Email;
                    txtSubject.Texts = userMessage.Subject;
                    txtSubject.Enabled = false;
                    txtFrom.Enabled = false;
                }
                else
                {

                    txtFrom.Texts = _user.Email;
                    FillExperts();
                    cmbToOrFrom.Enabled = true;
                    txtFrom.Enabled = false;
                }                
            }             
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            message.SenderId = _user.Id;
            User user = cmbToOrFrom.SelectedItem as User;
            message.ReceiverId = user.Id;
            message.Subject = txtSubject.Texts;
            message.MessageDetail = txtMessage.Texts;
            message.MessageTime = DateTime.Now;
            if (_user.UserStatus == Fake.DAL.Enums.UserStatus.User)
            {
                message.MessageStatusForUser = Fake.DAL.Enums.MessageStatus.Read;
                message.MessageStatusForExpert = Fake.DAL.Enums.MessageStatus.Unread;
            }
            else
            {
                message.MessageStatusForUser = Fake.DAL.Enums.MessageStatus.Unread;
                message.MessageStatusForExpert = Fake.DAL.Enums.MessageStatus.Read;
            }
            messageService.AddMessage(message);
            MessageBox.Show("Message sent successfully");
            frmLogin.FormEnding(this);
        }
        public void FillExperts()
        {
            List<User> experts = userService.GetExperts();
            cmbToOrFrom.Items.Clear();
            cmbToOrFrom.DataSource = experts;
            cmbToOrFrom.DisplayMember = "Email";
            cmbToOrFrom.ValueMember = "Id";
        }
        public void FillUsers()
        {
            List<User> users = userService.GetUsers();
            cmbToOrFrom.Items.Clear();
            cmbToOrFrom.DataSource = users;
            cmbToOrFrom.DisplayMember = "Email";
            cmbToOrFrom.ValueMember = "Id";
        }

        private void btnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.YellowGreen;
        }

        private void btnSend_MouseLeave(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.DarkGray;
        }
    }
}
