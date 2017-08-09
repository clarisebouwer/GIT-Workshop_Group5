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
    public class testInterger
    {
        public bool checkint(int i)
        {
            try
            {
                if (i > 5 && i < 20)
                    return true;
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
