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
    public partial class frmMessageDetail : Form
    {
        Message _message;
        MessageService messageService;
        User _user;
        string frmControl;
        public frmMessageDetail()
        {
            InitializeComponent();
        }
        public frmMessageDetail(Message userMessage,string control,User userLogined)
        {
            InitializeComponent();
            _message = userMessage;
            frmControl = control;
            _user = userLogined;
            messageService = new MessageService();
        }
        private void frmMessageDetail_Load(object sender, EventArgs e)
        {
            if (frmControl=="Sent")
            {
                btnReply.Visible = false;
                lblToOrFrom.Text = "To :";
                txtSubject.Texts = _message.Subject;
                txtMessage.Texts = _message.MessageDetail;
                txtMessage.Enabled = false;
                txtToOrFrom.Texts = _message.Receiver.Email;
            }
            else
            {
                btnReply.Visible = true;
                lblToOrFrom.Text = "From :";
                txtToOrFrom.Texts = _message.Sender.Email;
                txtSubject.Texts = _message.Subject;
                txtMessage.Texts = _message.MessageDetail;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            messageService.DeleteMessage(_message);
            MessageBox.Show("Message deleted");
            frmLogin.FormEnding(this);
        }
        private void btnReply_Click(object sender, EventArgs e)
        {
            frmSend frmSend = new frmSend(_user
                ,_message);
            this.Hide();
            DialogResult dr = frmSend.ShowDialog();
            if (dr==DialogResult.OK)
            {
                this.Show();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.DarkGray;
        }
    }
}
