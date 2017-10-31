using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Die
    {
        int sides; //Declare variables for use in class
        Random rand;

        public Die(Random _rand) //Constructor which requires a Random object so dice will roll different
        {
            rand = _rand; //Set class variables using passed Random object and default sides
            sides = 6;
        }

        public int Roll()
        {
            int roll = rand.Next(1, sides); //Roll die by getting a new number from Random
            return roll; //Return the number we rolled
        } //public function to roll the die and return the value
    }
}
