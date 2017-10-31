namespace Assignment
{
    partial class MenuForm
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
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.ManageProfilesButton = new System.Windows.Forms.Button();
            this.TargetScore = new System.Windows.Forms.NumericUpDown();
            this.TargetScoreLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Player1Select = new System.Windows.Forms.ListBox();
            this.Player2Select = new System.Windows.Forms.ListBox();
            this.RulesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TargetScore)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(12, 43);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(45, 13);
            this.Player1Label.TabIndex = 1;
            this.Player1Label.Text = "Player 1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(152, 43);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(45, 13);
            this.Player2Label.TabIndex = 3;
            this.Player2Label.Text = "Player 2";
            // 
            // ManageProfilesButton
            // 
            this.ManageProfilesButton.Location = new System.Drawing.Point(95, 162);
            this.ManageProfilesButton.Name = "ManageProfilesButton";
            this.ManageProfilesButton.Size = new System.Drawing.Size(102, 23);
            this.ManageProfilesButton.TabIndex = 4;
            this.ManageProfilesButton.Text = "Manage Profiles...";
            this.ManageProfilesButton.UseVisualStyleBackColor = true;
            this.ManageProfilesButton.Click += new System.EventHandler(this.ManageProfilesButton_Click);
            // 
            // TargetScore
            // 
            this.TargetScore.Location = new System.Drawing.Point(170, 207);
            this.TargetScore.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(38, 20);
            this.TargetScore.TabIndex = 5;
            this.TargetScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TargetScore.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TargetScoreLabel
            // 
            this.TargetScoreLabel.AutoSize = true;
            this.TargetScoreLabel.Location = new System.Drawing.Point(92, 209);
            this.TargetScoreLabel.Name = "TargetScoreLabel";
            this.TargetScoreLabel.Size = new System.Drawing.Size(69, 13);
            this.TargetScoreLabel.TabIndex = 6;
            this.TargetScoreLabel.Text = "Target Score";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(78, 239);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(140, 44);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Player1Select
            // 
            this.Player1Select.FormattingEnabled = true;
            this.Player1Select.Items.AddRange(new object[] {
            "Guest"});
            this.Player1Select.Location = new System.Drawing.Point(15, 61);
            this.Player1Select.Name = "Player1Select";
            this.Player1Select.Size = new System.Drawing.Size(120, 95);
            this.Player1Select.TabIndex = 8;
            // 
            // Player2Select
            // 
            this.Player2Select.FormattingEnabled = true;
            this.Player2Select.Items.AddRange(new object[] {
            "Guest"});
            this.Player2Select.Location = new System.Drawing.Point(155, 61);
            this.Player2Select.Name = "Player2Select";
            this.Player2Select.Size = new System.Drawing.Size(120, 95);
            this.Player2Select.TabIndex = 9;
            // 
            // RulesButton
            // 
            this.RulesButton.Location = new System.Drawing.Point(200, 12);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(75, 23);
            this.RulesButton.TabIndex = 10;
            this.RulesButton.Text = "Rules...";
            this.RulesButton.UseVisualStyleBackColor = true;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.Player2Select);
            this.Controls.Add(this.Player1Select);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TargetScoreLabel);
            this.Controls.Add(this.TargetScore);
            this.Controls.Add(this.ManageProfilesButton);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.TargetScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Button ManageProfilesButton;
        private System.Windows.Forms.NumericUpDown TargetScore;
        private System.Windows.Forms.Label TargetScoreLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ListBox Player1Select;
        private System.Windows.Forms.ListBox Player2Select;
        private System.Windows.Forms.Button RulesButton;
    }
}