using Fake.Business.Services;
using Fake.Entites.Concrete;
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
    public partial class frmReports : Form
    {
        UserService userService;
        MealService mealService;
        MealFoodService mealFoodService;
        User _userReports;
        DateTime _selectedTime;
        public frmReports()
        {
            InitializeComponent();
        }
        public frmReports(User user, DateTime selectedTime)
        {
            _userReports = user;
            _selectedTime = selectedTime;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           frmLogin.FormEnding(this);
        }        
        private void frmReports_Load(object sender, EventArgs e)
        {
            cmbUserSelect.SelectedItem = null;

            if (_userReports.UserStatus == Fake.DAL.Enums.UserStatus.User)
            {
                userService = new UserService();
                mealService = new MealService();
                mealFoodService = new MealFoodService();
                lblWeeklyAverageCalory.Text = Math.Round(mealService.UserWeeklyAverageCalory(_userReports), 0).ToString();
                lblMonthlyAverageCalory.Text = Math.Round(mealService.UserMonthlyAverageCalory(_userReports), 0).ToString();
                /////////////////////////////////////

                foreach (Control c in this.groupBox3.Controls)
                {

                    double[] fill = RequireNeedValuesForUser(_userReports);
                    if (c is Label)
                    {
                        if (c.Name == "lblRequireCarbonhydrate")
                        {
                            c.Text = fill[0].ToString();

                        }
                        if (c.Name == "lblRequireProtein")
                        {
                            c.Text = fill[1].ToString();
                        }
                        if (c.Name == "lblRequireFat")
                        {
                            c.Text = fill[2].ToString();
                        }
                    }
                }

                /////////////////////////////////////
                lblTakenCarbonhydrate.Text = Math.Round(mealFoodService.GetTakenTotalCarbonhydrate(_userReports, _selectedTime), 0).ToString();
                lblTakenProtein.Text = Math.Round(mealFoodService.GetTakenTotalProtein(_userReports, _selectedTime), 0).ToString();
                lblTakenFat.Text = Math.Round(mealFoodService.GetTakenTotalFat(_userReports, _selectedTime), 0).ToString();

                if (Convert.ToInt32(lblTakenCarbonhydrate.Text) > Convert.ToInt32(lblRequireCarbonhydrate.Text))
                {
                    lblTakenCarbonhydrate.ForeColor = Color.Red;
                    if (Convert.ToInt32(lblTakenCarbonhydrate.Text) <= Convert.ToInt32(lblRequireCarbonhydrate.Text) * 1.4)
                    {
                        lblDailyCarbWarn.Text = "OK";
                        lblDailyCarbWarn.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblDailyCarbWarn.Text = "HIGH";
                        lblDailyCarbWarn.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblTakenCarbonhydrate.ForeColor = Color.Green;
                    lblDailyCarbWarn.ForeColor = Color.Red;
                    lblDailyCarbWarn.Text = "LOW";
                }
                if (Convert.ToInt32(lblTakenProtein.Text) > Convert.ToInt32(lblRequireProtein.Text))
                {
                    lblTakenProtein.ForeColor = Color.Red;
                    if (Convert.ToDouble(lblTakenProtein.Text) >= (Convert.ToDouble(lblRequireProtein.Text) * 1.75))
                    {
                        lblDailyProWarn.Text = "HIGH";
                        lblDailyProWarn.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblDailyProWarn.Text = "OK";
                        lblDailyProWarn.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lblTakenProtein.ForeColor = Color.Green;
                    lblDailyProWarn.ForeColor = Color.Red;
                    lblDailyProWarn.Text = "LOW";
                }
                if (Convert.ToInt32(lblTakenFat.Text) > Convert.ToInt32(lblRequireFat.Text))
                {
                    lblTakenFat.ForeColor = Color.Red;
                    if (Convert.ToInt32(lblTakenFat.Text) >= Convert.ToInt32(lblRequireFat.Text) * 1.20)
                    {
                        lblDailyFatWarn.Text = "HIGH";
                        lblDailyFatWarn.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblDailyFatWarn.Text = "OK";
                        lblDailyFatWarn.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lblTakenFat.ForeColor = Color.Green;
                    lblDailyFatWarn.Text = "LOW";
                    lblDailyFatWarn.ForeColor = Color.Green;
                }
                FillCommentLabels(lblWeeklyAverageCalory, lblWeeklyComment, _userReports);
                FillCommentLabels(lblMonthlyAverageCalory, lblMonthlyComment, _userReports);

                lblBreakFastFoodName.Text = mealService.MostConsumedFoodForBreakfast(_userReports);
                lblLunchFoodName.Text = mealService.MostConsumedFoodForLunch(_userReports);
                lblDinnerFoodName.Text = mealService.MostConsumedFoodForDinner(_userReports);
                lblSnackFoodName.Text = mealService.MostConsumedFoodForSnack(_userReports);
                cmbUserSelect.Visible = false;
                lblSelectUser.Visible = false;
            }
            else
            {
                userService = new UserService();
                cmbUserSelect.Visible = true;
                var users = userService.GetUsers();
                cmbUserSelect.DataSource = null;
                cmbUserSelect.DataSource = users;
                cmbUserSelect.DisplayMember = "Email";
                cmbUserSelect.ValueMember = "Id";
                lblWeeklyAverageCalory.Text = default;
                lblMonthlyAverageCalory.Text = default;
                lblTakenCarbonhydrate.Text = default;
                lblTakenProtein.Text = default;
                lblTakenFat.Text = default;
                lblBreakFastFoodName.Text = default;
                lblLunchFoodName.Text = default;
                lblDinnerFoodName.Text = default;
                lblSnackFoodName.Text = default;
                lblSelectUser.Visible = true;
            }
        }
        private void rjCmbUserSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            mealService = new MealService();
            headerLabel7.Text = Math.Round(mealService.UserWeeklyAverageCalory((User)cmbUserSelect.SelectedItem),2).ToString();
            headerLabel9.Text = Math.Round(mealService.UserMonthlyAverageCalory((User)cmbUserSelect.SelectedItem),2).ToString();
            headerLabel5.Text = Math.Round(mealService.WeeklyAverageCalory(),2).ToString();
            lblBreakFastFoodName.Text = mealService.MostConsumedFoodForBreakfast((User)cmbUserSelect.SelectedItem);
            lblLunchFoodName.Text = mealService.MostConsumedFoodForLunch((User)cmbUserSelect.SelectedItem);
            lblDinnerFoodName.Text = mealService.MostConsumedFoodForDinner((User)cmbUserSelect.SelectedItem);
            lblSnackFoodName.Text = mealService.MostConsumedFoodForSnack((User)cmbUserSelect.SelectedItem);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }

        private void cmbUserSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            mealService = new MealService();

            lblWeeklyAverageCalory.Text = Math.Round(mealService.UserWeeklyAverageCalory((User)cmbUserSelect.SelectedItem), 0).ToString();
            lblMonthlyAverageCalory.Text = Math.Round(mealService.UserMonthlyAverageCalory((Fake.Entites.Concrete.User)cmbUserSelect.SelectedItem), 0).ToString();

            mealFoodService = new MealFoodService(); /////////////////////////////////////            
            lblTakenCarbonhydrate.Text = Math.Round(mealFoodService.GetTakenTotalCarbonhydrate((User)cmbUserSelect.SelectedItem, _selectedTime), 0).ToString();
            lblTakenProtein.Text = Math.Round(mealFoodService.GetTakenTotalProtein((User)cmbUserSelect.SelectedItem, _selectedTime), 0).ToString();
            lblTakenFat.Text = Math.Round(mealFoodService.GetTakenTotalFat((User)cmbUserSelect.SelectedItem, _selectedTime), 0).ToString();

            foreach (Control c in this.groupBox3.Controls)
            {

                double[] fill = RequireNeedValuesForUser((User)cmbUserSelect.SelectedItem);
                if (c is Label)
                {
                    if (c.Name == "lblRequireCarbonhydrate")
                    {
                        c.Text = fill[0].ToString();

                    }
                    if (c.Name == "lblRequireProtein")
                    {
                        c.Text = fill[1].ToString();
                    }
                    if (c.Name == "lblRequireFat")
                    {
                        c.Text = fill[2].ToString();
                    }
                }
            }
            if (Convert.ToInt32(lblTakenCarbonhydrate.Text) > Convert.ToInt32(lblRequireCarbonhydrate.Text))
            {
                lblTakenCarbonhydrate.ForeColor = Color.Red;
                if (Convert.ToInt32(lblTakenCarbonhydrate.Text) <= Convert.ToInt32(lblRequireCarbonhydrate.Text) * 1.4)
                {
                    lblDailyCarbWarn.Text = "OK";
                    lblDailyCarbWarn.ForeColor = Color.Green;
                }
                else
                {
                    lblDailyCarbWarn.Text = "HIGH";
                    lblDailyCarbWarn.ForeColor = Color.Red;
                }
            }
            else
            {
                lblTakenCarbonhydrate.ForeColor = Color.Green;
                lblDailyCarbWarn.ForeColor = Color.Red;
                lblDailyCarbWarn.Text = "LOW";
            }
            if (Convert.ToInt32(lblTakenProtein.Text) > Convert.ToInt32(lblRequireProtein.Text))
            {
                lblTakenProtein.ForeColor = Color.Red;
                if (Convert.ToDouble(lblTakenProtein.Text) >= (Convert.ToDouble(lblRequireProtein.Text) * 1.75))
                {
                    lblDailyProWarn.Text = "HIGH";
                    lblDailyProWarn.ForeColor = Color.Red;
                }
                else
                {
                    lblDailyProWarn.Text = "OK";
                    lblDailyProWarn.ForeColor = Color.Green;
                }
            }
            else
            {
                lblTakenProtein.ForeColor = Color.Green;
                lblDailyProWarn.ForeColor = Color.Red;
                lblDailyFatWarn.Text = "LOW";
            }
            if (Convert.ToInt32(lblTakenFat.Text) > Convert.ToInt32(lblRequireFat.Text))
            {
                lblTakenFat.ForeColor = Color.Red;
                if (Convert.ToInt32(lblTakenFat.Text) >= Convert.ToInt32(lblRequireFat.Text) * 1.20)
                {
                    lblDailyFatWarn.Text = "HIGH";
                    lblDailyFatWarn.ForeColor = Color.Red;
                }
                else
                {
                    lblDailyFatWarn.Text = "OK";
                    lblDailyFatWarn.ForeColor = Color.Green;
                }
            }
            else
            {
                lblTakenFat.ForeColor = Color.Green;
                lblDailyFatWarn.Text = "OK";
                lblDailyFatWarn.ForeColor = Color.Green;
            }

            FillCommentLabels(lblWeeklyAverageCalory, lblWeeklyComment, (User)cmbUserSelect.SelectedItem);
            FillCommentLabels(lblMonthlyAverageCalory, lblMonthlyComment, (User)cmbUserSelect.SelectedItem);

            lblBreakFastFoodName.Text = mealService.MostConsumedFoodForBreakfast((User)cmbUserSelect.SelectedItem);
            lblLunchFoodName.Text = mealService.MostConsumedFoodForLunch((User)cmbUserSelect.SelectedItem);
            lblDinnerFoodName.Text = mealService.MostConsumedFoodForDinner((User)cmbUserSelect.SelectedItem);
            lblSnackFoodName.Text = mealService.MostConsumedFoodForSnack((User)cmbUserSelect.SelectedItem);
        }
        Double[] RequireNeedValuesForUser(User user)
        {
            double needP = Math.Round(((user.DailyCaloryNeeded * 20) / 400), 0);
            double needF = Math.Round(((user.DailyCaloryNeeded * 25) / 900), 0);
            double needC = Math.Round(((user.DailyCaloryNeeded - (needP * 4 + needF * 9)) / 4), 0);
            Double[] needValues = { needC, needP, needF };
            return needValues;
        }
        void FillCommentLabels(Label lbl1, Label lbl2, User user)
        {
            if (user.BMI >= 20 && user.BMI <= 25)
            {
                if (Convert.ToInt32(lbl1.Text) > (int)user.DailyCaloryNeeded + 200)
                {
                    lbl1.ForeColor = Color.DimGray;
                    lbl2.Text = "You good but If you continue like this, you will gain weight";
                    lbl2.ForeColor = Color.Blue;
                }
                else if (Convert.ToInt32(lbl1.Text) < (int)user.DailyCaloryNeeded - 200)
                {
                    lbl1.ForeColor = Color.DimGray;
                    lbl2.Text = "You good but If you continue like this, you will lose weight";
                    lbl2.ForeColor = Color.Blue;
                }
            }
            else
            {
                if (Convert.ToInt32(lbl1.Text) > (int)user.DailyCaloryNeeded)
                {
                    if (user.BMI >= 25)
                    {
                        lbl1.ForeColor = Color.Red;
                        lbl2.Text = "You cross the calory line at this week..!!";
                        lbl2.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (Convert.ToInt32(lbl1.Text) > (int)user.DailyCaloryNeeded + 500 && user.BMI <= 20)
                        {
                            lbl1.ForeColor = Color.DimGray;
                            lbl2.Text = "You trying to gain weight but care, your weekly average cross +500 Cal.";
                            lbl2.ForeColor = Color.Blue;
                        }
                        else
                        {
                            lbl1.ForeColor = Color.Green;
                            lbl2.Text = "There is not any problem";
                            lbl2.ForeColor = Color.Green;
                        }
                    }
                }
                else if (Convert.ToInt32(lbl1.Text) < (int)user.DailyCaloryNeeded)
                {
                    if (user.BMI <= 20)
                    {
                        lbl1.ForeColor = Color.Red;
                        lbl2.Text = "You could eat more this week..!!";
                        lbl2.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (Convert.ToInt32(lblWeeklyAverageCalory.Text) < (int)user.DailyCaloryNeeded - 500 && user.BMI >= 25)
                        {
                            lbl1.ForeColor = Color.DimGray;
                            lbl2.Text = "You trying to lose weight but care, your weekly average too low..";
                            lbl2.ForeColor = Color.Blue;
                        }
                        else
                        {
                            lbl1.ForeColor = Color.Green;
                            lbl2.Text = "There is not any problem";
                            lbl2.ForeColor = Color.Green;
                        }
                    }
                }
            }
        }
    }
}
