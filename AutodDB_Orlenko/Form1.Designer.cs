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
            components = new System.ComponentModel.Container();
            PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewOmanukud = new DataGridView();
            tabControl1 = new TabControl();
            Owners = new TabPage();
            comboLanguage = new ComboBox();
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
            textBoxMileage = new TextBox();
            label20 = new Label();
            comboBoxCar = new ComboBox();
            label16 = new Label();
            AddbtnServiceCars = new Button();
            DeletebtnServiceCar = new Button();
            label15 = new Label();
            label14 = new Label();
            pictureBox4 = new PictureBox();
            dataGridViewServiceCar = new DataGridView();
            comboBoxOwner2 = new ComboBox();
            comboBoxService = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
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
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // dataGridViewOmanukud
            // 
            dataGridViewOmanukud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewOmanukud, "dataGridViewOmanukud");
            dataGridViewOmanukud.Name = "dataGridViewOmanukud";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Owners);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Service);
            tabControl1.Controls.Add(tabPage1);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.HotTrack = true;
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // Owners
            // 
            Owners.BackColor = Color.Silver;
            Owners.Controls.Add(comboLanguage);
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
            resources.ApplyResources(Owners, "Owners");
            Owners.Name = "Owners";
            // 
            // comboLanguage
            // 
            comboLanguage.FormattingEnabled = true;
            resources.ApplyResources(comboLanguage, "comboLanguage");
            comboLanguage.Name = "comboLanguage";
            // 
            // labelOwners
            // 
            resources.ApplyResources(labelOwners, "labelOwners");
            labelOwners.Name = "labelOwners";
            // 
            // ShopName
            // 
            resources.ApplyResources(ShopName, "ShopName");
            ShopName.Name = "ShopName";
            // 
            // DeleteBtnOwners
            // 
            resources.ApplyResources(DeleteBtnOwners, "DeleteBtnOwners");
            DeleteBtnOwners.BackColor = Color.LightCoral;
            DeleteBtnOwners.Name = "DeleteBtnOwners";
            DeleteBtnOwners.UseVisualStyleBackColor = false;
            DeleteBtnOwners.Click += DeleteBtnOwners_Click;
            // 
            // AddBtnOwners
            // 
            resources.ApplyResources(AddBtnOwners, "AddBtnOwners");
            AddBtnOwners.BackColor = Color.YellowGreen;
            AddBtnOwners.Name = "AddBtnOwners";
            AddBtnOwners.UseVisualStyleBackColor = false;
            AddBtnOwners.Click += AddBtnOwners_Click;
            // 
            // textBoxOwnerName
            // 
            resources.ApplyResources(textBoxOwnerName, "textBoxOwnerName");
            textBoxOwnerName.Name = "textBoxOwnerName";
            // 
            // labelNumber
            // 
            resources.ApplyResources(labelNumber, "labelNumber");
            labelNumber.Name = "labelNumber";
            // 
            // labelFullName
            // 
            resources.ApplyResources(labelFullName, "labelFullName");
            labelFullName.Name = "labelFullName";
            // 
            // textBoxOwnerPhone
            // 
            resources.ApplyResources(textBoxOwnerPhone, "textBoxOwnerPhone");
            textBoxOwnerPhone.Name = "textBoxOwnerPhone";
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
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            // 
            // CarsAddBtn
            // 
            CarsAddBtn.BackColor = Color.YellowGreen;
            resources.ApplyResources(CarsAddBtn, "CarsAddBtn");
            CarsAddBtn.Name = "CarsAddBtn";
            CarsAddBtn.UseVisualStyleBackColor = false;
            CarsAddBtn.Click += CarsAddBtn_Click;
            // 
            // CarsDeleteBtn
            // 
            CarsDeleteBtn.BackColor = Color.LightCoral;
            resources.ApplyResources(CarsDeleteBtn, "CarsDeleteBtn");
            CarsDeleteBtn.Name = "CarsDeleteBtn";
            CarsDeleteBtn.UseVisualStyleBackColor = false;
            CarsDeleteBtn.Click += CarsDeleteBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.porshe;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.FormattingEnabled = true;
            resources.ApplyResources(comboBoxOwner, "comboBoxOwner");
            comboBoxOwner.Name = "comboBoxOwner";
            // 
            // textBoxRegNumber
            // 
            resources.ApplyResources(textBoxRegNumber, "textBoxRegNumber");
            textBoxRegNumber.Name = "textBoxRegNumber";
            // 
            // textBoxModel
            // 
            resources.ApplyResources(textBoxModel, "textBoxModel");
            textBoxModel.Name = "textBoxModel";
            // 
            // textBoxBrand
            // 
            resources.ApplyResources(textBoxBrand, "textBoxBrand");
            textBoxBrand.Name = "textBoxBrand";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewCars, "dataGridViewCars");
            dataGridViewCars.Name = "dataGridViewCars";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
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
            resources.ApplyResources(Service, "Service");
            Service.Name = "Service";
            // 
            // buttonServiceAdd
            // 
            buttonServiceAdd.BackColor = Color.YellowGreen;
            resources.ApplyResources(buttonServiceAdd, "buttonServiceAdd");
            buttonServiceAdd.Name = "buttonServiceAdd";
            buttonServiceAdd.UseVisualStyleBackColor = false;
            buttonServiceAdd.Click += buttonServiceAdd_Click_1;
            // 
            // buttonServiceDelete
            // 
            buttonServiceDelete.BackColor = Color.LightCoral;
            resources.ApplyResources(buttonServiceDelete, "buttonServiceDelete");
            buttonServiceDelete.Name = "buttonServiceDelete";
            buttonServiceDelete.UseVisualStyleBackColor = false;
            buttonServiceDelete.Click += buttonServiceDelete_Click;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // textBoxServicePrice
            // 
            resources.ApplyResources(textBoxServicePrice, "textBoxServicePrice");
            textBoxServicePrice.Name = "textBoxServicePrice";
            // 
            // textBoxServiceName
            // 
            resources.ApplyResources(textBoxServiceName, "textBoxServiceName");
            textBoxServiceName.Name = "textBoxServiceName";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // dataGridViewService
            // 
            dataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewService, "dataGridViewService");
            dataGridViewService.Name = "dataGridViewService";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.BMW_e60__1_;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(textBoxMileage);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(comboBoxCar);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(AddbtnServiceCars);
            tabPage1.Controls.Add(DeletebtnServiceCar);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(dataGridViewServiceCar);
            tabPage1.Controls.Add(comboBoxOwner2);
            tabPage1.Controls.Add(comboBoxService);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label11);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            // 
            // textBoxMileage
            // 
            resources.ApplyResources(textBoxMileage, "textBoxMileage");
            textBoxMileage.Name = "textBoxMileage";
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            // 
            // comboBoxCar
            // 
            comboBoxCar.FormattingEnabled = true;
            resources.ApplyResources(comboBoxCar, "comboBoxCar");
            comboBoxCar.Name = "comboBoxCar";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // AddbtnServiceCars
            // 
            AddbtnServiceCars.BackColor = Color.YellowGreen;
            resources.ApplyResources(AddbtnServiceCars, "AddbtnServiceCars");
            AddbtnServiceCars.Name = "AddbtnServiceCars";
            AddbtnServiceCars.UseVisualStyleBackColor = false;
            AddbtnServiceCars.Click += AddbtnServiceCars_Click;
            // 
            // DeletebtnServiceCar
            // 
            DeletebtnServiceCar.BackColor = Color.LightCoral;
            resources.ApplyResources(DeletebtnServiceCar, "DeletebtnServiceCar");
            DeletebtnServiceCar.Name = "DeletebtnServiceCar";
            DeletebtnServiceCar.UseVisualStyleBackColor = false;
            DeletebtnServiceCar.Click += DeletebtnServiceCar_Click;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // dataGridViewServiceCar
            // 
            dataGridViewServiceCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewServiceCar, "dataGridViewServiceCar");
            dataGridViewServiceCar.Name = "dataGridViewServiceCar";
            // 
            // comboBoxOwner2
            // 
            comboBoxOwner2.FormattingEnabled = true;
            resources.ApplyResources(comboBoxOwner2, "comboBoxOwner2");
            comboBoxOwner2.Name = "comboBoxOwner2";
            // 
            // comboBoxService
            // 
            comboBoxService.FormattingEnabled = true;
            resources.ApplyResources(comboBoxService, "comboBoxService");
            comboBoxService.Name = "comboBoxService";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(contextMenuStrip2, "contextMenuStrip2");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "Form1";
            Load += Form1_Load;
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
            tabPage1.PerformLayout();
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
        private ComboBox comboBoxOwner2;
        private ComboBox comboBoxCarServiceCar;
        private ComboBox comboBoxService;
        private Label label13;
        private Label label11;
        private Label label14;
        private PictureBox pictureBox4;
        private DataGridView dataGridViewServiceCar;
        private Label label15;
        private Button AddbtnServiceCars;
        private Button DeletebtnServiceCar;
        private Label label16;
        private ComboBox comboBoxCar;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxMileage;
        private Label label20;
        private ContextMenuStrip contextMenuStrip2;
        private ComboBox comboLanguage;
    }
}
