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
            tabPage3 = new TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).BeginInit();
            tabControl1.SuspendLayout();
            Owners.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
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
            Owners.Location = new Point(4, 24);
            Owners.Name = "Owners";
            Owners.Padding = new Padding(3);
            Owners.Size = new Size(1699, 879);
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
            ShopName.Click += ShopName_Click;
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
            textBoxOwnerName.Location = new Point(165, 47);
            textBoxOwnerName.Name = "textBoxOwnerName";
            textBoxOwnerName.Size = new Size(129, 23);
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
            textBoxOwnerPhone.Location = new Point(165, 88);
            textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            textBoxOwnerPhone.Size = new Size(129, 23);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1699, 879);
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
            comboBoxOwner.Location = new Point(108, 105);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new Size(121, 23);
            comboBoxOwner.TabIndex = 20;
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(240, 72);
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(100, 23);
            textBoxRegNumber.TabIndex = 19;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(108, 39);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 18;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(108, 8);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(100, 23);
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
            label4.Click += label4_Click;
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
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1699, 879);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
        private TabPage tabPage3;
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
    }
}
