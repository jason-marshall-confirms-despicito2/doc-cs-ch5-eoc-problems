using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Create two doubles: days and count
            double days, count = 0;

            // If txtDays can be parsed to a double, outupt the users input to days
            if (double.TryParse(txtDays.Text, out days)) { }
            // Clear all of the items in listOutput
            listOutput.Items.Clear();
            // Add an item to listOutput "Day\tPennies"
            listOutput.Items.Add("Day\tPennies");
            // Set count to 1

            // Create a while loop to see if count is <= days
            while (count <= days)
            {
                // Add an item to listOutput that is days + "\t" + Math.Pow(2, count-1)
                listOutput.Items.Add(count + "\t" + Math.Pow(2, count - 1));
                // Increment count
                count = count + 1;
            }
        }

        private void listOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
