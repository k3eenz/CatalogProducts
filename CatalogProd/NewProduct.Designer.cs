namespace CatalogProd
{
    partial class NewProduct
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
            NameTextBox = new TextBox();
            ManufacturerTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            AddProductBtn = new Button();
            BackBtn = new Button();
            PriceTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CountNumeric = new NumericUpDown();
            label6 = new Label();
            DescriptionTextBox = new TextBox();
            AddPhotoBtn = new Button();
            pictureBox = new PictureBox();
            ClearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(147, 96);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(191, 23);
            NameTextBox.TabIndex = 16;
            // 
            // ManufacturerTextBox
            // 
            ManufacturerTextBox.Location = new Point(146, 132);
            ManufacturerTextBox.Name = "ManufacturerTextBox";
            ManufacturerTextBox.Size = new Size(191, 23);
            ManufacturerTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(65, 54);
            label9.Name = "label9";
            label9.Size = new Size(188, 25);
            label9.TabIndex = 18;
            label9.Text = "Add new product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(24, 96);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 19;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(23, 131);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 20;
            label7.Text = "Manufacturer";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(22, 368);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(312, 31);
            AddProductBtn.TabIndex = 21;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(38, 31);
            BackBtn.TabIndex = 22;
            BackBtn.Text = "<-";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(146, 166);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(190, 23);
            PriceTextBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 165);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 24;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(23, 200);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 25;
            label5.Text = "Count";
            // 
            // CountNumeric
            // 
            CountNumeric.Location = new Point(146, 200);
            CountNumeric.Name = "CountNumeric";
            CountNumeric.Size = new Size(190, 23);
            CountNumeric.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(23, 233);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 27;
            label6.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(146, 234);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(190, 23);
            DescriptionTextBox.TabIndex = 28;
            // 
            // AddPhotoBtn
            // 
            AddPhotoBtn.Location = new Point(146, 302);
            AddPhotoBtn.Name = "AddPhotoBtn";
            AddPhotoBtn.Size = new Size(187, 23);
            AddPhotoBtn.TabIndex = 30;
            AddPhotoBtn.Text = "Add Photo";
            AddPhotoBtn.UseVisualStyleBackColor = true;
            AddPhotoBtn.Click += AddPhotoBtn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(24, 267);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(117, 95);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 31;
            pictureBox.TabStop = false;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(147, 331);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(187, 23);
            ClearBtn.TabIndex = 32;
            ClearBtn.Text = "Clear Info";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 411);
            Controls.Add(ClearBtn);
            Controls.Add(pictureBox);
            Controls.Add(AddPhotoBtn);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label6);
            Controls.Add(CountNumeric);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PriceTextBox);
            Controls.Add(BackBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(ManufacturerTextBox);
            Controls.Add(NameTextBox);
            Name = "NewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewProduct";
            ((System.ComponentModel.ISupportInitialize)CountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox ManufacturerTextBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button AddProductBtn;
        private Button BackBtn;
        private TextBox PriceTextBox;
        private Label label4;
        private Label label5;
        private NumericUpDown CountNumeric;
        private Label label6;
        private TextBox DescriptionTextBox;
        private Button AddPhotoBtn;
        private PictureBox pictureBox;
        private Button ClearBtn;
    }
}