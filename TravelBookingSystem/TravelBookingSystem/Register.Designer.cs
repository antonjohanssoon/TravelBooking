namespace TravelBookingSystem
{
    partial class Register
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
            registerLabel = new Label();
            firstnameTextbox = new TextBox();
            surnameTextbox = new TextBox();
            emailTextbox = new TextBox();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            ageUpDown = new NumericUpDown();
            ageLabel = new Label();
            mainmenuButton = new Button();
            succesfulregisterLabel = new Label();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageUpDown).BeginInit();
            SuspendLayout();
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = SystemColors.ActiveCaption;
            registerLabel.Font = new Font("Segoe UI", 25F);
            registerLabel.Location = new Point(218, 36);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(361, 46);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Register new customer";
            // 
            // firstnameTextbox
            // 
            firstnameTextbox.Location = new Point(218, 138);
            firstnameTextbox.Name = "firstnameTextbox";
            firstnameTextbox.PlaceholderText = "First name";
            firstnameTextbox.Size = new Size(100, 23);
            firstnameTextbox.TabIndex = 1;
            // 
            // surnameTextbox
            // 
            surnameTextbox.Location = new Point(218, 219);
            surnameTextbox.Name = "surnameTextbox";
            surnameTextbox.PlaceholderText = "Sur name";
            surnameTextbox.Size = new Size(100, 23);
            surnameTextbox.TabIndex = 2;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(218, 353);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.PlaceholderText = "Email";
            emailTextbox.Size = new Size(216, 23);
            emailTextbox.TabIndex = 3;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(513, 138);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Username";
            usernameTextbox.Size = new Size(100, 23);
            usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(513, 219);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Password";
            passwordTextbox.Size = new Size(100, 23);
            passwordTextbox.TabIndex = 5;
            // 
            // ageUpDown
            // 
            ageUpDown.Location = new Point(257, 289);
            ageUpDown.Name = "ageUpDown";
            ageUpDown.Size = new Size(51, 23);
            ageUpDown.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = SystemColors.ActiveCaption;
            ageLabel.Location = new Point(223, 291);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(28, 15);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age";
            // 
            // mainmenuButton
            // 
            mainmenuButton.Location = new Point(696, 383);
            mainmenuButton.Name = "mainmenuButton";
            mainmenuButton.Size = new Size(75, 55);
            mainmenuButton.TabIndex = 8;
            mainmenuButton.Text = "Return to Main Menu";
            mainmenuButton.UseVisualStyleBackColor = true;
            mainmenuButton.Click += mainmenuButton_Click;
            // 
            // succesfulregisterLabel
            // 
            succesfulregisterLabel.AutoSize = true;
            succesfulregisterLabel.Location = new Point(513, 361);
            succesfulregisterLabel.Name = "succesfulregisterLabel";
            succesfulregisterLabel.Size = new Size(38, 15);
            succesfulregisterLabel.TabIndex = 9;
            succesfulregisterLabel.Text = "label1";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(513, 270);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(100, 42);
            registerButton.TabIndex = 10;
            registerButton.Text = "Register new customer!";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BoardingPass;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(succesfulregisterLabel);
            Controls.Add(mainmenuButton);
            Controls.Add(ageLabel);
            Controls.Add(ageUpDown);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(surnameTextbox);
            Controls.Add(firstnameTextbox);
            Controls.Add(registerLabel);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)ageUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLabel;
        private TextBox firstnameTextbox;
        private TextBox surnameTextbox;
        private TextBox emailTextbox;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private NumericUpDown ageUpDown;
        private Label ageLabel;
        private Button mainmenuButton;
        private Label succesfulregisterLabel;
        private Button registerButton;

    }
}