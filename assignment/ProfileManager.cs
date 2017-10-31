using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    static class ProfileManager
    {
        static string profileFolder = @"..\..\Profiles\";
        static string defaultProfile = @"DefaultProfile.txt";

        public static void CreateProfile(string name) //Create a profile
        {
            try
            {
                //If the name of the profile is any of the following
                if(name == "Computer" || name == "Guest" || name == "computer" || name == "guest" || name == "Guest 1" || name == "guest 1" || name == "Guest 2" || name == "guest 2")
                {
                    throw new Exception("The name of a profile cannot be Guest or Computer"); //this is an error, these names are reserved, throw an exception
                }

                File.Copy(Path.Combine(profileFolder, defaultProfile), Path.Combine(profileFolder, name + ".txt")); //Create the profile if there were no errors
            }
            catch (ArgumentException e) //If there was a problem with the name
            {
                string invalidChars = "\" < > | : * ? \\ / "; //These are the characters that cant be used
                
                MessageBox.Show("The name you entered was invalid:\n\n" +"The following characters are not allowed: " +invalidChars, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tell them they cant use these characters in a popup box
            }
            catch (Exception e) //If there was another error in creating the profile
            {
                MessageBox.Show("There was an error creating the profile:\n\n" + e.Message, "Profile Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Tell them there was an error, and the message that the exception gave
            }
        }

        public static void DeleteProfile(string name) //Delete a profile
        {
            File.Delete(Path.Combine(profileFolder, name + ".txt")); //Delete the file with the profile name
        }

        public static string[] GetProfiles() //Get the profiles that have been made
        {
            List<string> paths = new List<string>(Directory.GetFiles(profileFolder)); //Create a list of file paths from the files in the Profile folder
            for (int i = 0; i < paths.Count; i++) //Go through each one
            {
                paths[i] = paths[i].Remove(paths[i].Length - 4, 4); //Remove the file extension
                paths[i] = paths[i].Remove(0, profileFolder.Length); //remove the folder path
            }

            paths.Remove(defaultProfile.Remove(defaultProfile.Length - 4, 4)); //Remove the default profile from the list
            return paths.ToArray(); //return the list as an array
        }

        public static int[] GetValsFromProfile(string name) //Get data from the profile files
        {
            string valsString = File.ReadAllLines(profileFolder + name + ".txt")[0]; //read the first line from the profile file
            char[] valsChars = valsString.ToCharArray(); //convert the string to characters
            int[] vals = new int[7]; //create a new array to store the data

            int start = 0; //val so we know where to start getting the data from (which at first is the start)
            for (int i = 0; i < vals.Length; i++) //Repeat until we have all the data
            {
                string val = ""; //create a string to store the data
                for (int x = start; x < valsChars.Length; x++) //loop from our start for as long as the characters
                {
                    if (valsChars[x] != ',') //if the character isn't a comma
                    {
                        val += valsChars[x]; //add the character to our val string
                    }
                    else //otherwise we reached the end of the data
                    {
                        start = ++x; // the next start point is the position after this comma
                        vals[i] = Convert.ToInt32(val); //convert the data to an int and store int the array
                        break; //we are done with this loop
                    }
                }
            }

            return vals; //return the data we got
        }

        public static void SaveValsToProfile(string name, int[] vals) //Save data to the profile files
        {
            int[] currentVals = GetValsFromProfile(name); //get the current saved values
            for (int i = 0; i < currentVals.Length; i++) //loop through them
            {
                currentVals[i] += vals[i]; //add the new value to the current value
            }

            string valsString = ""; //create a string to add the values to

            for (int i = 0; i < currentVals.Length; i++) //loops through the data
            {
                valsString += (currentVals[i] + ","); //add it to the string with a comma
            }

            string[] valsStringArray = new string[1]; //create a string array to save to the file
            valsStringArray[0] = valsString; //add our data to the array
            File.WriteAllLines(profileFolder + name + ".txt", valsStringArray); //save the file
        }
    }
}
