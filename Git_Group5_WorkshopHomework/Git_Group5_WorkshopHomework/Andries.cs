using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Group5_WorkshopHomework
{
    public partial class Andries : Form
    {
        public Andries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0;
                // Get how many random numbers the user wants
                int myRandomNumbers1 = Convert.ToInt16(textBox1.Text);
                List<int> data1 = new List<int>();


                // Create the random object
                Random rand1 = new Random();

                for (int i = 0; i < myRandomNumbers1; i++)
                {
                    // Create the list of random numbers
                    result1 = rand1.Next(1, 101);
                    data1.Add(result1);
                }
                MessageBox.Show("The sum of the random numbers is:" + data1.Average().ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
