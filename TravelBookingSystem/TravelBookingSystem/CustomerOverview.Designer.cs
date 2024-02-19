namespace TravelBookingSystem
{
    partial class CustomerOverview
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
            upcomingTripsLabel = new Label();
            myTripsListbox = new ListBox();
            bookingnameTextbox = new TextBox();
            updateTripnameButton = new Button();
            cancelTripButton = new Button();
            destinationLabel = new Label();
            signoutButton = new Button();
            departureLabel = new Label();
            flightnameLabel = new Label();
            dateLabel = new Label();
            countryLabel = new Label();
            hotelLabel = new Label();
            totalPriceLabel = new Label();
            activityLabel = new Label();
            newBookingButton = new Button();
            welcomeLabel = new Label();
            updateListbox = new Button();
            SuspendLayout();
            // 
            // upcomingTripsLabel
            // 
            upcomingTripsLabel.AutoSize = true;
            upcomingTripsLabel.Location = new Point(40, 43);
            upcomingTripsLabel.Name = "upcomingTripsLabel";
            upcomingTripsLabel.Size = new Size(93, 15);
            upcomingTripsLabel.TabIndex = 0;
            upcomingTripsLabel.Text = "Upcoming Trips:";
            // 
            // myTripsListbox
            // 
            myTripsListbox.FormattingEnabled = true;
            myTripsListbox.ItemHeight = 15;
            myTripsListbox.Location = new Point(40, 61);
            myTripsListbox.Name = "myTripsListbox";
            myTripsListbox.Size = new Size(111, 154);
            myTripsListbox.TabIndex = 1;
            myTripsListbox.SelectedIndexChanged += myTripsListbox_SelectedIndexChanged;
            // 
            // bookingnameTextbox
            // 
            bookingnameTextbox.Location = new Point(40, 294);
            bookingnameTextbox.Name = "bookingnameTextbox";
            bookingnameTextbox.PlaceholderText = "Write new tripname";
            bookingnameTextbox.Size = new Size(111, 23);
            bookingnameTextbox.TabIndex = 2;
            // 
            // updateTripnameButton
            // 
            updateTripnameButton.Location = new Point(40, 323);
            updateTripnameButton.Name = "updateTripnameButton";
            updateTripnameButton.Size = new Size(111, 23);
            updateTripnameButton.TabIndex = 3;
            updateTripnameButton.Text = "Update tripname";
            updateTripnameButton.UseVisualStyleBackColor = true;
            updateTripnameButton.Click += updateTripnameButton_Click;
            // 
            // cancelTripButton
            // 
            cancelTripButton.Location = new Point(40, 410);
            cancelTripButton.Name = "cancelTripButton";
            cancelTripButton.Size = new Size(111, 23);
            cancelTripButton.TabIndex = 4;
            cancelTripButton.Text = "Cancel trip...";
            cancelTripButton.UseVisualStyleBackColor = true;
            cancelTripButton.Click += cancelTripButton_Click;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(237, 95);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(38, 15);
            destinationLabel.TabIndex = 5;
            destinationLabel.Text = "label1";
            destinationLabel.Visible = false;
            // 
            // signoutButton
            // 
            signoutButton.Location = new Point(703, 373);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(75, 69);
            signoutButton.TabIndex = 6;
            signoutButton.Text = "Sign out and return to Main Menu";
            signoutButton.UseVisualStyleBackColor = true;
            signoutButton.Click += signoutButton_Click;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new Point(237, 187);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(38, 15);
            departureLabel.TabIndex = 7;
            departureLabel.Text = "label1";
            departureLabel.Visible = false;
            // 
            // flightnameLabel
            // 
            flightnameLabel.AutoSize = true;
            flightnameLabel.Location = new Point(237, 233);
            flightnameLabel.Name = "flightnameLabel";
            flightnameLabel.Size = new Size(38, 15);
            flightnameLabel.TabIndex = 8;
            flightnameLabel.Text = "label1";
            flightnameLabel.Visible = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(237, 278);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "label1";
            dateLabel.Visible = false;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(237, 138);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(38, 15);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "label1";
            countryLabel.Visible = false;
            // 
            // hotelLabel
            // 
            hotelLabel.AutoSize = true;
            hotelLabel.Location = new Point(237, 323);
            hotelLabel.Name = "hotelLabel";
            hotelLabel.Size = new Size(38, 15);
            hotelLabel.TabIndex = 11;
            hotelLabel.Text = "label1";
            hotelLabel.Visible = false;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(237, 418);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(38, 15);
            totalPriceLabel.TabIndex = 12;
            totalPriceLabel.Text = "label1";
            totalPriceLabel.Visible = false;
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Location = new Point(237, 368);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new Size(38, 15);
            activityLabel.TabIndex = 13;
            activityLabel.Text = "label1";
            activityLabel.Visible = false;
            // 
            // newBookingButton
            // 
            newBookingButton.Location = new Point(686, 29);
            newBookingButton.Name = "newBookingButton";
            newBookingButton.Size = new Size(75, 56);
            newBookingButton.TabIndex = 14;
            newBookingButton.Text = "New booking!";
            newBookingButton.UseVisualStyleBackColor = true;
            newBookingButton.Click += newBookingButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = SystemColors.ActiveCaption;
            welcomeLabel.Font = new Font("Segoe UI", 20F);
            welcomeLabel.Location = new Point(237, 21);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(90, 37);
            welcomeLabel.TabIndex = 15;
            welcomeLabel.Text = "label1";
            // 
            // updateListbox
            // 
            updateListbox.Location = new Point(40, 221);
            updateListbox.Name = "updateListbox";
            updateListbox.Size = new Size(111, 41);
            updateListbox.TabIndex = 16;
            updateListbox.Text = "Update my list of trips!";
            updateListbox.UseVisualStyleBackColor = true;
            updateListbox.Click += updateListbox_Click;
            // 
            // CustomerOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Airportpic;
            ClientSize = new Size(800, 450);
            Controls.Add(updateListbox);
            Controls.Add(welcomeLabel);
            Controls.Add(newBookingButton);
            Controls.Add(activityLabel);
            Controls.Add(totalPriceLabel);
            Controls.Add(hotelLabel);
            Controls.Add(countryLabel);
            Controls.Add(dateLabel);
            Controls.Add(flightnameLabel);
            Controls.Add(departureLabel);
            Controls.Add(signoutButton);
            Controls.Add(destinationLabel);
            Controls.Add(cancelTripButton);
            Controls.Add(updateTripnameButton);
            Controls.Add(bookingnameTextbox);
            Controls.Add(myTripsListbox);
            Controls.Add(upcomingTripsLabel);
            Name = "CustomerOverview";
            Text = "CustomerOverview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label upcomingTripsLabel;
        private ListBox myTripsListbox;
        private TextBox bookingnameTextbox;
        private Button updateTripnameButton;
        private Button cancelTripButton;
        private Label destinationLabel;
        private Button signoutButton;
        private Label departureLabel;
        private Label flightnameLabel;
        private Label dateLabel;
        private Label countryLabel;
        private Label hotelLabel;
        private Label totalPriceLabel;
        private Label activityLabel;
        private Button newBookingButton;
        private Label welcomeLabel;
        private Button updateListbox;
    }
}