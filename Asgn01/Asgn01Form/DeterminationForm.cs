using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EigibilityClass;

namespace Asgn01Form
{
    public partial class DeterminationForm : Form
    {
        public DeterminationForm()
        {
            InitializeComponent();
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestEligibility test = new TestEligibility(naturalCitizen.Checked,
                int.Parse(birthYear.Text), int.Parse(yrsInUS.Text), int.Parse(terms.Text), rebelled.Checked);
            if (test.isEligible())
            {
                resultLabel.Visible = true;
               
            }
            else
            {
                resultLabel.Text = "You are not eligible to be the US president.";
                resultLabel.Visible = true;
            }
        }
    }
}
