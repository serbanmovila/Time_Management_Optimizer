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
    public partial class Home : Form
    {
        public static int variables;
        public static string type;
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void var_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void varBtn_Click(object sender, EventArgs e)
        {
            int tpr;
            if (int.TryParse(varTxt.Text, out tpr) == false)
                MessageBox.Show("Insert a strictly positive integer!", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.Parse(varTxt.Text) < 1)
                MessageBox.Show("Insert a strictly positive integer!", "Wrong number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maxRdo.Checked == false && minRdo.Checked == false)
                MessageBox.Show("Select one option (min/max)!", "No option selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.Parse(varTxt.Text) < 99)
                {
                    variables = int.Parse(varTxt.Text);
                    Variables var = new Variables();
                    var.FormClosed += new FormClosedEventHandler(var_FormClosed);
                    this.Hide();
                    var.Show();
                }
                else
                    MessageBox.Show("Insert a number below 99!");
        }

        private void maxRdo_CheckedChanged(object sender, EventArgs e)
        {
            type = "max";
        }

        private void minRdo_CheckedChanged(object sender, EventArgs e)
        {
            type = "min";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.FormClosed += new FormClosedEventHandler(var_FormClosed);
            this.Hide();
            m.userTxt.Text = "admin";
            m.passTxt.Text = "1234";
            m.userTxt.Hide();
            m.passTxt.Hide();
            m.trueloginLbl.Text = "admin";
            m.loginBtn.Text = "Logout";
            m.Show();
            m.trueloginLbl.Show();
        }
    }
}
