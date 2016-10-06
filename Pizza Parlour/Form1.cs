using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class Form1 : Form
    {
        const double LABOURCOST = 1.00;
        const double STORERATE = 1.50;
        const double PIZZACOST = 0.50;
        int pizzaSize;
        double totalCost;

        public Form1()
        {
            InitializeComponent();
        }


        private void calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                pizzaSize = Convert.ToInt32(inputSize.Text);
                totalCost = pizzaSize * PIZZACOST + STORERATE + LABOURCOST;

                outputLabel.Text = "The cost of the pizza is " + totalCost.ToString("C");
            }
            catch
            {
                outputLabel.Text = "The pizza size must be in whole numbers only";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
