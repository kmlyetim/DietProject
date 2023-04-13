namespace Calory
{
    partial class frmFoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoods));
            this.lblTotalMealFood = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblTotalMealFoodT = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblTotalCalory = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblTotalCaloryT = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.gbxDelete = new ReaLTaiizor.Controls.GroupBox();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.gbxAddFood = new ReaLTaiizor.Controls.GroupBox();
            this.txtAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAmount = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.lblSearch = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.gbxSelectedFoods = new ReaLTaiizor.Controls.GroupBox();
            this.lvSelectedFoods = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescription = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnAddNewFood = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxFoodSelect = new ReaLTaiizor.Controls.GroupBox();
            this.lblPortionTypeT = new System.Windows.Forms.Label();
            this.lblCategoryT = new System.Windows.Forms.Label();
            this.lblFatT = new System.Windows.Forms.Label();
            this.lblProteinT = new System.Windows.Forms.Label();
            this.lblCarbonhydrateT = new System.Windows.Forms.Label();
            this.lblPortionType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbonhydrate = new System.Windows.Forms.Label();
            this.lblCalory = new System.Windows.Forms.Label();
            this.lblCaloryT = new System.Windows.Forms.Label();
            this.lvFoods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxDelete.SuspendLayout();
            this.gbxAddFood.SuspendLayout();
            this.gbxSelectedFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxFoodSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalMealFood
            // 
            this.lblTotalMealFood.AutoSize = true;
            this.lblTotalMealFood.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMealFood.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMealFood.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalMealFood.Location = new System.Drawing.Point(194, 689);
            this.lblTotalMealFood.Name = "lblTotalMealFood";
            this.lblTotalMealFood.Size = new System.Drawing.Size(17, 19);
            this.lblTotalMealFood.TabIndex = 54;
            this.lblTotalMealFood.Text = "0";
            // 
            // lblTotalMealFoodT
            // 
            this.lblTotalMealFoodT.AutoSize = true;
            this.lblTotalMealFoodT.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMealFoodT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMealFoodT.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalMealFoodT.Location = new System.Drawing.Point(17, 689);
            this.lblTotalMealFoodT.Name = "lblTotalMealFoodT";
            this.lblTotalMealFoodT.Size = new System.Drawing.Size(171, 19);
            this.lblTotalMealFoodT.TabIndex = 52;
            this.lblTotalMealFoodT.Text = "Total Number of Meals :";
            // 
            // lblTotalCalory
            // 
            this.lblTotalCalory.AutoSize = true;
            this.lblTotalCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCalory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCalory.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalCalory.Location = new System.Drawing.Point(114, 668);
            this.lblTotalCalory.Name = "lblTotalCalory";
            this.lblTotalCalory.Size = new System.Drawing.Size(17, 19);
            this.lblTotalCalory.TabIndex = 53;
            this.lblTotalCalory.Text = "0";
            // 
            // lblTotalCaloryT
            // 
            this.lblTotalCaloryT.AutoSize = true;
            this.lblTotalCaloryT.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCaloryT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCaloryT.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalCaloryT.Location = new System.Drawing.Point(17, 668);
            this.lblTotalCaloryT.Name = "lblTotalCaloryT";
            this.lblTotalCaloryT.Size = new System.Drawing.Size(102, 19);
            this.lblTotalCaloryT.TabIndex = 51;
            this.lblTotalCaloryT.Text = "Total Calory : ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(305, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 40);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // gbxDelete
            // 
            this.gbxDelete.BackColor = System.Drawing.Color.Transparent;
            this.gbxDelete.BackGColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDelete.BaseColor = System.Drawing.Color.Transparent;
            this.gbxDelete.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxDelete.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(220)))), ((int)(((byte)(212)))));
            this.gbxDelete.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxDelete.Location = new System.Drawing.Point(236, 336);
            this.gbxDelete.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxDelete.Size = new System.Drawing.Size(230, 107);
            this.gbxDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxDelete.TabIndex = 48;
            this.gbxDelete.Text = "Delete Selected Food";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.Location = new System.Drawing.Point(34, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 30);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.DimGray;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // gbxAddFood
            // 
            this.gbxAddFood.BackColor = System.Drawing.Color.Transparent;
            this.gbxAddFood.BackGColor = System.Drawing.Color.WhiteSmoke;
            this.gbxAddFood.BaseColor = System.Drawing.Color.Transparent;
            this.gbxAddFood.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxAddFood.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxAddFood.Controls.Add(this.txtAmount);
            this.gbxAddFood.Controls.Add(this.lblAmount);
            this.gbxAddFood.Controls.Add(this.btnAdd);
            this.gbxAddFood.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAddFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(220)))), ((int)(((byte)(212)))));
            this.gbxAddFood.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxAddFood.Location = new System.Drawing.Point(12, 335);
            this.gbxAddFood.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxAddFood.Name = "gbxAddFood";
            this.gbxAddFood.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxAddFood.Size = new System.Drawing.Size(218, 107);
            this.gbxAddFood.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxAddFood.TabIndex = 47;
            this.gbxAddFood.Text = "Add Food";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmount.BorderColor = System.Drawing.Color.DimGray;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.Black;
            this.txtAmount.BorderRadius = 15;
            this.txtAmount.BorderSize = 2;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.Location = new System.Drawing.Point(82, 44);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(45, 34);
            this.txtAmount.TabIndex = 59;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lblAmount.Location = new System.Drawing.Point(9, 54);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 17);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Amount :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Location = new System.Drawing.Point(156, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 37);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add+";
            this.btnAdd.TextColor = System.Drawing.Color.DimGray;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearch.Location = new System.Drawing.Point(66, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 19);
            this.lblSearch.TabIndex = 45;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(120, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(271, 34);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // gbxSelectedFoods
            // 
            this.gbxSelectedFoods.BackColor = System.Drawing.Color.Transparent;
            this.gbxSelectedFoods.BackGColor = System.Drawing.Color.DarkGray;
            this.gbxSelectedFoods.BaseColor = System.Drawing.Color.Transparent;
            this.gbxSelectedFoods.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxSelectedFoods.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxSelectedFoods.Controls.Add(this.lvSelectedFoods);
            this.gbxSelectedFoods.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSelectedFoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(220)))), ((int)(((byte)(212)))));
            this.gbxSelectedFoods.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxSelectedFoods.Location = new System.Drawing.Point(12, 445);
            this.gbxSelectedFoods.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxSelectedFoods.Name = "gbxSelectedFoods";
            this.gbxSelectedFoods.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxSelectedFoods.Size = new System.Drawing.Size(454, 221);
            this.gbxSelectedFoods.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxSelectedFoods.TabIndex = 56;
            this.gbxSelectedFoods.Text = "Selected Foods";
            // 
            // lvSelectedFoods
            // 
            this.lvSelectedFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSelectedFoods.GridLines = true;
            this.lvSelectedFoods.HideSelection = false;
            this.lvSelectedFoods.Location = new System.Drawing.Point(8, 31);
            this.lvSelectedFoods.Name = "lvSelectedFoods";
            this.lvSelectedFoods.Size = new System.Drawing.Size(438, 182);
            this.lvSelectedFoods.TabIndex = 47;
            this.lvSelectedFoods.UseCompatibleStateImageBehavior = false;
            this.lvSelectedFoods.View = System.Windows.Forms.View.Details;
            this.lvSelectedFoods.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSelectedFoods_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Food Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Calory";
            this.columnHeader6.Width = 140;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(20, 284);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(261, 45);
            this.lblDescription.TabIndex = 57;
            this.lblDescription.Text = "If the food you are looking for is not on the list, you can add a new food here.";
            // 
            // btnAddNewFood
            // 
            this.btnAddNewFood.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFood.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFood.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddNewFood.BorderRadius = 10;
            this.btnAddNewFood.BorderSize = 1;
            this.btnAddNewFood.FlatAppearance.BorderSize = 0;
            this.btnAddNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFood.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewFood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewFood.Location = new System.Drawing.Point(300, 284);
            this.btnAddNewFood.Name = "btnAddNewFood";
            this.btnAddNewFood.Size = new System.Drawing.Size(158, 40);
            this.btnAddNewFood.TabIndex = 58;
            this.btnAddNewFood.Text = "Add New Food";
            this.btnAddNewFood.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewFood.UseVisualStyleBackColor = false;
            this.btnAddNewFood.Click += new System.EventHandler(this.btnAddNewFood_Click);
            this.btnAddNewFood.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnAddNewFood.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 741);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(443, 741);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 48;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxFoodSelect
            // 
            this.gbxFoodSelect.BackColor = System.Drawing.Color.Transparent;
            this.gbxFoodSelect.BackGColor = System.Drawing.Color.DarkGray;
            this.gbxFoodSelect.BaseColor = System.Drawing.Color.Transparent;
            this.gbxFoodSelect.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxFoodSelect.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gbxFoodSelect.Controls.Add(this.lblPortionTypeT);
            this.gbxFoodSelect.Controls.Add(this.lblCategoryT);
            this.gbxFoodSelect.Controls.Add(this.lblFatT);
            this.gbxFoodSelect.Controls.Add(this.lblProteinT);
            this.gbxFoodSelect.Controls.Add(this.lblCarbonhydrateT);
            this.gbxFoodSelect.Controls.Add(this.lblPortionType);
            this.gbxFoodSelect.Controls.Add(this.lblCategory);
            this.gbxFoodSelect.Controls.Add(this.lblFat);
            this.gbxFoodSelect.Controls.Add(this.lblProtein);
            this.gbxFoodSelect.Controls.Add(this.lblCarbonhydrate);
            this.gbxFoodSelect.Controls.Add(this.lblCalory);
            this.gbxFoodSelect.Controls.Add(this.lblCaloryT);
            this.gbxFoodSelect.Controls.Add(this.lvFoods);
            this.gbxFoodSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxFoodSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(220)))), ((int)(((byte)(212)))));
            this.gbxFoodSelect.HeaderColor = System.Drawing.Color.DimGray;
            this.gbxFoodSelect.Location = new System.Drawing.Point(17, 54);
            this.gbxFoodSelect.MinimumSize = new System.Drawing.Size(136, 50);
            this.gbxFoodSelect.Name = "gbxFoodSelect";
            this.gbxFoodSelect.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.gbxFoodSelect.Size = new System.Drawing.Size(446, 221);
            this.gbxFoodSelect.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gbxFoodSelect.TabIndex = 60;
            this.gbxFoodSelect.Text = "Food Selection Menu";
            // 
            // lblPortionTypeT
            // 
            this.lblPortionTypeT.AutoSize = true;
            this.lblPortionTypeT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortionTypeT.ForeColor = System.Drawing.Color.White;
            this.lblPortionTypeT.Location = new System.Drawing.Point(210, 148);
            this.lblPortionTypeT.Name = "lblPortionTypeT";
            this.lblPortionTypeT.Size = new System.Drawing.Size(107, 19);
            this.lblPortionTypeT.TabIndex = 48;
            this.lblPortionTypeT.Text = "Portion Type :";
            // 
            // lblCategoryT
            // 
            this.lblCategoryT.AutoSize = true;
            this.lblCategoryT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryT.ForeColor = System.Drawing.Color.White;
            this.lblCategoryT.Location = new System.Drawing.Point(237, 178);
            this.lblCategoryT.Name = "lblCategoryT";
            this.lblCategoryT.Size = new System.Drawing.Size(80, 19);
            this.lblCategoryT.TabIndex = 48;
            this.lblCategoryT.Text = "Category :";
            // 
            // lblFatT
            // 
            this.lblFatT.AutoSize = true;
            this.lblFatT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFatT.ForeColor = System.Drawing.Color.White;
            this.lblFatT.Location = new System.Drawing.Point(277, 120);
            this.lblFatT.Name = "lblFatT";
            this.lblFatT.Size = new System.Drawing.Size(39, 19);
            this.lblFatT.TabIndex = 48;
            this.lblFatT.Text = "Fat :";
            // 
            // lblProteinT
            // 
            this.lblProteinT.AutoSize = true;
            this.lblProteinT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProteinT.ForeColor = System.Drawing.Color.White;
            this.lblProteinT.Location = new System.Drawing.Point(249, 95);
            this.lblProteinT.Name = "lblProteinT";
            this.lblProteinT.Size = new System.Drawing.Size(68, 19);
            this.lblProteinT.TabIndex = 48;
            this.lblProteinT.Text = "Protein :";
            // 
            // lblCarbonhydrateT
            // 
            this.lblCarbonhydrateT.AutoSize = true;
            this.lblCarbonhydrateT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarbonhydrateT.ForeColor = System.Drawing.Color.White;
            this.lblCarbonhydrateT.Location = new System.Drawing.Point(204, 70);
            this.lblCarbonhydrateT.Name = "lblCarbonhydrateT";
            this.lblCarbonhydrateT.Size = new System.Drawing.Size(112, 19);
            this.lblCarbonhydrateT.TabIndex = 48;
            this.lblCarbonhydrateT.Text = "Carbohydrate :";
            // 
            // lblPortionType
            // 
            this.lblPortionType.AutoSize = true;
            this.lblPortionType.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortionType.ForeColor = System.Drawing.Color.White;
            this.lblPortionType.Location = new System.Drawing.Point(327, 148);
            this.lblPortionType.Name = "lblPortionType";
            this.lblPortionType.Size = new System.Drawing.Size(18, 19);
            this.lblPortionType.TabIndex = 47;
            this.lblPortionType.Text = "0";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(327, 178);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(114, 43);
            this.lblCategory.TabIndex = 47;
            this.lblCategory.Text = "0";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFat.ForeColor = System.Drawing.Color.White;
            this.lblFat.Location = new System.Drawing.Point(326, 120);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(18, 19);
            this.lblFat.TabIndex = 47;
            this.lblFat.Text = "0";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtein.ForeColor = System.Drawing.Color.White;
            this.lblProtein.Location = new System.Drawing.Point(326, 95);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(18, 19);
            this.lblProtein.TabIndex = 47;
            this.lblProtein.Text = "0";
            // 
            // lblCarbonhydrate
            // 
            this.lblCarbonhydrate.AutoSize = true;
            this.lblCarbonhydrate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarbonhydrate.ForeColor = System.Drawing.Color.White;
            this.lblCarbonhydrate.Location = new System.Drawing.Point(326, 70);
            this.lblCarbonhydrate.Name = "lblCarbonhydrate";
            this.lblCarbonhydrate.Size = new System.Drawing.Size(18, 19);
            this.lblCarbonhydrate.TabIndex = 47;
            this.lblCarbonhydrate.Text = "0";
            // 
            // lblCalory
            // 
            this.lblCalory.AutoSize = true;
            this.lblCalory.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalory.ForeColor = System.Drawing.Color.White;
            this.lblCalory.Location = new System.Drawing.Point(326, 45);
            this.lblCalory.Name = "lblCalory";
            this.lblCalory.Size = new System.Drawing.Size(18, 19);
            this.lblCalory.TabIndex = 47;
            this.lblCalory.Text = "0";
            // 
            // lblCaloryT
            // 
            this.lblCaloryT.AutoSize = true;
            this.lblCaloryT.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaloryT.ForeColor = System.Drawing.Color.White;
            this.lblCaloryT.Location = new System.Drawing.Point(255, 45);
            this.lblCaloryT.Name = "lblCaloryT";
            this.lblCaloryT.Size = new System.Drawing.Size(61, 19);
            this.lblCaloryT.TabIndex = 47;
            this.lblCaloryT.Text = "Calory :";
            // 
            // lvFoods
            // 
            this.lvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFoods.GridLines = true;
            this.lvFoods.HideSelection = false;
            this.lvFoods.Location = new System.Drawing.Point(9, 32);
            this.lvFoods.Name = "lvFoods";
            this.lvFoods.Size = new System.Drawing.Size(194, 182);
            this.lvFoods.TabIndex = 46;
            this.lvFoods.UseCompatibleStateImageBehavior = false;
            this.lvFoods.View = System.Windows.Forms.View.Details;
            this.lvFoods.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFoods_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Foods";
            this.columnHeader1.Width = 170;
            // 
            // frmFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(480, 778);
            this.Controls.Add(this.gbxFoodSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNewFood);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.gbxSelectedFoods);
            this.Controls.Add(this.lblTotalMealFood);
            this.Controls.Add(this.lblTotalMealFoodT);
            this.Controls.Add(this.lblTotalCalory);
            this.Controls.Add(this.lblTotalCaloryT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.gbxAddFood);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmFoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmFoods_Load);
            this.gbxDelete.ResumeLayout(false);
            this.gbxAddFood.ResumeLayout(false);
            this.gbxAddFood.PerformLayout();
            this.gbxSelectedFoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxFoodSelect.ResumeLayout(false);
            this.gbxFoodSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel lblTotalMealFood;
        private ReaLTaiizor.Controls.HeaderLabel lblTotalMealFoodT;
        private ReaLTaiizor.Controls.HeaderLabel lblTotalCalory;
        private ReaLTaiizor.Controls.HeaderLabel lblTotalCaloryT;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private ReaLTaiizor.Controls.GroupBox gbxDelete;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private ReaLTaiizor.Controls.GroupBox gbxAddFood;
        private ReaLTaiizor.Controls.HeaderLabel lblAmount;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private ReaLTaiizor.Controls.HeaderLabel lblSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private ReaLTaiizor.Controls.GroupBox gbxSelectedFoods;
        private System.Windows.Forms.ListView lvSelectedFoods;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private ReaLTaiizor.Controls.HeaderLabel lblDescription;
        private RJCodeAdvance.RJControls.RJButton btnAddNewFood;
        private RJCodeAdvance.RJControls.RJTextBox txtAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private ReaLTaiizor.Controls.GroupBox gbxFoodSelect;
        private System.Windows.Forms.Label lblPortionTypeT;
        private System.Windows.Forms.Label lblCategoryT;
        private System.Windows.Forms.Label lblFatT;
        private System.Windows.Forms.Label lblProteinT;
        private System.Windows.Forms.Label lblCarbonhydrateT;
        private System.Windows.Forms.Label lblPortionType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbonhydrate;
        private System.Windows.Forms.Label lblCalory;
        private System.Windows.Forms.Label lblCaloryT;
        private System.Windows.Forms.ListView lvFoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}