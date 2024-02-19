namespace TravelBookingSystem
{
    partial class CustomerLogin
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
            signinCustomerLabel = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            backToMainMenuButton = new Button();
            signinButton = new Button();
            SuspendLayout();
            // 
            // signinCustomerLabel
            // 
            signinCustomerLabel.AutoSize = true;
            signinCustomerLabel.BackColor = SystemColors.ActiveCaption;
            signinCustomerLabel.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinCustomerLabel.Location = new Point(242, 56);
            signinCustomerLabel.Name = "signinCustomerLabel";
            signinCustomerLabel.Size = new Size(303, 45);
            signinCustomerLabel.TabIndex = 0;
            signinCustomerLabel.Text = "Sign in as customer";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(341, 187);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Username";
            usernameTextbox.Size = new Size(100, 23);
            usernameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(341, 252);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '•';
            passwordTextbox.PlaceholderText = "Password";
            passwordTextbox.Size = new Size(100, 23);
            passwordTextbox.TabIndex = 2;
            // 
            // backToMainMenuButton
            // 
            backToMainMenuButton.Location = new Point(694, 383);
            backToMainMenuButton.Name = "backToMainMenuButton";
            backToMainMenuButton.Size = new Size(75, 55);
            backToMainMenuButton.TabIndex = 3;
            backToMainMenuButton.Text = "Return to Main Menu";
            backToMainMenuButton.UseVisualStyleBackColor = true;
            backToMainMenuButton.Click += backToMainMenuButton_Click;
            // 
            // signinButton
            // 
            signinButton.Location = new Point(341, 321);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(100, 23);
            signinButton.TabIndex = 4;
            signinButton.Text = "Sign in!";
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += signinButton_Click;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.louis_magnotti_YvCg5X3pWzc_unsplash_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(signinButton);
            Controls.Add(backToMainMenuButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(signinCustomerLabel);
            Name = "CustomerLogin";
            Text = "CustomerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signinCustomerLabel;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button backToMainMenuButton;
        private Button signinButton;
    }
}