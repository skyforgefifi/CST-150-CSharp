/*
 * Patrick Snyder
 * CST-150
 * Activity 1
 * 6/13/2025
 * Citations Here
 */


namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create an event handler for the click here button
        /// Method name must be PascalCasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!";
        }
    }
}
