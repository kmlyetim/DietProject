using Fake.Business.Services;
using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Fake.Entites.Concrete.User;

namespace Calory
{
    public partial class frmRegister : Form
    {
        User _user;
        User newUser = new User();
        UserService userService;
        public frmRegister()
        {
            InitializeComponent();
        }
        
        public frmRegister(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            userService = new UserService();
            if (_user == null)
            {
                gbxUserStatus.Visible = false;
                txtEmail.Enabled = true;
                rdbFemale.Enabled = true;
                rdbMale.Enabled = true;
                dtpBirthDate.Enabled = true;
                txtPassword.Enabled = true;
                btnSave.Text = "Save";
                cmbActivite.Items.AddRange(Enum.GetNames(typeof(Activites)));
                gbxUserStatus.Visible = false;
                cmbActivite.SelectedItem = Activites.Little;
                cmbActivite.Texts = Activites.Little.ToString();                
            }            
            else
            {
                if (_user.UserStatus == Fake.DAL.Enums.UserStatus.User || _user.UserStatus == Fake.DAL.Enums.UserStatus.Expert)
                {
                    gbxUserStatus.Visible = false;
                    btnPicture.Text = "Update Picture ...";
                    txtEmail.Enabled = false;
                    rdbFemale.Enabled = false;
                    rdbMale.Enabled = false;
                    dtpBirthDate.Enabled = false;
                    btnSave.Text = "Update";
                    txtFirstName.Texts = _user.FirstName;
                    txtLastName.Texts = _user.LastName;
                    txtEmail.Texts = _user.Email;
                    dtpBirthDate.Value = _user.BirthDate;
                    mtxtPhone.Text = _user.PhoneNumber;
                    txtPassword.Texts = _user.Password;
                    if (_user.Picture != null)
                    {
                        pbxUserPicture.Image = ConvertByteToImage(_user.Picture);
                    }
                    txtHeight.Texts = _user.Height.ToString();
                    txtWeight.Texts = _user.Weight.ToString();
                    cmbActivite.Items.AddRange(Enum.GetNames(typeof(Activites)));
                    cmbActivite.Texts = _user.ActivityState.ToString();
                }
                else
                {
                    newUser = new User();
                    gbxUserStatus.Visible = true;                    
                    txtEmail.Enabled = true;
                    rdbFemale.Enabled = true;
                    rdbMale.Enabled = true;
                    dtpBirthDate.Enabled = true;
                    txtPassword.Enabled = true;
                    btnSave.Text = "Save";
                    cmbActivite.Items.AddRange(Enum.GetNames(typeof(Activites)));                    
                    cmbActivite.SelectedItem = Activites.Little;
                    cmbActivite.Texts = Activites.Little.ToString();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                userService = new UserService();
                if (btnSave.Text == "Save")
                {
                    newUser.FirstName = txtFirstName.Texts.Trim();
                    newUser.LastName = txtLastName.Texts;
                    newUser.Email = txtEmail.Texts;
                    newUser.Password = txtPassword.Texts;
                    newUser.BirthDate = dtpBirthDate.Value;
                    if (rdbFemale.Checked)
                    {
                        newUser.Gender = Fake.DAL.Enums.Gender.Female;
                    }
                    else if (rdbMale.Checked)
                    {
                        newUser.Gender = Fake.DAL.Enums.Gender.Male;
                    }
                    newUser.PhoneNumber = mtxtPhone.Text;
                    if (_user == null)
                    {
                        newUser.UserStatus = UserStatus.User;
                    }
                    else
                    {
                        if (rdbUser.Checked)
                        {
                            newUser.UserStatus = UserStatus.User;
                        }
                        else if (rdbExpert.Checked)
                        {
                            newUser.UserStatus = UserStatus.Expert;
                        }
                    }

                    newUser.Height = int.Parse(txtHeight.Texts);
                    newUser.Weight = int.Parse(txtWeight.Texts);
                    newUser.ActivityState = (Activites)Enum.Parse(typeof(Activites), cmbActivite.Texts);
                    DailyCaloryNeededCalculate(newUser);
                    BMICalculate(newUser);
                    userService.AddUser(newUser);
                    MessageBox.Show("Registration Successful");
                    frmLogin.FormEnding(this);
                }
                else
                {
                    _user.FirstName = txtFirstName.Texts;
                    _user.LastName = txtLastName.Texts;
                    _user.Password = txtPassword.Texts;
                    _user.PhoneNumber = mtxtPhone.Text;
                    _user.Height = int.Parse(txtHeight.Texts);
                    _user.Weight = int.Parse(txtWeight.Texts);
                    _user.ActivityState = (Activites)Enum.Parse(typeof(Activites), cmbActivite.Texts);
                    DailyCaloryNeededCalculate(_user);
                    BMICalculate(_user);
                    userService.UpdateUser(_user);
                    MessageBox.Show("Updated Successfully");
                    frmLogin.FormEnding(this);
                }
            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    MessageBox.Show("Email is already exists");
                }
                else if (ex is FormatException)
                {
                    if (txtHeight.Texts == string.Empty || txtWeight.Texts == string.Empty)
                    {
                        MessageBox.Show("Height or weight can not be empty");
                    }
                    else
                    {
                        MessageBox.Show("Height or weight can not created by letters");
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            ofd.Multiselect = false;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbxUserPicture.ImageLocation = ofd.FileName;
                if (btnSave.Text == "Save")
                {
                    newUser.Picture = ConvertFileToByte(ofd.FileName);
                }
                else
                {
                    _user.Picture = ConvertFileToByte(ofd.FileName);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }
        public static byte[] ConvertFileToByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        public static Image ConvertByteToImage(byte[] photo)
        {
            Image newImage;
            MemoryStream ms = new MemoryStream(photo, 0, photo.Length);
            ms.Write(photo, 0, photo.Length);
            newImage = Image.FromStream(ms, true);
            return newImage;
        }

        public void DailyCaloryNeededCalculate(User user)
        {
            if (user.Gender == Gender.Male)
            {
                switch (user.ActivityState)
                {
                    case Activites.Little:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (1.2);
                        break;
                    case Activites.Light:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (1.4);
                        break;
                    case Activites.Moderate:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (1.6);
                        break;
                    case Activites.Hard:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (1.75);
                        break;
                    case Activites.PhysicalWork:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (2.00);
                        break;
                    case Activites.Athlete:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) + 5) * (2.4);
                        break;
                }
            }
            else if (user.Gender == Gender.Female)
            {
                switch (user.ActivityState)
                {
                    case Activites.Little:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (1.2);
                        break;
                    case Activites.Light:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (1.4);
                        break;
                    case Activites.Moderate:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (1.6);
                        break;
                    case Activites.Hard:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (1.75);
                        break;
                    case Activites.PhysicalWork:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (2.00);
                        break;
                    case Activites.Athlete:
                        user.DailyCaloryNeeded = ((10 * user.Weight) + (6.25 * user.Height) - (5 * (DateTime.Now.Year - user.BirthDate.Year)) - 161) * (2.4);
                        break;
                }
            }
        }
        public void BMICalculate(User user)
        {
            user.BMI = Math.Round((user.Weight * 100 / Math.Pow(user.Height / 10, 2)), 1);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.YellowGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
        }
    }
}
