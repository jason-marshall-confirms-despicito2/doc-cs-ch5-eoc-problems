using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Ad an item for our header with a tab in the middle
            lstMain.Items.Add("Year\tTuition");

            // Use a for loop to start at year one and end at year 5
            for ( /* Info goes here */ )
            {
                // Add another item with "year" in the left column, a tab, and then 6000 times the quantity of 1.02 to the power of year -1
                // Output your string as currency
            }
        }
    }
}
