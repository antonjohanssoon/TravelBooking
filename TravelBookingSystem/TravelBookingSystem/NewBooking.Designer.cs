namespace TravelBookingSystem
{
    partial class NewBooking
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
            newBookingLabel = new Label();
            bookingNameTextbox = new TextBox();
            destinationCombobox = new ComboBox();
            confirmBookingButton = new Button();
            succesfulBookingLabel = new Label();
            overviewButton = new Button();
            departureLabel = new Label();
            dateLabel = new Label();
            hotelLabel = new Label();
            activityCombobox = new ComboBox();
            SuspendLayout();
            // 
            // newBookingLabel
            // 
            newBookingLabel.AutoSize = true;
            newBookingLabel.BackColor = SystemColors.ActiveCaption;
            newBookingLabel.Font = new Font("Segoe UI", 25F);
            newBookingLabel.Location = new Point(300, 25);
            newBookingLabel.Name = "newBookingLabel";
            newBookingLabel.Size = new Size(221, 46);
            newBookingLabel.TabIndex = 0;
            newBookingLabel.Text = "New booking";
            // 
            // bookingNameTextbox
            // 
            bookingNameTextbox.Location = new Point(92, 99);
            bookingNameTextbox.Name = "bookingNameTextbox";
            bookingNameTextbox.PlaceholderText = "Name your booking";
            bookingNameTextbox.Size = new Size(120, 23);
            bookingNameTextbox.TabIndex = 1;
            // 
            // destinationCombobox
            // 
            destinationCombobox.FormattingEnabled = true;
            destinationCombobox.Location = new Point(91, 149);
            destinationCombobox.Name = "destinationCombobox";
            destinationCombobox.Size = new Size(121, 23);
            destinationCombobox.TabIndex = 2;
            destinationCombobox.MouseClick += destinationCombobox_MouseClick;
            // 
            // confirmBookingButton
            // 
            confirmBookingButton.Location = new Point(377, 345);
            confirmBookingButton.Name = "confirmBookingButton";
            confirmBookingButton.Size = new Size(75, 54);
            confirmBookingButton.TabIndex = 7;
            confirmBookingButton.Text = "Confirm booking!";
            confirmBookingButton.UseVisualStyleBackColor = true;
            confirmBookingButton.Click += confirmBookingButton_Click;
            // 
            // succesfulBookingLabel
            // 
            succesfulBookingLabel.AutoSize = true;
            succesfulBookingLabel.Location = new Point(377, 415);
            succesfulBookingLabel.Name = "succesfulBookingLabel";
            succesfulBookingLabel.Size = new Size(38, 15);
            succesfulBookingLabel.TabIndex = 8;
            succesfulBookingLabel.Text = "label1";
            succesfulBookingLabel.Visible = false;
            // 
            // overviewButton
            // 
            overviewButton.Location = new Point(692, 376);
            overviewButton.Name = "overviewButton";
            overviewButton.Size = new Size(75, 54);
            overviewButton.TabIndex = 10;
            overviewButton.Text = "View my trips";
            overviewButton.UseVisualStyleBackColor = true;
            overviewButton.Click += overviewButton_Click;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new Point(91, 222);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(38, 15);
            departureLabel.TabIndex = 11;
            departureLabel.Text = "label1";
            departureLabel.Visible = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(92, 285);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 12;
            dateLabel.Text = "label1";
            dateLabel.Visible = false;
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Location = new Point(91, 345);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(38, 15);
            hotelLabel.TabIndex = 13;
            hotelLabel.Text = "label1";
            hotelLabel.Visible = false;
            // 
            // activityCombobox
            // 
            activityCombobox.FormattingEnabled = true;
            activityCombobox.Location = new Point(91, 407);
            activityCombobox.Name = "activityCombobox";
            activityCombobox.Size = new Size(121, 23);
            activityCombobox.TabIndex = 15;
            // 
            // NewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pyramids;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(activityCombobox);
            Controls.Add(hotelLabel);
            Controls.Add(dateLabel);
            Controls.Add(departureLabel);
            Controls.Add(overviewButton);
            Controls.Add(succesfulBookingLabel);
            Controls.Add(confirmBookingButton);
            Controls.Add(destinationCombobox);
            Controls.Add(bookingNameTextbox);
            Controls.Add(newBookingLabel);
            Name = "NewBooking";
            Text = "NewBooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newBookingLabel;
        private TextBox bookingNameTextbox;
        private ComboBox destinationCombobox;
        private Button confirmBookingButton;
        private Label succesfulBookingLabel;
        private Button overviewButton;
        private Label departureLabel;
        private Label dateLabel;
        private Label hotelLabel;
        private ComboBox activityCombobox;
    }
}