using Fake.Business.Services;
using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using ReaLTaiizor.Extension;
using RJCodeAdvance.RJControls;
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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
            mealService = new MealService();
        }
        User _user;
        MealType _mealType;
        DateTime createdTime;
        MealService mealService;
        public frmUserInfo(User userLogined)
        {
            _user = userLogined;
            mealService = new MealService();
            InitializeComponent();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            dtpSelectDate.Value = DateTime.Now;
            ViewUserInfo();
            ItemAdded();
            SystemFeedbackLabels();
        }

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {
            ItemAdded();
            SystemFeedbackLabels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(_user);
            frmLogin.FormOpenClose(this, frmRegister);
            ViewUserInfo();
            SystemFeedbackLabels();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            createdTime = dtpSelectDate.Value.Date;
            _mealType = MealType.BreakFast;
            frmFoods frmfoods = new frmFoods(_mealType, createdTime, _user);
            ShownUptaded(this, frmfoods);
            SystemFeedbackLabels();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            createdTime = dtpSelectDate.Value.Date;
            _mealType = MealType.Lunch;
            frmFoods frmfoods = new frmFoods(_mealType, createdTime, _user);
            ShownUptaded(this, frmfoods);
            SystemFeedbackLabels();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            createdTime = dtpSelectDate.Value.Date;
            _mealType = MealType.Dinner;
            frmFoods frmfoods = new frmFoods(_mealType, createdTime, _user);
            ShownUptaded(this, frmfoods);
            SystemFeedbackLabels();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            createdTime = dtpSelectDate.Value.Date;
            _mealType = MealType.Snack;
            frmFoods frmfoods = new frmFoods(_mealType, createdTime, _user);
            ShownUptaded(this, frmfoods);
            SystemFeedbackLabels();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports(_user, dtpSelectDate.Value.Date);
            frmLogin.FormOpenClose(this, frmReports);
        }
        public void ItemAdded()
        {
            lblBreakfastItem.Text = (mealService.ShowBreakfastAddedItems(_user, dtpSelectDate.Value.Date)) + " Items Added";
            lblLunchItem.Text = (mealService.ShowLunchAddedItems(_user, dtpSelectDate.Value.Date)) + " Items Added";
            lblDinnerItem.Text = (mealService.ShowDinnerAddedItems(_user, dtpSelectDate.Value.Date)) + " Items Added";
            lblSnackItem.Text = (mealService.ShowSnackAddedItems(_user, dtpSelectDate.Value.Date)) + " Items Added";
            lblDailyCalory.Text = mealService.ShowDailyTotalCalory(_user, dtpSelectDate.Value.Date).ToString();
        }
        public void ShownUptaded(Form frm1, Form frm2)
        {
            frm1.Hide();
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                this.Show();
                ItemAdded();
            }
        }
        public void ViewUserInfo()
        {
            lblFullName.Text = _user.FirstName + " " + _user.LastName;
            lblUserHeight.Text = _user.Height.ToString();
            lblUserWeight.Text = _user.Weight.ToString();
            lblBMI.Text = _user.BMI.ToString();
            lblDailyCaloryRequirement.Text = _user.DailyCaloryNeeded.ToString();
            if (_user.Picture != null)
            {
                ImageConverter imageConverter = new ImageConverter();
                rjCircularPictureBox1.Image = (Image)imageConverter.ConvertFrom(_user.Picture);
            }
        }
        public void SystemFeedbackLabels()
        {
            if (_user.BMI <= 25 && _user.BMI >= 20)
            {
                lblSystemFeedback.ForeColor = Color.Green;
                lblSystemFeedback.Text = "Your weight is ideal!";
            }
            else if (_user.BMI > 25)
            {
                lblSystemFeedback.ForeColor = Color.Red;
                lblSystemFeedback.Text = "You need to lose weight!";
            }
            else
            {
                lblSystemFeedback.ForeColor = Color.Red;
                lblSystemFeedback.Text = "You need to gain weight!";
            }

            if (Convert.ToDouble(lblDailyCalory.Text) == 0 || Convert.ToDouble(lblDailyCalory.Text) <= 500)
            {
                lblDailyFeedback.ForeColor = Color.Green;
                lblDailyFeedback.Text = "I guess, day has already begun or you are starving";
            }

            else if (lblSystemFeedback.Text == "Your weight is ideal!")
            {
                if (Convert.ToDouble(lblDailyCalory.Text) > Convert.ToDouble(lblDailyCaloryRequirement.Text) + 200)
                {
                    lblDailyFeedback.ForeColor = Color.Green;
                    lblDailyFeedback.Text = "You weight is between ideal kilos but don't eat more today!!";
                }
                else if (Convert.ToDouble(lblDailyCalory.Text) < Convert.ToDouble(lblDailyCaloryRequirement.Text) - 200)
                {
                    lblDailyFeedback.ForeColor = Color.Green;
                    lblDailyFeedback.Text = "You weight is between ideal kilos but you need to eat more today!!";
                }
            }
            else if (lblSystemFeedback.Text == "You need to lose weight!")
            {
                if (Convert.ToDouble(lblDailyCalory.Text) > 500 && Convert.ToDouble(lblDailyCalory.Text) <= Convert.ToDouble(lblDailyCaloryRequirement.Text) - 500)
                {
                    lblDailyFeedback.ForeColor = Color.Green;
                    lblDailyFeedback.Text = $"Today, your goal is {Convert.ToDouble(lblDailyCaloryRequirement.Text) - 500} Calory..Do not cross!!";
                }
                else if (Convert.ToDouble(lblDailyCalory.Text) > 500 && Convert.ToDouble(lblDailyCalory.Text) > Convert.ToDouble(lblDailyCaloryRequirement.Text) - 500)
                {
                    lblDailyFeedback.ForeColor = Color.Red;
                    lblDailyFeedback.Text = "You cross the line!!!";
                }
            }
            else if (lblSystemFeedback.Text == "You need to gain weight!")
            {
                if (Convert.ToDouble(lblDailyCalory.Text) > 500 && Convert.ToDouble(lblDailyCalory.Text) < Convert.ToDouble(lblDailyCaloryRequirement.Text))
                {
                    lblDailyFeedback.ForeColor = Color.Green;
                    lblDailyFeedback.Text = $"Today, your goal is {Convert.ToDouble(lblDailyCaloryRequirement.Text) + 500} Calory..Come on!!";
                }
                else if (Convert.ToDouble(lblDailyCalory.Text) > 500 && Convert.ToDouble(lblDailyCalory.Text) > Convert.ToDouble(lblDailyCaloryRequirement.Text) + 500)
                {
                    lblDailyFeedback.ForeColor = Color.Red;
                    lblDailyFeedback.Text = $"Heyy enought today..Yes u need u gain weight but take it easy!!";
                }
            }
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
        }
    }
}
