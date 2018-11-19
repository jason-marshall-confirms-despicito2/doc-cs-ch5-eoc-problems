using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create a random object named rand and assign it a random integer
        Random rand = new Random();

        // Declare three integers: n, guess, and attempt
        int n = 0;
            int guess;
            int attempt =0;

        // Before the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Call the getNumber method
            getNumber();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // If txtNumber.Text can be parsed as an integer, assign that value to guess
            int.TryParse(txtNumber.Text, out guess);
            // Increment attempt
            attempt = attempt + 1;
            // If guess = n
            lblOutput.Text = "";
            if (guess == n)
            {
                lblOutput.Text = "you tried " + attempt + " time(s). \n " + "congratualations, you won! Enter a number to start again";


            }
            else if (guess > n) 
            {
                lblOutput.Text = " You tried" + attempt + " time(s).\n" + guess + "is too high. Try again.";
            }
            
                 else
            {
                lblOutput.Text = " You tried" + attempt + " time(s).\n" + guess + "is too low. Try again.";
            }
        }

        // This is the getNumber method
        public void getNumber()
        {
        n = rand.Next(100);
        attempt = 0;
        // Assign a random integer between 1 and 100 to integer n
            // Set attempt to 0
        }
    }
}
