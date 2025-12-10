namespace AutodDB_Orlenko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewOmanukud = new DataGridView();
            tabControl1 = new TabControl();
            Owners = new TabPage();
            labelOwners = new Label();
            ShopName = new Label();
            DeleteBtnOwners = new Button();
            AddBtnOwners = new Button();
            textBoxOwnerName = new TextBox();
            labelNumber = new Label();
            labelFullName = new Label();
            textBoxOwnerPhone = new TextBox();
            tabPage2 = new TabPage();
            CarsAddBtn = new Button();
            CarsDeleteBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            comboBoxOwner = new ComboBox();
            textBoxRegNumber = new TextBox();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridViewCars = new DataGridView();
            label1 = new Label();
            Service = new TabPage();
            buttonServiceAdd = new Button();
            buttonServiceDelete = new Button();
            label10 = new Label();
            textBoxServicePrice = new TextBox();
            textBoxServiceName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            dataGridViewService = new DataGridView();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            tabPage1 = new TabPage();
            AddbtnServiceCars = new Button();
            DeletebtnServiceCar = new Button();
            label15 = new Label();
            label14 = new Label();
            pictureBox4 = new PictureBox();
            dataGridViewServiceCar = new DataGridView();
            comboBoxOwnerServiceCar = new ComboBox();
            comboBoxCarServiceRegNumber = new ComboBox();
            comboBoxServiceCarName = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBoxCarServiceModel = new ComboBox();
            comboBoxCarServiceBrand = new ComboBox();
            comboBoxServiceCarPrice = new ComboBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).BeginInit();
            tabControl1.SuspendLayout();
            Owners.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceCar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.Без_названия;
            pictureBox2.Image = Properties.Resources.garaz__1_;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(525, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 635);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dataGridViewOmanukud
            // 
            dataGridViewOmanukud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOmanukud.Location = new Point(24, 255);
            dataGridViewOmanukud.Name = "dataGridViewOmanukud";
            dataGridViewOmanukud.Size = new Size(475, 445);
            dataGridViewOmanukud.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Owners);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Service);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 186);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(12, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1707, 907);
            tabControl1.TabIndex = 1;
            // 
            // Owners
            // 
            Owners.BackColor = Color.Silver;
            Owners.Controls.Add(labelOwners);
            Owners.Controls.Add(ShopName);
            Owners.Controls.Add(DeleteBtnOwners);
            Owners.Controls.Add(AddBtnOwners);
            Owners.Controls.Add(textBoxOwnerName);
            Owners.Controls.Add(labelNumber);
            Owners.Controls.Add(labelFullName);
            Owners.Controls.Add(textBoxOwnerPhone);
            Owners.Controls.Add(pictureBox2);
            Owners.Controls.Add(dataGridViewOmanukud);
            Owners.Location = new Point(4, 30);
            Owners.Name = "Owners";
            Owners.Padding = new Padding(3);
            Owners.Size = new Size(1699, 873);
            Owners.TabIndex = 0;
            Owners.Text = "Owners";
            // 
            // labelOwners
            // 
            labelOwners.Font = new Font("Segoe UI Black", 20F);
            labelOwners.Location = new Point(24, 219);
            labelOwners.Name = "labelOwners";
            labelOwners.Size = new Size(166, 33);
            labelOwners.TabIndex = 11;
            labelOwners.Text = "Owners:";
            // 
            // ShopName
            // 
            ShopName.Font = new Font("Microsoft PhagsPa", 28F);
            ShopName.Location = new Point(525, 3);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(430, 59);
            ShopName.TabIndex = 10;
            ShopName.Text = "ORLENKO Car Service";
            // 
            // DeleteBtnOwners
            // 
            DeleteBtnOwners.AutoSize = true;
            DeleteBtnOwners.BackColor = Color.LightCoral;
            DeleteBtnOwners.Location = new Point(24, 135);
            DeleteBtnOwners.Name = "DeleteBtnOwners";
            DeleteBtnOwners.Size = new Size(99, 45);
            DeleteBtnOwners.TabIndex = 9;
            DeleteBtnOwners.Text = "Delete";
            DeleteBtnOwners.UseVisualStyleBackColor = false;
            DeleteBtnOwners.Click += DeleteBtnOwners_Click;
            // 
            // AddBtnOwners
            // 
            AddBtnOwners.AutoSize = true;
            AddBtnOwners.BackColor = Color.YellowGreen;
            AddBtnOwners.Location = new Point(195, 135);
            AddBtnOwners.Name = "AddBtnOwners";
            AddBtnOwners.Size = new Size(99, 45);
            AddBtnOwners.TabIndex = 8;
            AddBtnOwners.Text = "Add";
            AddBtnOwners.UseVisualStyleBackColor = false;
            AddBtnOwners.Click += AddBtnOwners_Click;
            // 
            // textBoxOwnerName
            // 
            textBoxOwnerName.Location = new Point(165, 42);
            textBoxOwnerName.Name = "textBoxOwnerName";
            textBoxOwnerName.Size = new Size(129, 29);
            textBoxOwnerName.TabIndex = 7;
            // 
            // labelNumber
            // 
            labelNumber.Font = new Font("Segoe UI Black", 15F);
            labelNumber.Location = new Point(24, 80);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(99, 42);
            labelNumber.TabIndex = 6;
            labelNumber.Text = "Number:";
            // 
            // labelFullName
            // 
            labelFullName.Font = new Font("Segoe UI Black", 15F);
            labelFullName.Location = new Point(24, 39);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(123, 30);
            labelFullName.TabIndex = 5;
            labelFullName.Text = "Full Name:";
            // 
            // textBoxOwnerPhone
            // 
            textBoxOwnerPhone.Location = new Point(165, 83);
            textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            textBoxOwnerPhone.Size = new Size(129, 29);
            textBoxOwnerPhone.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(CarsAddBtn);
            tabPage2.Controls.Add(CarsDeleteBtn);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(comboBoxOwner);
            tabPage2.Controls.Add(textBoxRegNumber);
            tabPage2.Controls.Add(textBoxModel);
            tabPage2.Controls.Add(textBoxBrand);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridViewCars);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1699, 873);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cars";
            // 
            // CarsAddBtn
            // 
            CarsAddBtn.BackColor = Color.YellowGreen;
            CarsAddBtn.Location = new Point(140, 145);
            CarsAddBtn.Name = "CarsAddBtn";
            CarsAddBtn.Size = new Size(89, 45);
            CarsAddBtn.TabIndex = 23;
            CarsAddBtn.Text = "Add";
            CarsAddBtn.UseVisualStyleBackColor = false;
            CarsAddBtn.Click += CarsAddBtn_Click;
            // 
            // CarsDeleteBtn
            // 
            CarsDeleteBtn.BackColor = Color.LightCoral;
            CarsDeleteBtn.Location = new Point(21, 145);
            CarsDeleteBtn.Name = "CarsDeleteBtn";
            CarsDeleteBtn.Size = new Size(89, 45);
            CarsDeleteBtn.TabIndex = 22;
            CarsDeleteBtn.Text = "Delete";
            CarsDeleteBtn.UseVisualStyleBackColor = false;
            CarsDeleteBtn.Click += CarsDeleteBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.porshe;
            pictureBox1.Location = new Point(588, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 635);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Black", 20F);
            label6.Location = new Point(21, 210);
            label6.Name = "label6";
            label6.Size = new Size(100, 42);
            label6.TabIndex = 15;
            label6.Text = "Cars:";
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new Point(108, 97);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new Size(121, 29);
            comboBoxOwner.TabIndex = 20;
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(245, 67);
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(100, 29);
            textBoxRegNumber.TabIndex = 19;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(108, 39);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 29);
            textBoxModel.TabIndex = 18;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(108, 8);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(100, 29);
            textBoxBrand.TabIndex = 17;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Black", 15F);
            label5.Location = new Point(21, 97);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 16;
            label5.Text = "Owner:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 15F);
            label4.Location = new Point(21, 64);
            label4.Name = "label4";
            label4.Size = new Size(234, 33);
            label4.TabIndex = 15;
            label4.Text = "RegistrationNumber:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 15F);
            label3.Location = new Point(21, 34);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 14;
            label3.Text = "Model:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 15F);
            label2.Location = new Point(21, 3);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 13;
            label2.Text = "Brand:";
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(21, 255);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(542, 445);
            dataGridViewCars.TabIndex = 12;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft PhagsPa", 28F);
            label1.Location = new Point(588, 5);
            label1.Name = "label1";
            label1.Size = new Size(430, 59);
            label1.TabIndex = 11;
            label1.Text = "ORLENKO Car Service";
            // 
            // Service
            // 
            Service.BackColor = Color.Silver;
            Service.Controls.Add(buttonServiceAdd);
            Service.Controls.Add(buttonServiceDelete);
            Service.Controls.Add(label10);
            Service.Controls.Add(textBoxServicePrice);
            Service.Controls.Add(textBoxServiceName);
            Service.Controls.Add(label9);
            Service.Controls.Add(label8);
            Service.Controls.Add(dataGridViewService);
            Service.Controls.Add(pictureBox3);
            Service.Controls.Add(label7);
            Service.Location = new Point(4, 30);
            Service.Name = "Service";
            Service.Padding = new Padding(3);
            Service.Size = new Size(1699, 873);
            Service.TabIndex = 2;
            Service.Text = "Service";
            // 
            // buttonServiceAdd
            // 
            buttonServiceAdd.BackColor = Color.YellowGreen;
            buttonServiceAdd.Location = new Point(121, 128);
            buttonServiceAdd.Name = "buttonServiceAdd";
            buttonServiceAdd.Size = new Size(89, 45);
            buttonServiceAdd.TabIndex = 24;
            buttonServiceAdd.Text = "Add";
            buttonServiceAdd.UseVisualStyleBackColor = false;
            buttonServiceAdd.Click += buttonServiceAdd_Click_1;
            // 
            // buttonServiceDelete
            // 
            buttonServiceDelete.BackColor = Color.LightCoral;
            buttonServiceDelete.Location = new Point(16, 128);
            buttonServiceDelete.Name = "buttonServiceDelete";
            buttonServiceDelete.Size = new Size(89, 45);
            buttonServiceDelete.TabIndex = 23;
            buttonServiceDelete.Text = "Delete";
            buttonServiceDelete.UseVisualStyleBackColor = false;
            buttonServiceDelete.Click += buttonServiceDelete_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Black", 20F);
            label10.Location = new Point(6, 215);
            label10.Name = "label10";
            label10.Size = new Size(120, 42);
            label10.TabIndex = 19;
            label10.Text = "Service:";
            // 
            // textBoxServicePrice
            // 
            textBoxServicePrice.Location = new Point(110, 78);
            textBoxServicePrice.Name = "textBoxServicePrice";
            textBoxServicePrice.Size = new Size(100, 29);
            textBoxServicePrice.TabIndex = 18;
            // 
            // textBoxServiceName
            // 
            textBoxServiceName.Location = new Point(110, 36);
            textBoxServiceName.Name = "textBoxServiceName";
            textBoxServiceName.Size = new Size(100, 29);
            textBoxServiceName.TabIndex = 17;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Black", 15F);
            label9.Location = new Point(16, 74);
            label9.Name = "label9";
            label9.Size = new Size(100, 33);
            label9.TabIndex = 16;
            label9.Text = "Price:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 15F);
            label8.Location = new Point(16, 33);
            label8.Name = "label8";
            label8.Size = new Size(100, 29);
            label8.TabIndex = 15;
            label8.Text = "Name:";
            // 
            // dataGridViewService
            // 
            dataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewService.Location = new Point(6, 260);
            dataGridViewService.Name = "dataGridViewService";
            dataGridViewService.Size = new Size(569, 282);
            dataGridViewService.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.BMW_e60__1_;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(581, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(416, 626);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft PhagsPa", 28F);
            label7.Location = new Point(590, 3);
            label7.Name = "label7";
            label7.Size = new Size(430, 59);
            label7.TabIndex = 12;
            label7.Text = "ORLENKO Car Service";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(comboBoxServiceCarPrice);
            tabPage1.Controls.Add(comboBoxCarServiceBrand);
            tabPage1.Controls.Add(comboBoxCarServiceModel);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(AddbtnServiceCars);
            tabPage1.Controls.Add(DeletebtnServiceCar);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(dataGridViewServiceCar);
            tabPage1.Controls.Add(comboBoxOwnerServiceCar);
            tabPage1.Controls.Add(comboBoxCarServiceRegNumber);
            tabPage1.Controls.Add(comboBoxServiceCarName);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1699, 873);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "ServiceCar";
            // 
            // AddbtnServiceCars
            // 
            AddbtnServiceCars.BackColor = Color.YellowGreen;
            AddbtnServiceCars.Location = new Point(139, 241);
            AddbtnServiceCars.Name = "AddbtnServiceCars";
            AddbtnServiceCars.Size = new Size(87, 46);
            AddbtnServiceCars.TabIndex = 27;
            AddbtnServiceCars.Text = "Add";
            AddbtnServiceCars.UseVisualStyleBackColor = false;
            AddbtnServiceCars.Click += AddbtnServiceCars_Click;
            // 
            // DeletebtnServiceCar
            // 
            DeletebtnServiceCar.BackColor = Color.LightCoral;
            DeletebtnServiceCar.Location = new Point(15, 241);
            DeletebtnServiceCar.Name = "DeletebtnServiceCar";
            DeletebtnServiceCar.Size = new Size(87, 46);
            DeletebtnServiceCar.TabIndex = 26;
            DeletebtnServiceCar.Text = "Delete";
            DeletebtnServiceCar.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Black", 20F);
            label15.Location = new Point(15, 311);
            label15.Name = "label15";
            label15.Size = new Size(263, 39);
            label15.TabIndex = 25;
            label15.Text = "Service cars:";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft PhagsPa", 28F);
            label14.Location = new Point(596, 0);
            label14.Name = "label14";
            label14.Size = new Size(430, 63);
            label14.TabIndex = 24;
            label14.Text = "ORLENKO Car Service";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(637, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(360, 616);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // dataGridViewServiceCar
            // 
            dataGridViewServiceCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServiceCar.Location = new Point(15, 365);
            dataGridViewServiceCar.Name = "dataGridViewServiceCar";
            dataGridViewServiceCar.Size = new Size(616, 335);
            dataGridViewServiceCar.TabIndex = 22;
            // 
            // comboBoxOwnerServiceCar
            // 
            comboBoxOwnerServiceCar.FormattingEnabled = true;
            comboBoxOwnerServiceCar.Location = new Point(479, 84);
            comboBoxOwnerServiceCar.Name = "comboBoxOwnerServiceCar";
            comboBoxOwnerServiceCar.Size = new Size(121, 29);
            comboBoxOwnerServiceCar.TabIndex = 21;
            // 
            // comboBoxCarServiceRegNumber
            // 
            comboBoxCarServiceRegNumber.FormattingEnabled = true;
            comboBoxCarServiceRegNumber.Location = new Point(249, 193);
            comboBoxCarServiceRegNumber.Name = "comboBoxCarServiceRegNumber";
            comboBoxCarServiceRegNumber.Size = new Size(121, 29);
            comboBoxCarServiceRegNumber.TabIndex = 20;
            // 
            // comboBoxServiceCarName
            // 
            comboBoxServiceCarName.FormattingEnabled = true;
            comboBoxServiceCarName.Location = new Point(177, 18);
            comboBoxServiceCarName.Name = "comboBoxServiceCarName";
            comboBoxServiceCarName.Size = new Size(121, 29);
            comboBoxServiceCarName.TabIndex = 19;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Black", 15F);
            label13.Location = new Point(341, 81);
            label13.Name = "label13";
            label13.Size = new Size(169, 29);
            label13.TabIndex = 18;
            label13.Text = "Owner:";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Black", 15F);
            label12.Location = new Point(15, 190);
            label12.Name = "label12";
            label12.Size = new Size(228, 29);
            label12.TabIndex = 17;
            label12.Text = "Registration Number:  ";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Black", 15F);
            label11.Location = new Point(15, 16);
            label11.Name = "label11";
            label11.Size = new Size(169, 29);
            label11.TabIndex = 16;
            label11.Text = " Service Name:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI Black", 15F);
            label16.Location = new Point(15, 111);
            label16.Name = "label16";
            label16.Size = new Size(169, 29);
            label16.TabIndex = 28;
            label16.Text = "Car Brand:  ";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI Black", 15F);
            label17.Location = new Point(15, 152);
            label17.Name = "label17";
            label17.Size = new Size(169, 29);
            label17.TabIndex = 29;
            label17.Text = "Car Model:  ";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI Black", 15F);
            label18.Location = new Point(15, 53);
            label18.Name = "label18";
            label18.Size = new Size(156, 29);
            label18.TabIndex = 30;
            label18.Text = " Service Price:";
            // 
            // comboBoxCarServiceModel
            // 
            comboBoxCarServiceModel.FormattingEnabled = true;
            comboBoxCarServiceModel.Location = new Point(157, 152);
            comboBoxCarServiceModel.Name = "comboBoxCarServiceModel";
            comboBoxCarServiceModel.Size = new Size(121, 29);
            comboBoxCarServiceModel.TabIndex = 31;
            // 
            // comboBoxCarServiceBrand
            // 
            comboBoxCarServiceBrand.FormattingEnabled = true;
            comboBoxCarServiceBrand.Location = new Point(157, 114);
            comboBoxCarServiceBrand.Name = "comboBoxCarServiceBrand";
            comboBoxCarServiceBrand.Size = new Size(121, 29);
            comboBoxCarServiceBrand.TabIndex = 32;
            // 
            // comboBoxServiceCarPrice
            // 
            comboBoxServiceCarPrice.FormattingEnabled = true;
            comboBoxServiceCarPrice.Location = new Point(177, 53);
            comboBoxServiceCarPrice.Name = "comboBoxServiceCarPrice";
            comboBoxServiceCarPrice.Size = new Size(121, 29);
            comboBoxServiceCarPrice.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 748);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).EndInit();
            tabControl1.ResumeLayout(false);
            Owners.ResumeLayout(false);
            Owners.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            Service.ResumeLayout(false);
            Service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOmanukud;
        private TabControl tabControl1;
        private TabPage Owners;
        private Label labelFullName;
        private TextBox textBoxOwnerPhone;
        private PictureBox pictureBox2;
        private TabPage tabPage2;
        private TabPage Service;
        private Label labelNumber;
        private Button DeleteBtnOwners;
        private Button AddBtnOwners;
        private TextBox textBoxOwnerName;
        private Label ShopName;
        private Label labelOwners;
        private DataGridView dataGridViewCars;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxOwner;
        private TextBox textBoxRegNumber;
        private TextBox textBoxModel;
        private TextBox textBoxBrand;
        private Button CarsDeleteBtn;
        private PictureBox pictureBox1;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button CarsAddBtn;
        private Label label7;
        private PictureBox pictureBox3;
        private TabPage tabPage1;
        private Label label9;
        private Label label8;
        private DataGridView dataGridViewService;
        private Button buttonServiceAdd;
        private Button buttonServiceDelete;
        private Label label10;
        private TextBox textBoxServicePrice;
        private TextBox textBoxServiceName;
        private ComboBox comboBoxOwnerServiceCar;
        private ComboBox comboBoxCarServiceCar;
        private ComboBox comboBoxServiceCarName;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private PictureBox pictureBox4;
        private DataGridView dataGridViewServiceCar;
        private Label label15;
        private Button AddbtnServiceCars;
        private Button DeletebtnServiceCar;
        private Label label16;
        private ComboBox comboBoxCarServiceBrand;
        private ComboBox comboBoxCarServiceModel;
        private Label label18;
        private Label label17;
        private ComboBox comboBoxCarServiceRegNumber;
        private ComboBox comboBoxServiceCarPrice;
    }
}
