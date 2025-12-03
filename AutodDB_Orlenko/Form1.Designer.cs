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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewOmanukud = new DataGridView();
            tabControl1 = new TabControl();
            Owners = new TabPage();
            ShopName = new Label();
            DeleteBtnOwners = new Button();
            AddBtnOwners = new Button();
            textBox1 = new TextBox();
            labelNumber = new Label();
            labelFullName = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).BeginInit();
            tabControl1.SuspendLayout();
            Owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOmanukud
            // 
            dataGridViewOmanukud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOmanukud.Location = new Point(24, 255);
            dataGridViewOmanukud.Name = "dataGridViewOmanukud";
            dataGridViewOmanukud.Size = new Size(825, 445);
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
            Owners.BackColor = Color.DarkGray;
            Owners.Controls.Add(ShopName);
            Owners.Controls.Add(DeleteBtnOwners);
            Owners.Controls.Add(AddBtnOwners);
            Owners.Controls.Add(textBox1);
            Owners.Controls.Add(labelNumber);
            Owners.Controls.Add(labelFullName);
            Owners.Controls.Add(textBox2);
            Owners.Controls.Add(pictureBox2);
            Owners.Controls.Add(dataGridViewOmanukud);
            Owners.Location = new Point(4, 24);
            Owners.Name = "Owners";
            Owners.Padding = new Padding(3);
            Owners.Size = new Size(1699, 879);
            Owners.TabIndex = 0;
            Owners.Text = "Owners";
            // 
            // ShopName
            // 
            ShopName.Font = new Font("Microsoft PhagsPa", 28F);
            ShopName.Location = new Point(387, 12);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(462, 50);
            ShopName.TabIndex = 10;
            ShopName.Text = "ORLENKO Car Service";
            ShopName.Click += ShopName_Click;
            // 
            // DeleteBtnOwners
            // 
            DeleteBtnOwners.AutoSize = true;
            DeleteBtnOwners.BackColor = Color.LightCoral;
            DeleteBtnOwners.Location = new Point(24, 190);
            DeleteBtnOwners.Name = "DeleteBtnOwners";
            DeleteBtnOwners.Size = new Size(99, 45);
            DeleteBtnOwners.TabIndex = 9;
            DeleteBtnOwners.Text = "Delete";
            DeleteBtnOwners.UseVisualStyleBackColor = false;
            // 
            // AddBtnOwners
            // 
            AddBtnOwners.AutoSize = true;
            AddBtnOwners.BackColor = Color.YellowGreen;
            AddBtnOwners.Location = new Point(182, 190);
            AddBtnOwners.Name = "AddBtnOwners";
            AddBtnOwners.Size = new Size(99, 45);
            AddBtnOwners.TabIndex = 8;
            AddBtnOwners.Text = "Add";
            AddBtnOwners.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 7;
            // 
            // labelNumber
            // 
            labelNumber.Font = new Font("Segoe UI Black", 15F);
            labelNumber.Location = new Point(24, 128);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(134, 23);
            labelNumber.TabIndex = 6;
            labelNumber.Text = "Number:";
            // 
            // labelFullName
            // 
            labelFullName.Font = new Font("Segoe UI Black", 15F);
            labelFullName.Location = new Point(24, 57);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(163, 30);
            labelFullName.TabIndex = 5;
            labelFullName.Text = "Full Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.Без_названия;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(867, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(413, 659);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1699, 879);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 748);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).EndInit();
            tabControl1.ResumeLayout(false);
            Owners.ResumeLayout(false);
            Owners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOmanukud;
        private TabControl tabControl1;
        private TabPage Owners;
        private Label labelFullName;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label labelNumber;
        private Button DeleteBtnOwners;
        private Button AddBtnOwners;
        private TextBox textBox1;
        private Label ShopName;
    }
}
