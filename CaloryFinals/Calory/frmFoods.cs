using Fake.Business.Services;
using Fake.DAL.Enums;
using Fake.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fake.Entites.Concrete;
using System.IO;
using System.Xml.Linq;

namespace Calory
{
    public partial class frmFoods : Form
    {
        FoodService foodService;
        MealService mealService;
        MealFoodService mealFoodService;
        Food foodForCalory;
        Meal meal;
        MealFood selectedMealFood;
        Meal selectedMeal;
        List<MealFood> mealFoods;
        User _user;
        MealType _mealType;
        DateTime selectedTime;
        int selectedFoodId = 0;
        int counter =0;
        public frmFoods()
        {
            InitializeComponent();
        }

        public frmFoods(MealType mealType, DateTime createdTime, User userLogined)
        {
            InitializeComponent();
            _mealType = mealType;
            selectedTime = createdTime;
            _user = userLogined;
            foodService = new FoodService();
            mealService = new MealService();
            mealFoodService = new MealFoodService();
        }
        
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            FillFoodList();
        }
        private void frmFoods_Load(object sender, EventArgs e)
        {
            lblCalory.Visible = false;
            lblCarbonhydrate.Visible = false;
            lblProtein.Visible = false;
            lblFat.Visible = false;
            lblCategory.Visible = false;
            lblPortionType.Visible = false;
            FillFoodList();
            mealFoods = new List<MealFood>();
            if (_mealType == MealType.BreakFast)
            {
                if (mealService.BreakfastMealControl(_user, selectedTime))
                {
                    selectedMeal = mealService.GetBreakfastListFromUserId(_user, selectedTime);
                    mealFoods = mealFoodService.GetBreakfastMealFoods(selectedMeal.Id);
                    FillSelectedFoods(mealFoods);
                }
            }
            else if (_mealType == MealType.Lunch)
            {
                if (mealService.LunchMealControl(_user, selectedTime))
                {
                    selectedMeal = mealService.GetLunchListFromUserId(_user, selectedTime);
                     mealFoods = mealFoodService.GetLunchMealFoods(selectedMeal.Id);
                    FillSelectedFoods(mealFoods);
                }
            }
            else if (_mealType == MealType.Dinner)
            {
                if (mealService.DinnerMealControl(_user, selectedTime))
                {
                    selectedMeal = mealService.GetDinnerListFromUserId(_user, selectedTime);
                    mealFoods = mealFoodService.GetDinnerMealFoods(selectedMeal.Id);
                    FillSelectedFoods(mealFoods);
                }
            }
            else if (_mealType == MealType.Snack)
            {
                if (mealService.SnackMealControl(_user, selectedTime))
                {
                    selectedMeal = mealService.GetSnackListFromUserId(_user, selectedTime);
                    mealFoods = mealFoodService.GetSnackMealFoods(selectedMeal.Id);
                    FillSelectedFoods(mealFoods);
                }
            }
            FillLabels();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (selectedMeal != null && selectedMeal.TotalCalory == 0)
            {
                if (counter != 0)
                {
                    mealService.DeleteMeals(selectedMeal.Id);
                }
            }
            frmLogin.FormEnding(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedMeal != null)
            {
                if (selectedMeal.TotalCalory != 0)
                {
                    var list = mealFoodService.GetAllMealFoodsByMealId(selectedMeal.Id);
                    foreach (var item in list)
                    {
                        mealFoodService.DeleteMealFoods(selectedMeal.Id, item.FoodId);
                    }
                    foreach (MealFood item in mealFoods)
                    {
                        mealFoodService.AddMealFoods(item);
                    }
                    selectedMeal.TotalCalory = double.Parse(lblTotalCalory.Text);
                    if (selectedMeal != null)
                    {
                        mealService.UpdateMeal(selectedMeal);
                    }
                }
                else
                {
                    foreach (MealFood item in mealFoods)
                    {
                        mealFoodService.AddMealFoods(item);
                    }
                    selectedMeal.TotalCalory = double.Parse(lblTotalCalory.Text);
                    if (selectedMeal != null)
                    {
                        mealService.UpdateMeal(selectedMeal);
                    }
                }
                MessageBox.Show("Meal saved");
                frmLogin.FormEnding(this);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            counter++;
            if (AddFoodControl(mealFoods, selectedFoodId))
            {
                MessageBox.Show("You cannot add more than one dish from the same dish. If you want to change the number of items, you can delete and add them again.");
            }
            else if (selectedFoodId == 0)
            {
                MessageBox.Show("You have not selected a food yet!");
            }
            else
            {
                try
                {
                    if (_mealType == MealType.BreakFast)
                    {
                        if (mealService.BreakfastMealControl(_user, selectedTime))
                        {
                            selectedMeal = mealService.GetBreakfastListFromUserId(_user, selectedTime);
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                        else
                        {
                            meal = new Meal();
                            CreateMeal(meal);
                            selectedMeal = meal;
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                    }
                    else if (_mealType == MealType.Lunch)
                    {
                        if (mealService.LunchMealControl(_user, selectedTime))
                        {
                            selectedMeal = mealService.GetLunchListFromUserId(_user, selectedTime);
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                        else
                        {
                            meal = new Meal();
                            CreateMeal(meal);
                            selectedMeal = meal;
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                    }
                    else if (_mealType == MealType.Dinner)
                    {
                        if (mealService.DinnerMealControl(_user, selectedTime))
                        {
                            selectedMeal = mealService.GetDinnerListFromUserId(_user, selectedTime);
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                        else
                        {
                            meal = new Meal();
                            CreateMeal(meal);
                            selectedMeal = meal;
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                    }
                    else if (_mealType == MealType.Snack)
                    {
                        if (mealService.SnackMealControl(_user, selectedTime))
                        {
                            selectedMeal = mealService.GetSnackListFromUserId(_user, selectedTime);
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                        else
                        {
                            meal = new Meal();
                            CreateMeal(meal);
                            selectedMeal = meal;
                            MealFood mealFood = new MealFood();
                            mealFood.MealId = selectedMeal.Id;
                            mealFood.FoodId = selectedFoodId;
                            mealFood.Amount = int.Parse(txtAmount.Texts);
                            foodForCalory = foodService.GetFoodById(mealFood.FoodId);
                            mealFood.Calory = mealFood.Amount * foodForCalory.Calory;
                            mealFoods.Add(mealFood);
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        MessageBox.Show("Please enter a numerical value.");
                    }
                }
            }
            FillSelectedFoods(mealFoods);
            FillLabels();
            txtAmount.Texts = string.Empty;
        }

        private void lvSelectedFoods_MouseClick(object sender, MouseEventArgs e)
        {
            selectedMealFood = (MealFood)lvSelectedFoods.FocusedItem.Tag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMealFood==null)
            {
                MessageBox.Show("Please select food for delete!");
            }
            else
            {
                mealFoods.Remove(selectedMealFood);
                MessageBox.Show("Food deleted");
                selectedMealFood=null;
                FillSelectedFoods(mealFoods);
                FillLabels();
            }
        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            frmAddFood frmAddFood = new frmAddFood();
            this.Hide();
            DialogResult dr = frmAddFood.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                this.Show();
                FillFoodList();
            }
        }

        private void lvFoods_MouseClick(object sender, MouseEventArgs e)
        {
            string foodsName = lvFoods.FocusedItem.Text;
            Food food = foodService.GetFoodByName(foodsName);
            selectedFoodId = food.Id;
            lblCalory.Visible = true;
            lblCarbonhydrate.Visible = true;
            lblProtein.Visible = true;
            lblFat.Visible = true;
            lblCategory.Visible = true;
            lblPortionType.Visible = true;
            lblCalory.Text = food.Calory.ToString();
            lblCarbonhydrate.Text = food.Carbohydrate.ToString();
            lblProtein.Text = food.Protein.ToString();
            lblFat.Text = food.Fat.ToString();
            lblCategory.Text = food.Category.Name.ToString();
            lblPortionType.Text = food.PortionType.ToString();
        }
        void FillFoodList()
        {
            lvFoods.Items.Clear();
            var list = foodService.List(txtSearch.Texts);
            int count = 0;
            ImageList image = new ImageList();
            foreach (var item in list)
            {
                image.ImageSize = new Size(50, 50);
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = item.Picture.ToString();
                MemoryStream _ms = new MemoryStream(item.Picture);
                image.Images.Add(item.Picture.ToString(), Image.FromStream(_ms));
                lvFoods.SmallImageList = image;
                lvi.Tag = item.Id;
                lvFoods.Items.Add(item.Name, count);
                lvi.Text = item.Name;
                count++;
            }
        }
        public void FillSelectedFoods(List<MealFood> list)
        {
            lvSelectedFoods.Items.Clear();
            foreach (var item in list)
            {
                Food food = foodService.GetFoodById(item.FoodId);
                string[] forLvi = { food.Name, item.Amount.ToString(), item.Calory.ToString() };
                ListViewItem lvi = new ListViewItem(forLvi);
                lvi.Tag = item;
                lvSelectedFoods.Items.Add(lvi);
            }
        }
        public bool AddFoodControl(List<MealFood> _mealFoods, int foodId)
        {
            foreach (MealFood item in _mealFoods)
            {
                if (item.FoodId == foodId)
                {
                    return true;
                }
            }
            return false;
        }
        public void CreateMeal(Meal meal)
        {
            meal.CreateDate = selectedTime;
            meal.UserId = _user.Id;
            meal.MealType = _mealType;
            mealService.AddMeals(meal);
        }
        public void FillLabels()
        {
            double totalCalory = 0;
            foreach (ListViewItem item in lvSelectedFoods.Items)
            {
                totalCalory += double.Parse(item.SubItems[2].Text);
            }
            lblTotalCalory.Text = totalCalory.ToString();
            lblTotalMealFood.Text = lvSelectedFoods.Items.Count.ToString();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.DarkGray;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            btnDelete.ForeColor = Color.DimGray;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            btnAdd.ForeColor = Color.DimGray;
        }
    }
}
