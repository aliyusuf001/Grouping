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
    public partial class Form1 : Form
    {
        public int studentNumber;
        public string departmemtName;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if((txtStudentNumber.Text == String.Empty) || (selectDept.Text == String.Empty))
            {
                MessageBox.Show("Please fill all the input fields", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                try
                {
                    studentNumber = Convert.ToInt32(txtStudentNumber.Text);
                    departmemtName = Convert.ToString(selectDept.Text);

                    Grouped_Page gp = new Grouped_Page
                    {
                        StudentNumber = studentNumber

                    };
                    Grouped_Page gp1 = new Grouped_Page
                    {
                        DepartmemtName = departmemtName

                    };

                    this.Hide();
                    gp.Show();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message, "Warning");
                    txtStudentNumber.Text = "";
                }
            }
            
        }


    }
}
