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
    public partial class Rform : Form
    {
        testInterger testint = new testInterger();
        public Rform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = "Naam: Ronan Van:de Wee \n" +
                "Studente nommer:26147629. \n" +
                "Ek is n derde jaar student aan die universiteit NWU(Potch) \n" +
                "Ek woon in Potchefstroom, Contact details: 0835563047";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                // How many random numbers the user wants?
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
                        data.Aggregate(GCD);
                    }
                    MessageBox.Show("The GCD of the random numbers is:" + data.Aggregate(GCD).ToString());
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

        private void Rform_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }
    }
}
