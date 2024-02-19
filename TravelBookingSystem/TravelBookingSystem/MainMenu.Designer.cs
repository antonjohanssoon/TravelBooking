namespace TravelBookingSystem
{
    partial class MainMenu
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
            mainMenuLabel = new Label();
            dreamtripLabel = new Label();
            registerButton = new Button();
            signInButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Segoe UI", 25F);
            mainMenuLabel.Location = new Point(92, 66);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(645, 46);
            mainMenuLabel.TabIndex = 0;
            mainMenuLabel.Text = "Welcome to Swedish Super Travel Boking!";
            // 
            // dreamtripLabel
            // 
            dreamtripLabel.AutoSize = true;
            dreamtripLabel.Font = new Font("Segoe UI", 18F);
            dreamtripLabel.Location = new Point(246, 127);
            dreamtripLabel.Name = "dreamtripLabel";
            dreamtripLabel.Size = new Size(305, 32);
            dreamtripLabel.TabIndex = 1;
            dreamtripLabel.Text = "Your dreamtrip starts here...";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(246, 256);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(476, 256);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(75, 23);
            signInButton.TabIndex = 3;
            signInButton.Text = "Sign in!";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(697, 391);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 47);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.TravelBooking;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(quitButton);
            Controls.Add(signInButton);
            Controls.Add(registerButton);
            Controls.Add(dreamtripLabel);
            Controls.Add(mainMenuLabel);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainMenuLabel;
        private Label dreamtripLabel;
        private Button registerButton;
        private Button signInButton;
        private Button quitButton;
    }
}