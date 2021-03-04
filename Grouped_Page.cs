using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grouping
{
    public partial class Grouped_Page : Form
    {
        public int StudentNumber;
        public Grouped_Page()
        {
            InitializeComponent();
        }

        private void Grouped_Page_Load(object sender, EventArgs e)
        {
            int numbers = StudentNumber;
            string absolute_val = "U19ME100";
            string absolute_val2 = "U19ME10";
            string absolute_val3 = "U19ME1";

            List<string> regNumber = new List<string>();

            for (int i = 1; i <= StudentNumber; i++)
            {
                string conCat = "";
                string toString = i.ToString();

                if (i < 10) {
                    conCat = absolute_val + toString;
                }
                else if ((i >= 10) && (i < 100))
                {
                    conCat = absolute_val2 + toString;
                }
                else 
                {
                    conCat = absolute_val3 + toString;
                }

                regNumber.Add(conCat);

               
            }
            foreach(string item in regNumber)
            {

            }
        }
    }
}
