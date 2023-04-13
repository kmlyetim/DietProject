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
    public partial class frmOwner : Form
    {
        UserService userService;
        User selectedPerson;
        User _user;
        public frmOwner()
        {
            InitializeComponent();
        }
        
        public frmOwner(User user)
        {
            _user = user;
            InitializeComponent();
        }
        private void frmOwner_Load(object sender, EventArgs e)
        {
            FillUserList();
            FillExpertList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(_user);
            this.Hide();
            DialogResult dr = frmRegister.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Show();
                FillUserList();
                FillExpertList();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPerson==null)
            {
                MessageBox.Show("You did not select a user!");
            }
            else
            {
                userService.DeleteUser(selectedPerson);
                MessageBox.Show("User deleted");
                FillUserList();
                FillExpertList();
            }
        }
        private void lvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            selectedPerson = (User)lvUsers.FocusedItem.Tag;
        }
        private void lvExperts_MouseClick(object sender, MouseEventArgs e)
        {
            selectedPerson = (User)lvExperts.FocusedItem.Tag;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }
        void FillUserList()
        {
            userService = new UserService();
            lvUsers.Items.Clear();
            var userList = userService.GetUsers();
            foreach (var item in userList)
            {
                string[] showUserListArray = { item.FirstName + " " + item.LastName };
                ListViewItem showUserList = new ListViewItem(showUserListArray);
                showUserList.Tag = item;
                lvUsers.Items.Add(showUserList);
            }
        }
        void FillExpertList()
        {
            userService = new UserService();
            lvExperts.Items.Clear();
            var expertList = userService.GetExperts();
            foreach (var item in expertList)
            {
                string[] showExpertListArray = { item.FirstName + " " + item.LastName };
                ListViewItem showExpertList = new ListViewItem(showExpertListArray);
                showExpertList.Tag = item;
                lvExperts.Items.Add(showExpertList);
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.YellowGreen;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkGray;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.DarkGray;
        }
    }
}
