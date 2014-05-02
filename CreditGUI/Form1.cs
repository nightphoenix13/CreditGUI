// Written by Zack Rosales
// Introduction to C# Programming ITSE 1430 1001
// Program for page 351, # 9

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // local variables
            double creditLimit;

            // getting input from user
            creditLimit = Convert.ToDouble(valueTextBox.Text);

            // using method arguments based on user input
            if (creditLimit == 0.00)
                CustomerCreditLimit();
            else
                CustomerCreditLimit(creditLimit);
        }

        void CustomerCreditLimit(double limit = 500.00) // CustomerCreditLimit method start
        {
            // preparing output labels
            outputLabel.Text = String.Format("The credit limit is {0}.", limit.ToString("C2"));

            // making output label visible
            outputLabel.Visible = true;
        } // CustomerCreditLimit method end
    }
}
