using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variables and constants
            double weight;                  // Holds the calculated weight
            const double TOO_HEAVY = 1000;  // Is the constant when the object is too heavy
            const double TOO_LIGHT = 10;    // Is the constant when the object is too light

            // Checks and determines that the value for mass is a double that the user entered.
            if (double.TryParse(massTextBox.Text, out double mass))
            {
                // The formula for converting mass to weight.
                weight = mass * 9.8;
                // If the weight of the object is too heavy, the error message is displayed.
                if (weight >= TOO_HEAVY)
                {
                    MessageBox.Show("The object is too heavy.");
                }
                // If the weight of the object is too light, the error message is displayed.
                else if (weight <= TOO_LIGHT)
                {
                    MessageBox.Show("The object is too light.");
                }
                // If the object is not too light or too heavy, the weight will be displayed and the units Newtons.
                else
                {
                    weightLabel.Text = weight + " Newtons";
                }
            } 
            // If the user's input does not work with the variable, mass, then an error message will be displayed.
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // The input and output is cleared.
            massTextBox.Text = "";
            weightLabel.Text = "";
            // The focus is cleared.
            massTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // The form is closed.
            this.Close();
        }
    }
}
