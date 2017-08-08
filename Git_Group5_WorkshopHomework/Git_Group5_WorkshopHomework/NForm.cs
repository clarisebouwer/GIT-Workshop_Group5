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
    public partial class NForm : Form
    {
        public NForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(textBox1.Text);
            Random(num);
        }

        public void Random(int num)
        {
            int[] numbers;
            numbers = new int[num];
            int i;
            int j = 0;
            for (i = 1; i <= num; i++)
            {
                Random numb = new Random();
                int p = numb.Next(1, 100);

                numbers[j] = p;
                j++;

            }

            int m = numbers.Max();
            MessageBox.Show(Convert.ToString(m));
            label3.Text = Convert.ToString(m);
            
        }
    }
}
