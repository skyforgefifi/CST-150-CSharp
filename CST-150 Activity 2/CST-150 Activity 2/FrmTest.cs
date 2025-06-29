/*Patrick Snyder
 * CST-150 Activity 2
 * 6/18/2025
 */





using System.Diagnostics.Eventing.Reader;

namespace CST_150_Activity_2
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            // Make sure the label is not visible
            lblResults.Visible = false;
        }

        /// <summary>
        /// Event handler to Evaluate Seconds    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSeconds_Load(object sender, EventArgs e)
        {

        }

        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // Declare and Intialize
            int seconds = 0;  //Declare the value
            // Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;
            // Define flags

            // Make sure the label is not visible
            lblResults.Visible = false;
            // Default the color to Black
            lblResults.ForeColor = Color.Black;

            // Test to determine if integer was entered correctly by user
            // if try to parse string to int is successful continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                // This block of code is where all our business logic will be placed
                // Practice with nested if statements
                if (seconds >= SecondsInMinutes)
                {
                    lblResults.Text = string.Format("There are {0:0,0} minute(s) in {1:0,0} seconds. \n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;
                }
                if (seconds >= SecondsInHours)
                {
                    lblResults.Text += string.Format("There are {0:0,0} hour(s) in {1:0,0} seconds. \n", seconds / SecondsInHours, seconds);
                    lblResults.Visible = true;
                }
                if (seconds >= SecondsInDays)
                {
                    lblResults.Text += string.Format("There are {0:0,0} day(s) in {1:0,0} seconds. \n", seconds / SecondsInDays, seconds);
                    lblResults.Visible = true;
                }
                else
                {
                    lblResults.Text = "Please enter an integer larger than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }
            }
            else
            {
                lblResults.Text = "Please enter an int to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }
        }
    }
}
