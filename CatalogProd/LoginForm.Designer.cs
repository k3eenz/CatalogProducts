namespace CatalogProd
{
    partial class LoginForm
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
            RegisterBtn = new Button();
            LoginBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(22, 245);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(314, 31);
            RegisterBtn.TabIndex = 21;
            RegisterBtn.Text = "Don't have an account? Sign up";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(100, 208);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(163, 31);
            LoginBtn.TabIndex = 20;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 157);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 47);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 17;
            label1.Text = "Login to your account";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(125, 158);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(211, 23);
            PasswordTextBox.TabIndex = 16;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(125, 114);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(211, 23);
            UserNameTextBox.TabIndex = 15;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 411);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Button LoginBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox UserNameTextBox;
    }
}