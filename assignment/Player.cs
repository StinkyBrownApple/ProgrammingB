using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Player
    {
        string name;
        int twoOfKind = 0;
        int threeOfKind = 0; //Instantiate variables we need in the class
        int fourOfKind = 0;
        int fiveOfKind = 0;

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
            
        } //this variable needs using elsewhere, but we only want to set it here
        
        public Player(string _name) //Contructor, called when a new player is made
        {
            name = _name; //set the name of the player from the one that was passed
        }

        //The following 4 functions increment the respective x-of-a-kind value which will be saved when the game ends

        public void IncrementTwoOfKind()
        {
            twoOfKind++;
        }
        public void IncrementThreeOfKind()
        {
            threeOfKind++;
        }
        public void IncrementFourOfKind()
        {
            fourOfKind++;
        }       
        public void IncrementFiveOfKind()
        {
            fiveOfKind++;
        }

        public void SaveStats(bool win) //Called when the game ends, and will save the stats
        {
            //if the name is any of these we don't want to bother saving the stats
            if (name != "Guest" && name != "Guest 1" && name != "Guest 2" && name != "Computer")
            {
                if (win) //if we won, save our stats with a win
                {
                    int[] vals = { 1, 1, 0, twoOfKind, threeOfKind, fourOfKind, fiveOfKind };
                    ProfileManager.SaveValsToProfile(name, vals); //Save stats using profile manager
                }
                else //otherwise save stats with a loss
                {
                    int[] vals = { 1, 0, 1, twoOfKind, threeOfKind, fourOfKind, fiveOfKind };
                    ProfileManager.SaveValsToProfile(name, vals); //save stats using profile manager
                }
            }
        }
    }
}
