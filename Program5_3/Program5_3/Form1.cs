using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create our variables
            double fahrenheit, celsius;

            // Initialize celsius as 0
            celsius = 0;

            // "\t" in a string literal translates as a tab to your program
            // Add an item to listOutput "Celsius\tFarenheit"
            listOutput.Items.Add("celcius\tfarenheit");
            int celcius = 0;
            // Create a while loop that checks to see if celsius <= 20
            while (celcius <= 20)
            {
                fahrenheit = ((9 * celcius) / 5) + 32;
                listOutput.Items.Add(celcius + "\t" + fahrenheit);
                ++celcius;
            }
            /* Set farenheit to ((9 * celsius) / 5) + 32
                 * Add an item to listOutput celsius + "\t" + farenheit
                 * Increment celsius
                 * 
                 */
        }

        private void listOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
