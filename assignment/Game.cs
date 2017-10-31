using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class Game
    {
        GameForm form;
        Random rand = new Random();
        List<Die> dice = new List<Die>();
        List<int> rolls = new List<int>();
        bool player1Turn = true;
        bool player1Next = false;
        int player1Score = 0;
        int player2Score = 0;                               //Instantiate variables for use in the class
        string rollOutput;
        string rollResults;
        bool rerolling = false;
        int rerollNo = 0;
        int targetScore = 0;
        Player player1;
        Player player2;
        List<string> rollHistory = new List<string>();
        bool player2Computer = false;
        bool win = false;
        bool singleRoll = false;

        public bool Player1Turn
        {
            get
            {
                return player1Turn;
            }

            protected set
            {
                player1Turn = value;
            }
        } // this var needs to be used elsewhere, we only want to change it here though

        public Game(GameForm _form, int _targetScore, Player _player1, Player _player2) //Function to start game
        {
            form = _form;
            player1 = _player1;
            player2 = _player2;             //Set vars based on data passed
            targetScore = _targetScore;

            if(player2.Name == "Computer")
            {
                player2Computer = true;     //If we're playing against a computer, set that too
            }

            InitialiseDice();    //Initialise the dice for the game
        }

        private void InitialiseDice() //Set up the dice for use in the game
        {
            Die die1 = new Die(rand);
            Die die2 = new Die(rand);
            Die die3 = new Die(rand);       //Create 5 dice
            Die die4 = new Die(rand);
            Die die5 = new Die(rand);

            dice.Add(die1);
            dice.Add(die2);
            dice.Add(die3);     //Add them all to our dice list
            dice.Add(die4);
            dice.Add(die5);
        }
        private void RollDice() //Roll our dice
        {
            if (!rerolling) //If we're not doing a reroll (because of 2 of kind), roll all the dice
            {
                int dieRoll = 0; //Temp int to store the current die's roll

                foreach (Die die in dice) //Loop through all our dice
                {
                    dieRoll = die.Roll(); //Roll the die and store result to temp int
                    rolls.Add(dieRoll); //Add the value to our list of rolls in the current turn
                }
            }
            else //We do this when we're rerolling 3 dice (due to 2 of kind)
            {
                for (int i = 0; i < dice.Count; i++) //Loop for the number of dice we have
                {
                    if (rolls[i] != rerollNo) //rerollNo is a number stored saying which number was the 2 of a kind, so reroll anything that isnt this number
                    {
                        int roll = dice[i].Roll(); //reroll the die
                        rolls[i] = roll; //overwrite its old roll with its new one
                    }
                }
            }
        }
        private void UpdateForm() //Update the windows form with some new data
        {
            form.Update(player1Turn, player1Next, player1Score, player2Score, rollOutput, rollResults, new List<string>(rollHistory));
            //Call the function on our windows form so that it can update the GUI
        }
        private void CalculateScore() //Calculate the score for the turn based on the rolls
        {
            int currentMax = 0; //The highest x-of-a-kind that's been rolled so far
            int maxNo = 0; //The number on the dice of the highest x-of-a-kind
            for (int i = 1; i <= 6; i++) //loop through the numbers on the dice
            {
                int count = 0; //the amount of dice with this number
                for (int j = 0; j < rolls.Count; j++) //go through all the rolls
                { 
                    if (rolls[j] == i) //if it's the same as the current loop number
                        count++; //increase the count
                }

                if(count > 1 && count > currentMax) //if the count of that number is more than 1 and more than the current highest x-of-a-kind
                {
                    currentMax = count; //set the current highest to this one
                    maxNo = i; //set the number these dice show to the number of the loop
                }
            }

            int multiplier;

            if (singleRoll) //if we're doing a single roll
                multiplier = 2; //double everything they score
            else
                multiplier = 1; //otherwise add the normal value

            switch(currentMax) //do some things depending on what the highest x-of-a-kind is
            {
                case 2: //if it's 2
                    if (!rerolling && !singleRoll) //if this is the first 2 of a kind of this turn and we're not doing a single roll
                    {
                        rerolling = true; //let things know we need to reroll the other dice
                        rerollNo = maxNo; //let things know what the number is on the 2 of a kind dice
                        rollResults = "2 of a kind: reroll the other dice!"; //results of the roll
                        if (player1Turn) //if it's player 1s turn
                        {
                            player1.IncrementTwoOfKind(); //save to their stats
                        }
                        else
                        {
                            player2.IncrementTwoOfKind(); //otherwise save to player 2s stats
                        }
                    }
                    else //if they've already had a reroll or are rolling once, they dont get another, so theres no score
                    {
                        rerolling = false; //we're not rerolling anymore
                        rollResults = "2 of a kind. No score: end of turn"; //results of the roll
                    }
                    break;
                case 3: //if it's 3
                    if (player1Turn) //if it's player 1s turn
                    {
                        player1Score += 3 * multiplier; //add 3 to player 1s score
                        player1.IncrementThreeOfKind(); //save their stats
                    }
                    else
                    {
                        player2Score += 3 * multiplier; //otherwise add 3 to player 2s score
                        player2.IncrementThreeOfKind(); //save their stats
                    }
                    rollResults = "3 of a kind: +" + 3 * multiplier +" points!"; //results of roll
                    rerolling = false; //we dont need to reroll
                    break;
                case 4: //if it's 4, same as 3 except add 6 to their scores instead
                    if (player1Turn)
                    {
                        player1Score += 6 * multiplier;
                        player1.IncrementFourOfKind();
                    }
                    else
                    {
                        player2Score += 6 * multiplier;
                        player2.IncrementFourOfKind();
                    }
                    rollResults = "4 of a kind: +" + 6 * multiplier + " points!";
                    rerolling = false;
                    break;
                case 5: //if it's 5, same as 4 but add 12 to their scores instead
                    if (player1Turn)
                    {
                        player1Score += 12 * multiplier;
                        player1.IncrementFiveOfKind();
                    }
                    else
                    {
                        player2Score += 12 * multiplier;
                        player2.IncrementFiveOfKind();
                    }
                    rollResults = "5 of a kind: +" + 12 * multiplier + " points!";
                    rerolling = false;
                    break;
                default: //if it's 1 of a kind
                    rollResults = "No Score: end of turn"; //roll results
                    rerolling = false; //we're not rerolling
                    break;
            }

            CheckWin(); //after we've added some scores, check if anyone has won before we do anything else
        }
        private void ResetRolls() //Reset the rolls so they're ready for another turn
        {
            rolls.RemoveRange(0, rolls.Count);  //remove all the rolls from the list
        }
        private void GenerateOutput() //Create some strings for use in the GUI
        {
            string rollsString = ""; //a temp string to display the results from the dice rolls which we will generate

            foreach (int i in rolls) //go through each roll
            {
                rollsString += i + ", "; //add to the string with a comma and space to seperate
            }

            rollsString = rollsString.Remove(rollsString.Length - 2, 2); //remove the comma and space from the last roll because theres nothing after it
            rollOutput = rollsString; //copy from temp to the string we'll use to send to GUI
            if(player1Turn) //If it's player 1s turn
            rollHistory.Add(player1.Name + ": " +rollOutput); //Add the roll to the history with player 1s name
            else
                rollHistory.Add(player2.Name + ": " + rollOutput); //otherwise, add it to the history with player 2s name
        }
        private void CheckWin() //Check if someone won the game
        {
            if (win) //check if the game already ended (to prevent multiple checks due to recursion with computer)
                return; //if it did, return
            if(player1Score >= targetScore) //if player 1 won
            {
                UpdateForm(); //update the GUI so we can see results from the roll
                MessageBox.Show(player1.Name + " has won the game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information); //Popup box saying who won
                form.QuitGame(false); //Quit the game
                win = true; //Set the game to over
                
            }

            if (player2Score >= targetScore) //Do same as above if player 2 won
            {
                UpdateForm();
                MessageBox.Show(player2.Name + " has won the game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.QuitGame(false);
                win = true;
            }
        }

        public void RollPressed(bool _singleRoll) //Called from GUI when a button is pressed to roll the die
        {
            singleRoll = _singleRoll; //set whether we're doing a single roll or not

            if (!rerolling) //if this isn't a reroll
            {
                ResetRolls(); //reset the rolls
            }
                RollDice(); //roll the dice
                CalculateScore(); //calculate the score
            if (rerolling) //if we are rerolling next roll pressed
            {
                player1Next = player1Turn; //the next person to roll is the same as the person rolling now
            }
            else
            {
                player1Next = !player1Turn; //otherwise the next person to roll is the person who isnt rolling now
            }
            GenerateOutput(); //generate output to send to gui
            UpdateForm(); //update gui
            player1Turn = player1Next; //end turn for current player and set it to whoever is next

            if(player2Computer && !player1Turn) //if it's the computers turn
            {
                RollPressed(false); //roll the dice for them
            }
        }
    }
}
