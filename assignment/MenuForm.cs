using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class MenuForm : Form
    {
        public MenuForm() //Constructor, called when this form is created
        {
            InitializeComponent();
            UpdateProfileList(); //Update the profiles
        }

        private void ManageProfilesButton_Click(object sender, EventArgs e) //Manage profile button was pressed
        {
            ProfileManagerForm profileManager = new ProfileManagerForm(this); //Create a profile manager form
            profileManager.Show(); //Show the profile manager
            this.Enabled = false; //disable this form
        }

        public void UpdateProfileList() //Update the profiles in the profiles list box
        {
            Player1Select.Items.Clear(); //Clear the player 1 list
            Player1Select.Items.Add("Guest"); //Add guest to it
            Player1Select.Items.AddRange(ProfileManager.GetProfiles()); //Add profiles from profile manager
            Player2Select.Items.Clear(); //Clear the player 2 list
            Player2Select.Items.Add("Guest"); //Add guest to it
            Player2Select.Items.Add("Computer"); //Add computer to it
            Player2Select.Items.AddRange(ProfileManager.GetProfiles()); //Add profiles from profile manager
        }

        private void PlayButton_Click(object sender, EventArgs e) //Play button was pressed
        {
            string player1Name = ""; //create some strings for player 1 and player 2 names
            string player2Name = "";

            try
            {
                player1Name = Player1Select.SelectedItem.ToString(); //set player 1s name based on profile selected
                player2Name = Player2Select.SelectedItem.ToString(); //set player 2s name based on profile selected

                if ((player1Name == player2Name) && player1Name != "Guest") //if the players names are the same and theyre not guests
                {
                    throw new Exception(); //this is an error, throw an exception
                }

                if ((player1Name == player2Name) && player1Name == "Guest") //if the players names are the same and they are guests
                {
                    player1Name = "Guest 1"; //set player 1 to guest 1
                    player2Name = "Guest 2"; //set player 2 to guest 2
                }
            }
            catch (Exception ex) //if there was an error above
            {
                MessageBox.Show("Please select a profile for both player 1 and player 2, and make sure they are not the same profile (unless playing as guests).", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Let them know something went wrong and then go back
            }

            Player player1 = new Player(player1Name); //Create some players
            Player player2 = new Player(player2Name);

            GameForm gameForm = new GameForm(this, (int)TargetScore.Value, player1, player2); //create a new game form
            gameForm.Show(); //show the game form
            this.Enabled = false; //disable this form
            this.Hide(); //and then hide it

        }

        private void RulesButton_Click(object sender, EventArgs e) //Rules button was pressed
        {
            //show the rules in a popup box
            string text = "Players take turns to roll 5 dice. If a player rolls 2 of a kind, they can then roll the remaining dice again. If a player rolls 3 of a kind, they score 3 points. If a player rolls 4 of a kind, they score 6 points. If a player rolls 5 of a kind they score 12 points. The first player to reach the decided target score wins the game. The player can check the 'Roll once' box in order to forfeit their reroll when rolling 2 of a kind, however anything they do score on that roll will be doubled.";
            MessageBox.Show(text, "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
