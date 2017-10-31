namespace Assignment
{
    partial class GameForm
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
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Player1RollButton = new System.Windows.Forms.Button();
            this.Player1ScoreText = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.Player2ScoreText = new System.Windows.Forms.Label();
            this.TurnText = new System.Windows.Forms.Label();
            this.Player2RollButton = new System.Windows.Forms.Button();
            this.RollResultsBeginning = new System.Windows.Forms.Label();
            this.RollResults = new System.Windows.Forms.Label();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.RollHistoryListBox = new System.Windows.Forms.ListBox();
            this.RollHistoryLabel = new System.Windows.Forms.Label();
            this.rollOnce = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 37);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Output.Size = new System.Drawing.Size(260, 62);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // Player1RollButton
            // 
            this.Player1RollButton.Location = new System.Drawing.Point(15, 303);
            this.Player1RollButton.Name = "Player1RollButton";
            this.Player1RollButton.Size = new System.Drawing.Size(112, 37);
            this.Player1RollButton.TabIndex = 1;
            this.Player1RollButton.Text = "Player 1 Roll";
            this.Player1RollButton.UseVisualStyleBackColor = true;
            this.Player1RollButton.Click += new System.EventHandler(this.Player1RollButton_Click);
            // 
            // Player1ScoreText
            // 
            this.Player1ScoreText.AutoSize = true;
            this.Player1ScoreText.Location = new System.Drawing.Point(12, 254);
            this.Player1ScoreText.Name = "Player1ScoreText";
            this.Player1ScoreText.Size = new System.Drawing.Size(86, 13);
            this.Player1ScoreText.TabIndex = 2;
            this.Player1ScoreText.Text = "Player 1\'s Score:";
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Location = new System.Drawing.Point(12, 276);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(25, 13);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "000";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Location = new System.Drawing.Point(247, 276);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(25, 13);
            this.Player2Score.TabIndex = 5;
            this.Player2Score.Text = "000";
            // 
            // Player2ScoreText
            // 
            this.Player2ScoreText.AutoSize = true;
            this.Player2ScoreText.Location = new System.Drawing.Point(186, 254);
            this.Player2ScoreText.Name = "Player2ScoreText";
            this.Player2ScoreText.Size = new System.Drawing.Size(86, 13);
            this.Player2ScoreText.TabIndex = 4;
            this.Player2ScoreText.Text = "Player 2\'s Score:";
            // 
            // TurnText
            // 
            this.TurnText.AutoSize = true;
            this.TurnText.Location = new System.Drawing.Point(12, 22);
            this.TurnText.Name = "TurnText";
            this.TurnText.Size = new System.Drawing.Size(76, 13);
            this.TurnText.TabIndex = 6;
            this.TurnText.Text = "Player 1\'s Roll:";
            // 
            // Player2RollButton
            // 
            this.Player2RollButton.Enabled = false;
            this.Player2RollButton.Location = new System.Drawing.Point(160, 303);
            this.Player2RollButton.Name = "Player2RollButton";
            this.Player2RollButton.Size = new System.Drawing.Size(112, 37);
            this.Player2RollButton.TabIndex = 7;
            this.Player2RollButton.Text = "Player 2 Roll";
            this.Player2RollButton.UseVisualStyleBackColor = true;
            this.Player2RollButton.Click += new System.EventHandler(this.Player2RollButton_Click);
            // 
            // RollResultsBeginning
            // 
            this.RollResultsBeginning.AutoSize = true;
            this.RollResultsBeginning.Location = new System.Drawing.Point(12, 225);
            this.RollResultsBeginning.Name = "RollResultsBeginning";
            this.RollResultsBeginning.Size = new System.Drawing.Size(66, 13);
            this.RollResultsBeginning.TabIndex = 8;
            this.RollResultsBeginning.Text = "Roll Results:";
            // 
            // RollResults
            // 
            this.RollResults.AutoSize = true;
            this.RollResults.Location = new System.Drawing.Point(84, 225);
            this.RollResults.Name = "RollResults";
            this.RollResults.Size = new System.Drawing.Size(102, 13);
            this.RollResults.TabIndex = 9;
            this.RollResults.Text = "Waiting for first roll...";
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.Location = new System.Drawing.Point(197, 8);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(75, 23);
            this.QuitGameButton.TabIndex = 10;
            this.QuitGameButton.Text = "Quit Game";
            this.QuitGameButton.UseVisualStyleBackColor = true;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // RollHistoryListBox
            // 
            this.RollHistoryListBox.FormattingEnabled = true;
            this.RollHistoryListBox.Location = new System.Drawing.Point(12, 122);
            this.RollHistoryListBox.Name = "RollHistoryListBox";
            this.RollHistoryListBox.Size = new System.Drawing.Size(260, 95);
            this.RollHistoryListBox.TabIndex = 11;
            // 
            // RollHistoryLabel
            // 
            this.RollHistoryLabel.AutoSize = true;
            this.RollHistoryLabel.Location = new System.Drawing.Point(12, 106);
            this.RollHistoryLabel.Name = "RollHistoryLabel";
            this.RollHistoryLabel.Size = new System.Drawing.Size(63, 13);
            this.RollHistoryLabel.TabIndex = 12;
            this.RollHistoryLabel.Text = "Roll History:";
            // 
            // rollOnce
            // 
            this.rollOnce.AutoSize = true;
            this.rollOnce.Location = new System.Drawing.Point(111, 276);
            this.rollOnce.Name = "rollOnce";
            this.rollOnce.Size = new System.Drawing.Size(71, 17);
            this.rollOnce.TabIndex = 13;
            this.rollOnce.Text = "Roll once";
            this.rollOnce.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.ControlBox = false;
            this.Controls.Add(this.rollOnce);
            this.Controls.Add(this.RollHistoryLabel);
            this.Controls.Add(this.RollHistoryListBox);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.RollResults);
            this.Controls.Add(this.RollResultsBeginning);
            this.Controls.Add(this.Player2RollButton);
            this.Controls.Add(this.TurnText);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player2ScoreText);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player1ScoreText);
            this.Controls.Add(this.Player1RollButton);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Player1RollButton;
        private System.Windows.Forms.Label Player1ScoreText;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label Player2ScoreText;
        private System.Windows.Forms.Label TurnText;
        private System.Windows.Forms.Button Player2RollButton;
        private System.Windows.Forms.Label RollResultsBeginning;
        private System.Windows.Forms.Label RollResults;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.ListBox RollHistoryListBox;
        private System.Windows.Forms.Label RollHistoryLabel;
        private System.Windows.Forms.CheckBox rollOnce;
    }
}

