namespace CatalogProd
{
    partial class MainForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddProductBtn = new Button();
            CountProducts = new Label();
            ManufacturerComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            SortComboBox = new ComboBox();
            BackBtn = new Button();
            NextBtn = new Button();
            NowPageLabel = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(25, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(638, 313);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(539, 17);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(136, 29);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "Добавить товар";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // CountProducts
            // 
            CountProducts.AutoSize = true;
            CountProducts.Location = new Point(34, 57);
            CountProducts.Name = "CountProducts";
            CountProducts.Size = new Size(38, 15);
            CountProducts.TabIndex = 1;
            CountProducts.Text = "label1";
            // 
            // ManufacturerComboBox
            // 
            ManufacturerComboBox.FormattingEnabled = true;
            ManufacturerComboBox.Location = new Point(34, 21);
            ManufacturerComboBox.Name = "ManufacturerComboBox";
            ManufacturerComboBox.Size = new Size(121, 23);
            ManufacturerComboBox.TabIndex = 2;
            ManufacturerComboBox.SelectedIndexChanged += ManufacturerComboBox_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(360, 21);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(165, 23);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Не сортировать", "Сортировать по имени (возрастание)", "Сортировать по имени (убывание)", "Сортировать по цене (возрастание)", "Сортировать по цене (убывание)", "Сортировать по количеству (возрастание)", "Сортировать по количеству (убывание)" });
            SortComboBox.Location = new Point(171, 21);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(173, 23);
            SortComboBox.TabIndex = 4;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(135, 415);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(124, 23);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(375, 415);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(124, 23);
            NextBtn.TabIndex = 6;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // NowPageLabel
            // 
            NowPageLabel.AutoSize = true;
            NowPageLabel.Location = new Point(265, 419);
            NowPageLabel.Name = "NowPageLabel";
            NowPageLabel.Size = new Size(38, 15);
            NowPageLabel.TabIndex = 7;
            NowPageLabel.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(NowPageLabel);
            Controls.Add(NextBtn);
            Controls.Add(BackBtn);
            Controls.Add(SortComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(ManufacturerComboBox);
            Controls.Add(CountProducts);
            Controls.Add(AddProductBtn);
            Controls.Add(flowLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddProductBtn;
        private Label CountProducts;
        private ComboBox ManufacturerComboBox;
        private TextBox SearchTextBox;
        private ComboBox SortComboBox;
        private Button BackBtn;
        private Button NextBtn;
        private Label NowPageLabel;
    }
}
