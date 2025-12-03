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
            dataGridViewOmanukud = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOmanukud
            // 
            dataGridViewOmanukud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOmanukud.Location = new Point(33, 465);
            dataGridViewOmanukud.Name = "dataGridViewOmanukud";
            dataGridViewOmanukud.Size = new Size(816, 445);
            dataGridViewOmanukud.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1731, 931);
            Controls.Add(dataGridViewOmanukud);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOmanukud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOmanukud;
    }
}
