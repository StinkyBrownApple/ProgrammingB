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
    public partial class NewProfileForm : Form
    {
        ProfileManagerForm profileManagerForm;
        public NewProfileForm(ProfileManagerForm _profileManagerForm) //Constructor, called when we have been made
        {
            InitializeComponent();
            profileManagerForm = _profileManagerForm; //set the form we came from to the one passed to us
        }

        private void SubmitButton_Click(object sender, EventArgs e) //Submit button was pressed
        {
            ProfileManager.CreateProfile(NameTextBox.Text); //Create a new profile using the profile manager
            profileManagerForm.UpdateProfiles(); //update the list of profiles in the form we came from
            profileManagerForm.Enabled = true; //enable the form we came from
            this.Close(); //close this form
        }

        private void CancelButton_Click(object sender, EventArgs e) //Cancel button was pressed
        {
            profileManagerForm.Enabled = true; //enable the form we came from
            this.Close(); //close this form
        }
    }
}
