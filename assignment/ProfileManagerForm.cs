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
    public partial class ProfileManagerForm : Form
    {
        MenuForm menuForm; //var to save the menu we came from
        public ProfileManagerForm(MenuForm _menuForm) //Constructor, called when this form is made
        {
            InitializeComponent();
            menuForm = _menuForm;
            FormClosed += ProfileManagerForm_FormClosed;
        }

        private void CreateNewButton_Click(object sender, EventArgs e) //Create new profile button was clicked
        {
            NewProfileForm newProfile = new NewProfileForm(this); //create a new profile form
            newProfile.Show(); //show it
            this.Enabled = false; //disable this form
        }

        private void ProfileManagerForm_Load(object sender, EventArgs e) //Called once the form is loaded
        {
            UpdateProfiles(); //Update the profiles
        }

        public void UpdateProfiles() //Update the profiles in our form
        {
            ProfilesListBox.Items.Clear(); //Clear the current profile
            ProfilesListBox.Items.AddRange(ProfileManager.GetProfiles()); //Add profiles from profile manager
            if (ProfilesListBox.Items.Count > 0) //If there are profiles to display
                ProfilesListBox.SelectedIndex = 0; //select the first one to show stats
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e) //Delete profile button was clicked
        {
            try
            {
                string profile = ProfilesListBox.SelectedItem.ToString(); //get the profile they want to delete
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to delete profile '" + profile + "'?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) //make sure they want to delete the profile
                {
                    ProfileManager.DeleteProfile(profile); //Delete the profile using the profile manager
                    UpdateProfiles(); //update the profiles in this form
                }
            }
            catch(Exception ex) //if there was an error above, it was because a profile wasnt selected
            {
                //tell them to select a profile
                MessageBox.Show("Select a profile to delete first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileManagerForm_FormClosed(object sender, FormClosedEventArgs e) //Called when this form is closed
        {
            menuForm.Enabled = true; //show the main menu form
            menuForm.UpdateProfileList(); //update the profiles in the main menu form
        }

        private void ProfilesListBox_SelectedIndexChanged(object sender, EventArgs e) //The selected profile has changed to a different profile
        {

            int[] vals; //create an array to store the data from the profile
            try
            {
                vals = ProfileManager.GetValsFromProfile(ProfilesListBox.SelectedItem.ToString()); //get the data from the profile and store it in the array
            }
            catch(Exception ex) //if there was an error above, select the first profile and show that instead
            {
                ProfilesListBox.SelectedIndex = 0; //set the first profile to selected
                vals = ProfileManager.GetValsFromProfile(ProfilesListBox.SelectedItem.ToString()); //get the data and store it in the array
            }

            PlaysVal.Text = vals[0].ToString();
            WinsVal.Text = vals[1].ToString();
            LossesVal.Text = vals[2].ToString();
            TwoKindVal.Text = vals[3].ToString();       //Set the text in the GUI to the vals from the array
            ThreeKindVal.Text = vals[4].ToString();
            FourKindVal.Text = vals[5].ToString();
            FiveKindVal.Text = vals[6].ToString();
        }
    }
}
