using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grouping
{
    public partial class Grouped_Page : Form
    {
        public int StudentNumber;
        public string DepartmemtName;
        public Grouped_Page()
        {
            InitializeComponent();
        }

        private void Grouped_Page_Load(object sender, EventArgs e)
        {
            List<string> regNumber = new List<string>();


            int numbers = StudentNumber;
            string absolute_val = "U19ME100";
            string absolute_val2 = "U19ME10";
            string absolute_val3 = "U19ME1";


            for (int i = 1; i <= StudentNumber; i++)
            {
                string conCat = "";
                string toString = i.ToString();

                if (i < 10)
                {
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
            var shuffled = regNumber.OrderBy(x => Guid.NewGuid()).ToList();

            shuffled.Remove("U19ME1016");
            shuffled.Remove("U19ME1093");
            shuffled.Remove("U19ME1020");

            lstGroupA.Items.Add("U19ME1016 GROUP LEADER.");
            lstGroupB.Items.Add("U19ME1093 GROUP LEADER.");
            lstGroupE.Items.Add("U19ME1020 GROUP LEADER.");



            for (int i = 0; i < shuffled.Count; i++)
            {
                if (lstGroupA.Items.Count < 20)
                {
                    lstGroupA.Items.Add(shuffled[i]);
                }
                else if (lstGroupB.Items.Count < 20)
                {
                    lstGroupB.Items.Add(shuffled[i]);
                }
                else if (lstGroupC.Items.Count < 20)
                {
                    lstGroupC.Items.Add(shuffled[i]);
                }
                else if (lstGroupD.Items.Count < 20)
                {
                    lstGroupD.Items.Add(shuffled[i]);
                }

                else if (lstGroupE.Items.Count < 20)
                {
                    lstGroupE.Items.Add(shuffled[i]);
                }
                else if (lstGroupF.Items.Count < 20)
                {
                    lstGroupF.Items.Add(shuffled[i]);
                }

            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists("Group.txt"))
            {
                File.Delete("Group.txt");
            }

            TextWriter tw = new StreamWriter("Group.txt");

            tw.WriteLine("GROUP A");

            foreach (string s in lstGroupA.Items)
            {
                tw.WriteLine(s);
            }

            tw.WriteLine(" ");
            tw.WriteLine("GROUP B");

            foreach (string s in lstGroupB.Items)
            {
                tw.WriteLine(s);
            }

            tw.WriteLine(" ");
            tw.WriteLine("GROUP C");
            foreach (string s in lstGroupC.Items)
            {
                tw.WriteLine(s);
            }

            tw.WriteLine(" ");
            tw.WriteLine("GROUP D");
            foreach (string s in lstGroupD.Items)
            {
                tw.WriteLine(s);
            }

            tw.WriteLine(" ");
            tw.WriteLine("GROUP E");
            foreach (string s in lstGroupE.Items)
            {
                tw.WriteLine(s);
            }

            tw.WriteLine(" ");
            tw.WriteLine("GROUP F");
            foreach (string s in lstGroupF.Items)
            {
                tw.WriteLine(s);
            }


            tw.Close();

            MessageBox.Show("List Saved Successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
