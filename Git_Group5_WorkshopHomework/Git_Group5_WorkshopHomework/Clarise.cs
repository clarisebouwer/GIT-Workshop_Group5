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
    public partial class Clarise : Form
    {
        public Clarise()
        {
            InitializeComponent();
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            //List
            List<int> randomList = new List<int>();
            int n = Convert.ToInt16(txtRan.Text);
            int r;
            Random rand = new Random();

            for (int i = 0; i <= n; i++)
            {
                r = rand.Next(1, 50);
                randomList.Add(r);
            }
            //Ans
            MessageBox.Show((randomList.Max() - randomList.Min()).ToString());
        }

        private void txtRan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
