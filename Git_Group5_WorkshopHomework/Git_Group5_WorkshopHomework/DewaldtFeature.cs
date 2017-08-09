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
    public partial class DewaldtFeature : Form
    {
        public DewaldtFeature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> data = new List<int>();
            Random rand = new Random();
            int numn = Convert.ToInt32(textBox2.Text);
            int randomn;


            for (int i = 0; i < numn; i++)
            {
                randomn = rand.Next(0, 20);
                data.Add(randomn);
                label1.Text = Convert.ToString("Random number:" + " " + randomn);
            }
            MessageBox.Show("The Min is:" + " " + data.Min().ToString());
        }
    }
}
