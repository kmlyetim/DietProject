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

namespace Calory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        User _user;
        MessageService messageService;
        public frmMain(User userLogined)
        {
            InitializeComponent();
            _user = userLogined;
            messageService = new MessageService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            if (_user.UserStatus==Fake.DAL.Enums.UserStatus.Expert)
            {
                btnAddMeal.Visible = false;
                btnReports.Text = ">> User Reports";
                btnAskToExpert.Text = ">> New Message";
            }
            else
            {
                btnAddMeal.Visible = true;
                btnReports.Text = ">> Reports";
                btnAskToExpert.Text = ">> Ask To Expert";
            }
            rjDatePicker1.Value = DateTime.Now;
            FillNotification();
        }

        private void btnAddMeal_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.TextColor = Color.White;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnAddMeal_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.TextColor = System.Drawing.Color.White;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            frmMessageBox frmMessageBox = new frmMessageBox(_user);
            this.Hide();
            DialogResult dr = frmMessageBox.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FillNotification();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void btnAskToExpert_Click(object sender, EventArgs e)
        {
            frmSend frmSend = new frmSend(_user);
            this.Hide();
            DialogResult dr = frmSend.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillNotification();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports(_user, rjDatePicker1.Value.Date);
            frmLogin.FormOpenClose(this, frmReports);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(_user);
            frmLogin.FormOpenClose(this, frmUserInfo);
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

        private void btnUserDetail_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(_user);
            frmLogin.FormOpenClose(this,frmRegister);
        }
    }
}
