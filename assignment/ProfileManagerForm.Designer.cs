namespace Assignment
{
    partial class ProfileManagerForm
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
            this.ProfilesListBox = new System.Windows.Forms.ListBox();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.PlaysLabel = new System.Windows.Forms.Label();
            this.WinsLabel = new System.Windows.Forms.Label();
            this.LossesLabel = new System.Windows.Forms.Label();
            this.TwoKindLabel = new System.Windows.Forms.Label();
            this.ThreeKindLabel = new System.Windows.Forms.Label();
            this.FourKindLabel = new System.Windows.Forms.Label();
            this.FiveKindLabel = new System.Windows.Forms.Label();
            this.PlaysVal = new System.Windows.Forms.Label();
            this.WinsVal = new System.Windows.Forms.Label();
            this.LossesVal = new System.Windows.Forms.Label();
            this.TwoKindVal = new System.Windows.Forms.Label();
            this.ThreeKindVal = new System.Windows.Forms.Label();
            this.FourKindVal = new System.Windows.Forms.Label();
            this.FiveKindVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfilesListBox
            // 
            this.ProfilesListBox.FormattingEnabled = true;
            this.ProfilesListBox.Location = new System.Drawing.Point(12, 12);
            this.ProfilesListBox.Name = "ProfilesListBox";
            this.ProfilesListBox.Size = new System.Drawing.Size(125, 173);
            this.ProfilesListBox.TabIndex = 0;
            this.ProfilesListBox.SelectedIndexChanged += new System.EventHandler(this.ProfilesListBox_SelectedIndexChanged);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(12, 192);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(125, 23);
            this.CreateNewButton.TabIndex = 1;
            this.CreateNewButton.Text = "Create New Profile...";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Location = new System.Drawing.Point(12, 221);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(125, 23);
            this.DeleteProfileButton.TabIndex = 2;
            this.DeleteProfileButton.Text = "Delete Profile...";
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // PlaysLabel
            // 
            this.PlaysLabel.AutoSize = true;
            this.PlaysLabel.Location = new System.Drawing.Point(143, 12);
            this.PlaysLabel.Name = "PlaysLabel";
            this.PlaysLabel.Size = new System.Drawing.Size(38, 13);
            this.PlaysLabel.TabIndex = 3;
            this.PlaysLabel.Text = "Plays: ";
            // 
            // WinsLabel
            // 
            this.WinsLabel.AutoSize = true;
            this.WinsLabel.Location = new System.Drawing.Point(143, 34);
            this.WinsLabel.Name = "WinsLabel";
            this.WinsLabel.Size = new System.Drawing.Size(37, 13);
            this.WinsLabel.TabIndex = 4;
            this.WinsLabel.Text = "Wins: ";
            // 
            // LossesLabel
            // 
            this.LossesLabel.AutoSize = true;
            this.LossesLabel.Location = new System.Drawing.Point(143, 58);
            this.LossesLabel.Name = "LossesLabel";
            this.LossesLabel.Size = new System.Drawing.Size(46, 13);
            this.LossesLabel.TabIndex = 5;
            this.LossesLabel.Text = "Losses: ";
            // 
            // TwoKindLabel
            // 
            this.TwoKindLabel.AutoSize = true;
            this.TwoKindLabel.Location = new System.Drawing.Point(143, 82);
            this.TwoKindLabel.Name = "TwoKindLabel";
            this.TwoKindLabel.Size = new System.Drawing.Size(68, 13);
            this.TwoKindLabel.TabIndex = 6;
            this.TwoKindLabel.Text = "2-of-a-kinds: ";
            // 
            // ThreeKindLabel
            // 
            this.ThreeKindLabel.AutoSize = true;
            this.ThreeKindLabel.Location = new System.Drawing.Point(143, 107);
            this.ThreeKindLabel.Name = "ThreeKindLabel";
            this.ThreeKindLabel.Size = new System.Drawing.Size(68, 13);
            this.ThreeKindLabel.TabIndex = 7;
            this.ThreeKindLabel.Text = "3-of-a-kinds: ";
            // 
            // FourKindLabel
            // 
            this.FourKindLabel.AutoSize = true;
            this.FourKindLabel.Location = new System.Drawing.Point(143, 132);
            this.FourKindLabel.Name = "FourKindLabel";
            this.FourKindLabel.Size = new System.Drawing.Size(68, 13);
            this.FourKindLabel.TabIndex = 8;
            this.FourKindLabel.Text = "4-of-a-kinds: ";
            // 
            // FiveKindLabel
            // 
            this.FiveKindLabel.AutoSize = true;
            this.FiveKindLabel.Location = new System.Drawing.Point(143, 156);
            this.FiveKindLabel.Name = "FiveKindLabel";
            this.FiveKindLabel.Size = new System.Drawing.Size(68, 13);
            this.FiveKindLabel.TabIndex = 9;
            this.FiveKindLabel.Text = "5-of-a-kinds: ";
            // 
            // PlaysVal
            // 
            this.PlaysVal.AutoSize = true;
            this.PlaysVal.Location = new System.Drawing.Point(237, 12);
            this.PlaysVal.Name = "PlaysVal";
            this.PlaysVal.Size = new System.Drawing.Size(13, 13);
            this.PlaysVal.TabIndex = 10;
            this.PlaysVal.Text = "0";
            // 
            // WinsVal
            // 
            this.WinsVal.AutoSize = true;
            this.WinsVal.Location = new System.Drawing.Point(237, 34);
            this.WinsVal.Name = "WinsVal";
            this.WinsVal.Size = new System.Drawing.Size(13, 13);
            this.WinsVal.TabIndex = 11;
            this.WinsVal.Text = "0";
            // 
            // LossesVal
            // 
            this.LossesVal.AutoSize = true;
            this.LossesVal.Location = new System.Drawing.Point(237, 58);
            this.LossesVal.Name = "LossesVal";
            this.LossesVal.Size = new System.Drawing.Size(13, 13);
            this.LossesVal.TabIndex = 12;
            this.LossesVal.Text = "0";
            // 
            // TwoKindVal
            // 
            this.TwoKindVal.AutoSize = true;
            this.TwoKindVal.Location = new System.Drawing.Point(237, 82);
            this.TwoKindVal.Name = "TwoKindVal";
            this.TwoKindVal.Size = new System.Drawing.Size(13, 13);
            this.TwoKindVal.TabIndex = 13;
            this.TwoKindVal.Text = "0";
            // 
            // ThreeKindVal
            // 
            this.ThreeKindVal.AutoSize = true;
            this.ThreeKindVal.Location = new System.Drawing.Point(237, 107);
            this.ThreeKindVal.Name = "ThreeKindVal";
            this.ThreeKindVal.Size = new System.Drawing.Size(13, 13);
            this.ThreeKindVal.TabIndex = 14;
            this.ThreeKindVal.Text = "0";
            // 
            // FourKindVal
            // 
            this.FourKindVal.AutoSize = true;
            this.FourKindVal.Location = new System.Drawing.Point(237, 132);
            this.FourKindVal.Name = "FourKindVal";
            this.FourKindVal.Size = new System.Drawing.Size(13, 13);
            this.FourKindVal.TabIndex = 15;
            this.FourKindVal.Text = "0";
            // 
            // FiveKindVal
            // 
            this.FiveKindVal.AutoSize = true;
            this.FiveKindVal.Location = new System.Drawing.Point(237, 156);
            this.FiveKindVal.Name = "FiveKindVal";
            this.FiveKindVal.Size = new System.Drawing.Size(13, 13);
            this.FiveKindVal.TabIndex = 16;
            this.FiveKindVal.Text = "0";
            // 
            // ProfileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FiveKindVal);
            this.Controls.Add(this.FourKindVal);
            this.Controls.Add(this.ThreeKindVal);
            this.Controls.Add(this.TwoKindVal);
            this.Controls.Add(this.LossesVal);
            this.Controls.Add(this.WinsVal);
            this.Controls.Add(this.PlaysVal);
            this.Controls.Add(this.FiveKindLabel);
            this.Controls.Add(this.FourKindLabel);
            this.Controls.Add(this.ThreeKindLabel);
            this.Controls.Add(this.TwoKindLabel);
            this.Controls.Add(this.LossesLabel);
            this.Controls.Add(this.WinsLabel);
            this.Controls.Add(this.PlaysLabel);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.ProfilesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileManagerForm";
            this.Text = "Profile Manager";
            this.Load += new System.EventHandler(this.ProfileManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProfilesListBox;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Label PlaysLabel;
        private System.Windows.Forms.Label WinsLabel;
        private System.Windows.Forms.Label LossesLabel;
        private System.Windows.Forms.Label TwoKindLabel;
        private System.Windows.Forms.Label ThreeKindLabel;
        private System.Windows.Forms.Label FourKindLabel;
        private System.Windows.Forms.Label FiveKindLabel;
        private System.Windows.Forms.Label PlaysVal;
        private System.Windows.Forms.Label WinsVal;
        private System.Windows.Forms.Label LossesVal;
        private System.Windows.Forms.Label TwoKindVal;
        private System.Windows.Forms.Label ThreeKindVal;
        private System.Windows.Forms.Label FourKindVal;
        private System.Windows.Forms.Label FiveKindVal;
    }
}