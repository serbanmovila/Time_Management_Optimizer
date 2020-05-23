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
    
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            trueloginLbl.Hide();
            passTxt.PasswordChar = '*';
        }

        private void userTxt_Click(object sender, EventArgs e)
        {
            if(userTxt.Text == "username")
                userTxt.Text = "";
        }

        private void passTxt_Click(object sender, EventArgs e)
        {
            if(passTxt.Text == "password")
                passTxt.Text = "";
        }
        public void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginBtn.Text == "Login")
                if (userTxt.Text != "" && passTxt.Text != "")
                    if (userTxt.Text == "admin" && passTxt.Text == "1234")
                    {
                        userTxt.Hide();
                        passTxt.Hide();
                        trueloginLbl.Text = userTxt.Text;
                        trueloginLbl.Show();
                        loginBtn.Text = "Logout";
                    }
                    else
                    {
                        MessageBox.Show("Wrong credentials!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        userTxt.Text = "username";
                        passTxt.Text = "password";
                    }
                else
                {
                    MessageBox.Show("Username or password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userTxt.Text = "username";
                    passTxt.Text = "password";
                }
            else
            {
                userTxt.Text = "username";
                passTxt.Text = "password";
                userTxt.Show();
                passTxt.Show();
                loginBtn.Text = "Login";
                trueloginLbl.Hide();
            }
        }

        private void h_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (loginBtn.Text == "Logout")
            {
                Home h = new Home();
                h.FormClosed += new FormClosedEventHandler(h_FormClosed);
                this.Hide();
                h.Show();
            }
            else
                MessageBox.Show("You need to be logged in to start solving!", "Log in first!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}