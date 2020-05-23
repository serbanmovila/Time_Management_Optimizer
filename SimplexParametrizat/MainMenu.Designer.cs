namespace SimplexParametrizat
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.trueloginLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.tutorialBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(833, 11);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(87, 31);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(12, 12);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(455, 25);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome to ParametriX! Start solving by logging in.";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(717, 13);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(110, 27);
            this.passTxt.TabIndex = 4;
            this.passTxt.Text = "password";
            this.passTxt.Click += new System.EventHandler(this.passTxt_Click);
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(601, 13);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(110, 27);
            this.userTxt.TabIndex = 5;
            this.userTxt.Text = "username";
            this.userTxt.Click += new System.EventHandler(this.userTxt_Click);
            // 
            // trueloginLbl
            // 
            this.trueloginLbl.AutoSize = true;
            this.trueloginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueloginLbl.Location = new System.Drawing.Point(772, 16);
            this.trueloginLbl.Name = "trueloginLbl";
            this.trueloginLbl.Size = new System.Drawing.Size(21, 20);
            this.trueloginLbl.TabIndex = 6;
            this.trueloginLbl.Text = "w";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(601, 105);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(319, 57);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "START SOLVING!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tutorialBtn
            // 
            this.tutorialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialBtn.Location = new System.Drawing.Point(12, 105);
            this.tutorialBtn.Name = "tutorialBtn";
            this.tutorialBtn.Size = new System.Drawing.Size(321, 57);
            this.tutorialBtn.TabIndex = 8;
            this.tutorialBtn.Text = "BEGIN TUTORIAL";
            this.tutorialBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Not yet ready? Begin our tutorial!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Are you ready to start solving?";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutorialBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.trueloginLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.loginBtn);
            this.Name = "MainMenu";
            this.Text = "ParametriX";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button tutorialBtn;
        public System.Windows.Forms.Button loginBtn;
        public System.Windows.Forms.TextBox passTxt;
        public System.Windows.Forms.TextBox userTxt;
        public System.Windows.Forms.Label trueloginLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}