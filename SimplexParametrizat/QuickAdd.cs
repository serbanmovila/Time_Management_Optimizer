using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexParametrizat
{
    public partial class QuickAdd : Form
    {
        public QuickAdd()
        {
            InitializeComponent();
        }

        private void quickBtn_Click(object sender, EventArgs e)
        {
            double v;
            bool valid = true;
            string[] values = valuesTxt.Text.Split(' ');
            for(int i=0;i<values.Length;i++)
                if(double.TryParse(values[i], out v) == false)
                        valid = false;

            if (valid == false)
            {
                MessageBox.Show("Input the numbers as instructed!", "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valuesTxt.Clear();
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                    Variables.coefs[i] = double.Parse(values[i]);
                MessageBox.Show("Success!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            valuesTxt.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
