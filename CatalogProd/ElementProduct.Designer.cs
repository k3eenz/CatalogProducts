namespace CatalogProd
{
    partial class ElementProduct
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            descriptionTextBox = new Label();
            priceLabel = new Label();
            manufacturerLabel = new Label();
            nameLabel = new Label();
            panel2 = new Panel();
            countLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(manufacturerLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(147, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 108);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.AutoSize = true;
            descriptionTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionTextBox.Location = new Point(3, 80);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(43, 17);
            descriptionTextBox.TabIndex = 6;
            descriptionTextBox.Text = "label4";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceLabel.Location = new Point(3, 53);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(52, 21);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "label3";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            manufacturerLabel.Location = new Point(3, 27);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(50, 20);
            manufacturerLabel.TabIndex = 4;
            manufacturerLabel.Text = "label2";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 21);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(countLabel);
            panel2.Location = new Point(463, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 108);
            panel2.TabIndex = 2;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countLabel.Location = new Point(45, 26);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(52, 21);
            countLabel.TabIndex = 7;
            countLabel.Text = "label5";
            // 
            // ElementProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "ElementProduct";
            Size = new Size(609, 114);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label descriptionTextBox;
        private Label priceLabel;
        private Label manufacturerLabel;
        private Label nameLabel;
        private Panel panel2;
        private Label countLabel;
    }
}
