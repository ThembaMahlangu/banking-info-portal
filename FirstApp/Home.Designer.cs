namespace FirstApp
{
    partial class Home
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
            customerTable = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            searchButton = new Button();
            searchField = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            firstName = new TextBox();
            lastName = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            address = new TextBox();
            city = new TextBox();
            accountNumber = new TextBox();
            accountType = new TextBox();
            dateJoined = new TextBox();
            updateButton = new Button();
            deleteButton = new Button();
            customerBalance = new TextBox();
            panel1 = new Panel();
            panel4 = new Panel();
            logoutButton = new PictureBox();
            lastLoginLabel = new Label();
            registrationDateLabel = new Label();
            usernameLabel = new Label();
            roleLabel = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            NameLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedImage1 = new RoundedImage();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)customerTable).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoutButton).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedImage1).BeginInit();
            SuspendLayout();
            // 
            // customerTable
            // 
            customerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerTable.BackgroundColor = SystemColors.ScrollBar;
            customerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerTable.Location = new Point(353, 48);
            customerTable.Name = "customerTable";
            customerTable.RowHeadersWidth = 62;
            customerTable.Size = new Size(904, 317);
            customerTable.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(696, 7);
            label3.Name = "label3";
            label3.Size = new Size(296, 38);
            label3.TabIndex = 2;
            label3.Text = "Bank Customer Details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(searchField);
            groupBox1.Font = new Font("Segoe UI", 7F);
            groupBox1.Location = new Point(892, 371);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 87);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by Name and Account No.";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Cyan;
            searchButton.Font = new Font("Segoe UI", 7F);
            searchButton.ForeColor = SystemColors.ActiveCaptionText;
            searchButton.Location = new Point(266, 34);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(72, 32);
            searchButton.TabIndex = 26;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchField
            // 
            searchField.Location = new Point(27, 36);
            searchField.Name = "searchField";
            searchField.PlaceholderText = "Type Here...";
            searchField.Size = new Size(233, 26);
            searchField.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F);
            label4.Location = new Point(360, 381);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6F);
            label5.Location = new Point(361, 417);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F);
            label6.Location = new Point(361, 454);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F);
            label7.Location = new Point(361, 495);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 7;
            label7.Text = "Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F);
            label8.Location = new Point(361, 535);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 8;
            label8.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6F);
            label9.Location = new Point(360, 575);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 9;
            label9.Text = "City:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6F);
            label10.Location = new Point(630, 381);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 10;
            label10.Text = "Account No.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 6F);
            label11.Location = new Point(630, 418);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 11;
            label11.Text = "Account Type:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 6F);
            label12.Location = new Point(630, 461);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 12;
            label12.Text = "Date Joined:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F);
            label13.Location = new Point(630, 505);
            label13.Name = "label13";
            label13.Size = new Size(138, 21);
            label13.TabIndex = 13;
            label13.Text = "Customer Balance:";
            // 
            // firstName
            // 
            firstName.Location = new Point(433, 370);
            firstName.Margin = new Padding(3, 2, 2, 3);
            firstName.Name = "firstName";
            firstName.Size = new Size(173, 31);
            firstName.TabIndex = 15;
            // 
            // lastName
            // 
            lastName.Location = new Point(433, 406);
            lastName.Margin = new Padding(3, 2, 2, 3);
            lastName.Name = "lastName";
            lastName.Size = new Size(173, 31);
            lastName.TabIndex = 16;
            // 
            // email
            // 
            email.Location = new Point(433, 443);
            email.Margin = new Padding(3, 2, 2, 3);
            email.Name = "email";
            email.Size = new Size(173, 31);
            email.TabIndex = 17;
            // 
            // phone
            // 
            phone.Location = new Point(433, 484);
            phone.Margin = new Padding(3, 2, 2, 3);
            phone.Name = "phone";
            phone.Size = new Size(173, 31);
            phone.TabIndex = 18;
            // 
            // address
            // 
            address.Location = new Point(433, 524);
            address.Margin = new Padding(3, 2, 2, 3);
            address.Name = "address";
            address.Size = new Size(173, 31);
            address.TabIndex = 19;
            // 
            // city
            // 
            city.Location = new Point(433, 564);
            city.Margin = new Padding(3, 2, 2, 3);
            city.Name = "city";
            city.Size = new Size(173, 31);
            city.TabIndex = 20;
            // 
            // accountNumber
            // 
            accountNumber.Location = new Point(714, 370);
            accountNumber.Margin = new Padding(3, 2, 2, 3);
            accountNumber.Name = "accountNumber";
            accountNumber.Size = new Size(173, 31);
            accountNumber.TabIndex = 21;
            // 
            // accountType
            // 
            accountType.Location = new Point(714, 407);
            accountType.Margin = new Padding(3, 2, 2, 3);
            accountType.Name = "accountType";
            accountType.Size = new Size(173, 31);
            accountType.TabIndex = 22;
            // 
            // dateJoined
            // 
            dateJoined.Location = new Point(714, 450);
            dateJoined.Margin = new Padding(3, 2, 2, 3);
            dateJoined.Name = "dateJoined";
            dateJoined.Size = new Size(173, 31);
            dateJoined.TabIndex = 23;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkBlue;
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(892, 547);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(132, 43);
            updateButton.TabIndex = 24;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(1043, 547);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(132, 43);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // customerBalance
            // 
            customerBalance.BackColor = Color.LightGray;
            customerBalance.BorderStyle = BorderStyle.None;
            customerBalance.Location = new Point(774, 502);
            customerBalance.Name = "customerBalance";
            customerBalance.Size = new Size(113, 24);
            customerBalance.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 90);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 607);
            panel1.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(logoutButton);
            panel4.Controls.Add(lastLoginLabel);
            panel4.Controls.Add(registrationDateLabel);
            panel4.Controls.Add(usernameLabel);
            panel4.Controls.Add(roleLabel);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 283);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 324);
            panel4.TabIndex = 30;
            // 
            // logoutButton
            // 
            logoutButton.Image = Properties.Resources.pngtree_vector_logout_icon_png_image_958608_removebg_preview;
            logoutButton.Location = new Point(12, 275);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(38, 37);
            logoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            logoutButton.TabIndex = 11;
            logoutButton.TabStop = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // lastLoginLabel
            // 
            lastLoginLabel.AutoSize = true;
            lastLoginLabel.Font = new Font("Segoe UI", 10F);
            lastLoginLabel.ForeColor = Color.DarkGray;
            lastLoginLabel.Location = new Point(143, 167);
            lastLoginLabel.Name = "lastLoginLabel";
            lastLoginLabel.Size = new Size(195, 28);
            lastLoginLabel.TabIndex = 10;
            lastLoginLabel.Text = "2024-07-06 15:30:00";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Font = new Font("Segoe UI", 10F);
            registrationDateLabel.ForeColor = Color.DarkGray;
            registrationDateLabel.Location = new Point(143, 127);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(195, 28);
            registrationDateLabel.TabIndex = 9;
            registrationDateLabel.Text = "2021-02-14 10:30:00";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10F);
            usernameLabel.ForeColor = Color.DarkGray;
            usernameLabel.Location = new Point(143, 85);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(106, 28);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "tmahlangu";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 10F);
            roleLabel.ForeColor = Color.DarkGray;
            roleLabel.Location = new Point(143, 44);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(126, 28);
            roleLabel.TabIndex = 7;
            roleLabel.Text = "Super Admin";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(32, 167);
            label16.Name = "label16";
            label16.Size = new Size(105, 28);
            label16.TabIndex = 6;
            label16.Text = "Last login :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(12, 127);
            label15.Name = "label15";
            label15.Size = new Size(124, 28);
            label15.TabIndex = 5;
            label15.Text = "Date Joined :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(29, 85);
            label14.Name = "label14";
            label14.Size = new Size(108, 28);
            label14.TabIndex = 4;
            label14.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 44);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Role :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(NameLabel);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 119);
            panel3.TabIndex = 29;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10F);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(143, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(175, 28);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Themba Mahlangu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 3;
            label1.Text = "Welcome,";
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedImage1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 195);
            panel2.TabIndex = 28;
            // 
            // roundedImage1
            // 
            roundedImage1.CornerRadius = 20;
            roundedImage1.Image = Properties.Resources.profile_default_male;
            roundedImage1.Location = new Point(99, 41);
            roundedImage1.Name = "roundedImage1";
            roundedImage1.Size = new Size(150, 154);
            roundedImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedImage1.TabIndex = 0;
            roundedImage1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(741, 547);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 28;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 607);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(customerBalance);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(dateJoined);
            Controls.Add(accountType);
            Controls.Add(accountNumber);
            Controls.Add(city);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(customerTable);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Details";
            ((System.ComponentModel.ISupportInitialize)customerTable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoutButton).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundedImage1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView customerTable;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox searchField;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox email;
        private TextBox phone;
        private TextBox address;
        private TextBox city;
        private TextBox accountNumber;
        private TextBox accountType;
        private TextBox dateJoined;
        private Button updateButton;
        private Button deleteButton;
        private Button searchButton;
        private TextBox customerBalance;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label2;
        private Label lastLoginLabel;
        private Label registrationDateLabel;
        private Label usernameLabel;
        private Label roleLabel;
        private PictureBox logoutButton;
        private Label NameLabel;
        private RoundedImage roundedImage1;
        private Button button1;
    }
}