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
    public partial class frmForgotPassword : Form
    {
        UserService userService;
        User _user;
        public frmForgotPassword()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;
            lblDescription.Visible = false;
            btnSave.Visible = false;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            bool control = userService.UserForgotPasswordControl(txtEmail.Texts, txtPhone.Text);
            if (control)
            {
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblDescription.Visible = true;
                btnSave.Visible = true;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                btnResetPassword.Enabled = false;
                _user = userService.GetUserByEmail(txtEmail.Texts);
                MessageBox.Show("You can reset your password!");
            }
            else
            {
                MessageBox.Show("Invalid email or phone number!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _user.Password = txtNewPassword.Texts;
                userService.UpdateUser(_user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void btnResetPassword_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnResetPassword_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.DarkGray;
        }
    }
}
