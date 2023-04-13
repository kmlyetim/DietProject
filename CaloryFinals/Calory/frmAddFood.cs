using Fake.Business.Services;
using Fake.DAL.Entities;
using Fake.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calory
{
    public partial class frmAddFood : Form
    {
        FoodService foodService;
        CategoryService categoryService;
        Food food;
        public frmAddFood()
        {
            InitializeComponent();
            foodService = new FoodService();
            categoryService = new CategoryService();
            food = new Food();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPicture.Texts == string.Empty)
            {
                MessageBox.Show("You cannot add food without a picture!");
            }
            else
            {
                try
                {
                    food.Name = txtName.Texts;
                    Category category = new Category();
                    category = (Category)cmbCategory.SelectedItem;
                    food.CategoryId = category.Id;
                    food.PortionType = (Portion)Enum.Parse(typeof(Portion), cmbPortion.Texts);
                    food.Carbohydrate = double.Parse(txtCarbonhydrate.Texts);
                    food.Protein = double.Parse(txtProtein.Texts);
                    food.Fat = double.Parse(txtFat.Texts);
                    food.Calory = double.Parse(txtCalory.Texts);
                    food.Description = txtDescription.Texts;
                    foodService.AddFood(food);
                    MessageBox.Show("Adding Food Completed Successfully");
                    frmLogin.FormEnding(this);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        MessageBox.Show("You did not enter the correct format.Please check the entries!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }   
        }

        private void frmAddFood_Load(object sender, EventArgs e)
        {
            cmbPortion.Items.AddRange(Enum.GetNames(typeof(Portion)));
            cmbPortion.SelectedIndex = 0;
            cmbCategory.DataSource = categoryService.GetCategories();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin.FormEnding(this);
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPicture.Texts = ofd.FileName;
                food.Picture = ConvertFileToByte(ofd.FileName);
            }
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

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.YellowGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            RJCodeAdvance.RJControls.RJButton btn = sender as RJCodeAdvance.RJControls.RJButton;
            btn.BackColor = Color.Gray;
        }
    }
}
