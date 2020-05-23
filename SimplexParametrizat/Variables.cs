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
    public partial class Variables : Form
    {
        public static int i;
        public static int variables;
        public static double[] coefs;

        private string current;
        private string strcoef;
        public Variables()
        {
            InitializeComponent();
        }

        private void Variables_Load(object sender, EventArgs e)
        {
            indexCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            current = currentLbl.Text;
            strcoef = coefLbl.Text;

            variables = Home.variables;
            coefs = new double[variables];
            for (int i = 1; i <= coefs.Length; i++)
                this.indexCmb.Items.Add(i);
            indexCmb.SelectedItem = indexCmb.Items[0];
            currentTxt.Text = coefs[int.Parse(indexCmb.SelectedItem.ToString())-1].ToString();

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            double dbl;
            if (double.TryParse(coefTxt.Text,out dbl) == false)
            {
                MessageBox.Show("Insert a real number!", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                i = int.Parse(indexCmb.SelectedItem.ToString()) - 1;
                if (i < variables)
                    if (coefTxt.Text != "")
                    {
                        coefs[i] = double.Parse(coefTxt.Text);
                        currentTxt.Text = coefs[int.Parse(indexCmb.SelectedItem.ToString()) - 1].ToString();
                        MessageBox.Show("The value " + coefs[i] + " has been successfully assigned to variable number " + (i + 1));
                    }
                    else
                        MessageBox.Show("Insert a value!");
            }
        }

        private void indexCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLbl.Text = current;
            coefLbl.Text = strcoef;

            currentLbl.Text += indexCmb.SelectedItem.ToString() + " is:";
            currentTxt.Text = coefs[int.Parse(indexCmb.SelectedItem.ToString())-1].ToString();
            coefLbl.Text += indexCmb.SelectedItem.ToString() + ":";
        }

        private void quickBtn_Click(object sender, EventArgs e)
        {
            QuickAdd quick = new QuickAdd();
            quick.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.FormClosed += new FormClosedEventHandler(res_FormClosed);
            this.Hide();
            h.Show();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Restrictions res = new Restrictions();
            res.FormClosed += new FormClosedEventHandler(res_FormClosed);
            this.Hide();
            res.Show();
        }

        private void res_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
