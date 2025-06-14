/*
 * Patrick Snyder
 * CST-150
 * Activity 1.2: Hello World Forms App
 * 06/13/2025
 */
 
namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Create an event handler for the click here button.
        /// Method name must be PascalCasing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
