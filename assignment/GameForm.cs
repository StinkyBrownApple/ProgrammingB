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
    public partial class GameForm : Form
    {

        Game game;
        MenuForm menuForm;      //Instantiate variables for use in the class
        Player player1;
        Player player2;

        public GameForm(MenuForm _menuForm, int _targetScore, Player _player1, Player _player2) //Constructor, called when the form is made
        {
            InitializeComponent();
            game = new Game(this, _targetScore, _player1, _player2); //start a new game
            menuForm = _menuForm;
            player1 = _player1;     //set vars to data passed
            player2 = _player2;

            SetStartingText(); //Prepare the GUI text objects
        }

        private string output
        {
            get
            {
                return Output.Text;
            }

            set
            {
                Output.Text = value;
            }
        }
        private string turntext
        {
            get
            {
                return TurnText.Text.Remove(TurnText.Text.Length - 7, 7);
            }

            set
            {
                TurnText.Text = value + "'s roll";
            }
        }
        private string player1score
        {
            get
            {
                return Player1Score.Text;
            }

            set
            {
                Player1Score.Text = value;
            }
        }   //strings which when modified will get straight from text objects and set straight to them
        private string player2score
        {
            get
            {
                return Player2Score.Text;
            }

            set
            {
                Player2Score.Text = value;
            }
        }
        private string rollResults
        {
            get
            {
                return RollResults.Text;
            }

            set
            {
                RollResults.Text = value;
            }
        }


        public void Update(bool _player1Turn, bool _player1Next, int _player1Score, int _player2Score, string _rollOutput, string _rollResults, List<string> _rollHistory) //Update the GUI
        {
            if (_player1Turn && !_player1Next)
            {
                turntext = player1.Name;
                Player1RollButton.Enabled = false;
                Player2RollButton.Enabled = true;
            }
            else if (_player1Turn && _player1Next)
            {
                turntext = player1.Name;
                Player1RollButton.Enabled = true;
                Player2RollButton.Enabled = false;
            }
            else if (!_player1Turn && _player1Next)
            {
                turntext = player2.Name;
                Player1RollButton.Enabled = true;
                Player2RollButton.Enabled = false;
            }
            else if (!_player1Turn && !_player1Next)
            {
                turntext = player2.Name;
                Player1RollButton.Enabled = false;
                Player2RollButton.Enabled = true;
            }
            //The above code changes the gui based on whos turn is next

            player1score = _player1Score.ToString(); //set player 1s score
            player2score = _player2Score.ToString(); //set player 2s score
            output = _rollOutput; //set the rolls to the stuff that was just rolled
            rollResults = _rollResults; //set the results of the roll to the text given

            RollHistoryListBox.Items.Clear(); //clear the roll history
            _rollHistory.Reverse(); //reverse the list
            RollHistoryListBox.Items.AddRange(_rollHistory.ToArray()); //add the list to the roll history box
        }

        private void SetStartingText() //Set text which will show before any rolls are made
        {
            turntext = player1.Name;
            Player1RollButton.Text = player1.Name + " Roll";
            Player2RollButton.Text = player2.Name + " Roll";    //set some text in the gui using players names
            Player1ScoreText.Text = player1.Name + "'s Score";
            Player2ScoreText.Text = player2.Name + "'s Score";
        }

        public void QuitGame(bool quitGameButton) //Function for when the game is over and needs to be exited
        {
            if (quitGameButton) //if the quit was made from the quit game button
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to quit? The player who's turn it is currently will forfeit the game.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //show a dialogue to make sure they're sure
                if (result != DialogResult.Yes) //if they dont want to quit then just go back
                {
                    return;
                }

                if (game.Player1Turn) //if it's player 1s turn, they lose
                {
                    player1.SaveStats(false);   //save stats
                    player2.SaveStats(true);
                    this.Close(); //close this from
                    menuForm.Enabled = true; //go back to the main menu
                    menuForm.Show();
                }
                else //same as above however player 2 loses
                {
                    player1.SaveStats(true);
                    player2.SaveStats(false);
                    this.Close();
                    menuForm.Enabled = true;
                    menuForm.Show();
                }
            }
            else //this happens when the game ends fomr someone winning
            {
                if (game.Player1Turn) //if it's player 1s turn, they win
                {
                    player1.SaveStats(true); //save stats
                    player2.SaveStats(false);
                    this.Close(); //close this form
                    menuForm.Enabled = true; //open up the main menu
                    menuForm.Show();
                }

                else //same as above however player 2 wins
                {
                    player1.SaveStats(false);
                    player2.SaveStats(true);
                    this.Close();
                    menuForm.Enabled = true;
                    menuForm.Show();
                }
            }


        }

        private void Player1RollButton_Click(object sender, EventArgs e) //Player 1 roll button was pressed
        {
            game.RollPressed(rollOnce.Checked); //Signal roll was pressed
        }

        private void Player2RollButton_Click(object sender, EventArgs e) //Player 2 roll button was pressed
        {
            game.RollPressed(rollOnce.Checked); //Signal roll was pressed
        }

        private void QuitGameButton_Click(object sender, EventArgs e) //Quit game button was pressed
        {
            QuitGame(true); //Quit game via quit button
        }
    }
}
