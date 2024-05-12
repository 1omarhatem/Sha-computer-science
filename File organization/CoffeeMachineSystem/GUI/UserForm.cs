﻿using System.Security.Cryptography;

namespace CoffeeMachineSystem.GUI
{
    internal enum EnSizes
    {
        small = 0,
        medium = 1,
        large = 2,
    }

    internal enum EnDrinks
    {
        coffee = 0,
        cappuccino = 1,
        latte = 2,
    }

    internal struct StIngredients
    {
        public uint water;
        public uint milk;
        public uint coffee;
        public ushort sugar;
        public uint vanilla;
        public uint caramel;
    }

    public partial class UserForm : Form
    {
        private EnDrinks drinkName = EnDrinks.coffee;
        private EnSizes size = EnSizes.small;
        private ushort quantity;
        private StIngredients ingred;
        private StIngredients dbIngred;
        private readonly DataAccess.TextFileDatabase fdb = new("../../../Resourses/Data.txt");

        public UserForm()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------*/
        //This 6 buttom for coffee type and size

        // Button click events for selecting the drink type
        private void button1_Click(object sender, EventArgs e) => drinkName = EnDrinks.coffee;

        private void button2_Click(object sender, EventArgs e) => drinkName = EnDrinks.cappuccino;

        private void button3_Click(object sender, EventArgs e) => drinkName = EnDrinks.latte;

        // Button click events for selecting the drink size
        private void button4_Click(object sender, EventArgs e) => size = EnSizes.small;

        private void button6_Click(object sender, EventArgs e) => size = EnSizes.medium;

        private void button5_Click(object sender, EventArgs e) => size = EnSizes.large;

        /*---------------------------------------------------------------------------*/
        //This 4 buttom for Suger and quantity

        // Button click events for adjusting sugar quantity
        private void button7_Click(object sender, EventArgs e)
        {
            /* Implement decrease sugar quantity */
            if (ushort.Parse(textBox2.Text) == 0)
                return;

            textBox2.Text = (ushort.Parse(textBox2.Text) - 1).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* Implement increase sugar quantity */
            if (ushort.Parse(textBox2.Text) == 10)
                return;

            textBox2.Text = (ushort.Parse(textBox2.Text) + 1).ToString();
        }

        // Button click events for adjusting drink quantity
        private void button9_Click(object sender, EventArgs e)
        {
            /* Implement decrease drink quantity */
            if (ushort.Parse(textBox4.Text) == 1)
                return;

            textBox4.Text = (ushort.Parse(textBox4.Text) - 1).ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            /* Implement increase drink quantity */
            if (ushort.Parse(textBox4.Text) == 50)
                return;

            textBox4.Text = (ushort.Parse(textBox4.Text) + 1).ToString();
        }

        /*---------------------------------------------------------------------------*/

        // Checkbox events for selecting vanilla or caramel syrup
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {/* Implement selection of vanilla syrup */}

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {/* Implement selection of caramel syrup */}

        /*---------------------------------------------------------------------------*/

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }

        private void UserForm_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // Click event for placing the order
        private void button11_Click(object sender, EventArgs e)
        {
            // Get the quantity of drinks
            quantity = ushort.Parse(textBox4.Text);

            // Read the available ingredients from the database
            dbIngred.water   = uint.Parse(fdb.ReadFieldById(1, 2, ','));
            dbIngred.milk    = uint.Parse(fdb.ReadFieldById(2, 2, ','));
            dbIngred.coffee  = uint.Parse(fdb.ReadFieldById(3, 2, ','));
            dbIngred.sugar   = ushort.Parse(fdb.ReadFieldById(4, 2, ','));
            dbIngred.vanilla = uint.Parse(fdb.ReadFieldById(5, 2, ','));
            dbIngred.caramel = uint.Parse(fdb.ReadFieldById(6, 2, ','));

            // Store the required ingredients' data based on drink type and size
            switch (drinkName)
            {
                case (EnDrinks.coffee):
                    switch (size)
                    {
                        case (EnSizes.large):
                            ingred.water = 470;
                            ingred.milk = 60;
                            ingred.coffee = 30;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.medium):
                            ingred.water = 225;
                            ingred.milk = 30;
                            ingred.coffee = 15;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.small):
                            ingred.water = 125;
                            ingred.milk = 20;
                            ingred.coffee = 10;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                    }
                    break;
                case (EnDrinks.cappuccino):
                    switch (size)
                    {
                        case (EnSizes.large):
                            ingred.water = 470;
                            ingred.milk = 60;
                            ingred.coffee = 30;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.medium):
                            ingred.water = 225;
                            ingred.milk = 30;
                            ingred.coffee = 15;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.small):
                            ingred.water = 125;
                            ingred.milk = 20;
                            ingred.coffee = 10;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                    }
                    break;
                case (EnDrinks.latte):
                    switch (size)
                    {
                        case (EnSizes.large):
                            ingred.water = 470;
                            ingred.milk = 60;
                            ingred.coffee = 30;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.medium):
                            ingred.water = 225;
                            ingred.milk = 30;
                            ingred.coffee = 15;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                        case (EnSizes.small):
                            ingred.water = 125;
                            ingred.milk = 20;
                            ingred.coffee = 10;
                            ingred.sugar = ushort.Parse(textBox2.Text);
                            break;
                    }
                    break;
            }

            // Check if there are enough basic ingredients
            if (ingred.water  * quantity > dbIngred.water  ||
                ingred.milk   * quantity > dbIngred.milk   ||
                ingred.coffee * quantity > dbIngred.coffee ||
                ingred.sugar  * quantity > dbIngred.sugar)
            {
                MessageBox.Show("There are not enough ingredients!");
                return;
            }
            else
            {
                // Check if there are enough flavor ingredients (vanilla or caramel)
                if (checkBox1.Checked && dbIngred.vanilla < 30 * quantity)
                {
                    MessageBox.Show("There are not enough vanilla!");
                    return;
                }
                if (checkBox2.Checked && dbIngred.caramel < 30 * quantity)
                {
                    MessageBox.Show("There are not enough caramel!");
                    return;
                }

                switch (drinkName)
                {
                    case (EnDrinks.coffee):
                        SailedItems.IncrementSailedCoffee(quantity);
                        break;
                    case (EnDrinks.cappuccino):
                        SailedItems.IncrementSailedCappuchino(quantity);
                        break;
                    case (EnDrinks.latte):
                        SailedItems.IncrementSailedLate(quantity);
                        break;
                }

                // Update the database with the used ingredients
                fdb.UpdateField(1, 2, (dbIngred.water - ingred.water * quantity).ToString(), ',');
                fdb.UpdateField(2, 2, (dbIngred.milk - ingred.milk * quantity).ToString(), ',');
                fdb.UpdateField(3, 2, (dbIngred.coffee - ingred.coffee * quantity).ToString(), ',');
                fdb.UpdateField(4, 2, (dbIngred.sugar - ingred.sugar * quantity).ToString(), ',');

                // Update the database with the used flavor ingredients (vanilla or caramel)
                if (checkBox1.Checked)
                    fdb.UpdateField(5, 2, (dbIngred.vanilla - 30 * quantity).ToString(), ',');
                if (checkBox2.Checked)
                    fdb.UpdateField(6, 2, (dbIngred.caramel - 30 * quantity).ToString(), ',');

                MessageBox.Show("Your order has been placed successfully!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new GUI.LoginForm().Show();
            this.Hide();
        }
    }
}
