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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calory
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User userLogined;
                bool loginControl = userService.UserLoginControl(txtEmail.Texts, txtPassword.Texts);
                if (loginControl == true)
                {
                    MessageBox.Show("Login Succesful");
                    userLogined = userService.GetUserByEmail(txtEmail.Texts);
                    if (userLogined.UserStatus == Fake.DAL.Enums.UserStatus.Owner)
                    {
                        frmOwner ownerScreen = new frmOwner(userLogined);
                        FormOpenClose(this, ownerScreen);
                    }
                    else
                    {
                        frmMain mainForm = new frmMain(userLogined);
                        FormOpenClose(this, mainForm);
                    }
                }
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Clear();
            frmRegister frmRegister = new frmRegister();
            FormOpenClose(this, frmRegister);
        }
        public static void FormOpenClose(Form frm1, Form frm2)
        {
            frm1.Hide();
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                frm1.Show();
            }
        }
        public static void FormEnding(Form frm1)
        {
            frm1.DialogResult = DialogResult.OK;
            frm1.Close();
        }
        public void Clear()
        {
            txtEmail.Texts = string.Empty;
            txtPassword.Texts = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Clear();
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmLogin.FormOpenClose(this, frmForgotPassword);
        }

        private void lblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.YellowGreen;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.DimGray;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.YellowGreen;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Gray;
        }
    }
}

