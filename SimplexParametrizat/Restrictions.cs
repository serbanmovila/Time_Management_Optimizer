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
    public partial class Restrictions : Form
    {
        public static double[,] restcoef;
        public static string[] ineq;
        public static double[] free;
        public static double[] param;
        public Restrictions()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Variables var = new Variables();
            var.FormClosed += new FormClosedEventHandler(var_FormClosed);
            this.Hide();
            var.Show();
        }

        private void var_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private string[] removeEmptyLines(string[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (string.IsNullOrWhiteSpace(str[i]) == true)
                {
                    for (int j = i; j < str.Length - 1; j++)
                        str[j] = str[j + 1];
                    count++;
                }
            Array.Resize(ref str, str.Length - count);
            return str;
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            bool structure = true;
            string[] str = restRtb.Text.Split('\n');
            str = removeEmptyLines(str);
            string[] aux;
            string[,] elems = new string[str.Length, Variables.coefs.Length + 3];
            for (int i = 0; i < str.Length; i++)
            {
                aux = str[i].Split(' ');
                if (aux.Length != elems.GetLength(1))
                {
                    structure = false;
                    break;
                }
                else
                    for (int j = 0; j < aux.Length; j++)
                        elems[i, j] = aux[j];
            }

            double x;
            for (int i = 0; i < elems.GetLength(0); i++)
            {
                for (int j = 0; j < elems.GetLength(1) - 3; j++)
                    if (double.TryParse(elems[i, j], out x) == false)
                        structure = false;
                if (elems[i, elems.GetLength(1) - 3] != ">=" && elems[i, elems.GetLength(1) - 3] != "=" && elems[i, elems.GetLength(1) - 3] != "<=")
                    structure = false;
                for (int j = elems.GetLength(1) - 2; j < elems.GetLength(1); j++)
                    if (double.TryParse(elems[i, j], out x) == false)
                        structure = false;
            }

            if (structure == true)
            {
                restcoef = new double[str.Length, Variables.coefs.Length + 1];
                ineq = new string[str.Length];
                free = new double[str.Length];
                param = new double[str.Length];
                string[] line;

                for (int i = 0; i < restcoef.GetLength(0); i++)
                {
                    line = str[i].Split(' ');
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (j < line.Length - 3)
                            restcoef[i, j] = double.Parse(line[j]);
                        else if (j == line.Length - 3)
                            ineq[i] = line[j];
                        else if (j == line.Length - 2)
                            free[i] = double.Parse(line[j]);
                        else
                            param[i] = double.Parse(line[j]);
                    }
                }

                MessageBox.Show("The restrictions have successfully been inserted!");
                Result res = new Result();
                res.FormClosed += new FormClosedEventHandler(var_FormClosed);
                this.Hide();
                res.Show();
            }
            else
                MessageBox.Show("You have not respected the input rules!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Restrictions_Load(object sender, EventArgs e)
        {
            restLbl.Text = "";
            restLbl.Text += "Insert your restriction coefficients! \n\nRules:\n\n1. One restriction per line\n2. Each coefficient delimited\nby a single space bar\n3. Inequality or equality signs written\nas >=, = or <=";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the box?", "Confirmation message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                restRtb.Clear();
        }

        private void exampleBtn_Click(object sender, EventArgs e)
        {
            ExampleRestrictions ex = new ExampleRestrictions();
            ex.Show();
        }
    }
}
