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
    public partial class Qform : Form
    {
        testInterger testint = new testInterger();
        public Qform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "Quintin Jacobs. \n" +
                "26147629. \n" +
                "Die is my derde jaar op by die nwu. \n" +
                "Ek wil graag my honours doen";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                // Get how many random numbers the user wants
                int myRandomNumbers = Convert.ToInt16(txtnum.Text);
                List<int> data = new List<int>();

                if (testint.checkint(myRandomNumbers) == true)
                {

                    // Create the random object
                    Random rand = new Random();

                    for (int i = 0; i < myRandomNumbers; i++)
                    {
                        // Create the list of random numbers
                        result = rand.Next(1, 101);
                        data.Add(result);
                    }
                    MessageBox.Show("The sum of the random numbers is:" + data.Sum().ToString());
                }
                else
                    MessageBox.Show("Please enter a valid number");
            }
            catch (FormatException )
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void txtnum_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
        }

        private void Qform_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }
    }
}
