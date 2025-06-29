/* Patrick Snyder
 * CST-150 Milestone 2
 * 06/29/2025 
 * This program displays a list of marbles in an inventory.
 */


namespace CST_150_Milestone_2
{
    public partial class Milestone2 : Form
    {

        // Marble Inventory Items
        // Blue Marble
        string name = "Blue Marble";
        string description = "Blue marble with white swirls";
        int quantity = 10;
        double cost = 0.25;
        string color1 = "Blue";

        // WHite Marble
        string name2 = "White Marble";
        string description2 = "White marble with gold flake";
        int quantity2 = 10;
        double cost2 = 0.25;
        string color2 = "White";

        // Red Marble
        string name3 = "Red Marble";
        string description3 = "Red marble with black swirls";
        int quantity3 = 10;
        double cost3 = 0.25;
        string color3 = "Red";
        private object name1;

        public Milestone2()
        {
            InitializeComponent();
        }

        private void lblInventoryOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnShowInventoryClick(object sender, EventArgs e)
        {
            lblInventoryOutput.Text =
                $"Name: {name}\nDescription: {description}\nQuantity: {quantity}\nCost: {cost:C}\nColor: {color1}\n\n" +
                $"Name: {name2}\nDescription: {description2}\nQuantity: {quantity2}\nCost: {cost2:C}\nColor: {color2}\n\n" +
                $"Name: {name3}\nDescription: {description3}\nQuantity: {quantity3}\nCost: {cost3:C}\nColor: {color3}";
        }
    }
}
