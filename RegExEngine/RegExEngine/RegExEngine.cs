using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExEngine
{
    public partial class RegExEngine : Form
    {
        public RegExEngine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myRegExpr = textBox1.Text;
            //MessageBox.Show(myRegExpr);
            NFA myNFA = new NFA(myRegExpr);

            if (!myNFA.isValidInput())
            {
                // not a valid input
                MessageBox.Show("You sumbited an invalid Regular Expression");
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("You submitted a valid Regular Expression");

                //myNFA.myParser();
            }
        }
    }
}
