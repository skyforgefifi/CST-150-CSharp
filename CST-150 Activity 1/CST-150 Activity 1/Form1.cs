/*
 * Patrick Snyder
 * CST-150 Activity 1
 * Convert Earth weight to Mars weight
 * 6/13/2025
 */

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        // Hide t
        public Form1()
        {
           InitializeComponent();
           // Hide the Weight on Mars labels
           lblMars.Visible = false;
           lblMarsWeight.Visible = false;
        }

        private void lblEarth_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMars_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Click event for convert button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            // Declare and initialize variables
            decimal earthWeight = 0.0m;
            decimal finalValue = 0.0m;
            decimal gravAccelEarth = 9.81m; // Earth's gravitational acceleration in m/s^2
            decimal gravAccelMars = 3.711m; // Mars' gravitational acceleration in m/s^2

            // Read in Earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Calculate the final value
            finalValue = (earthWeight / gravAccelEarth) * gravAccelMars;

            // Display the results
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make sure to show the Mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;
        }   
    }
}
