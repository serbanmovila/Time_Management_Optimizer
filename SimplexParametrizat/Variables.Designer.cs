namespace SimplexParametrizat
{
    partial class Variables
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
            this.coefTxt = new System.Windows.Forms.TextBox();
            this.coefLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.currentTxt = new System.Windows.Forms.TextBox();
            this.indexLbl = new System.Windows.Forms.Label();
            this.currentLbl = new System.Windows.Forms.Label();
            this.indexCmb = new System.Windows.Forms.ComboBox();
            this.quickBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coefTxt
            // 
            this.coefTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefTxt.Location = new System.Drawing.Point(499, 142);
            this.coefTxt.Name = "coefTxt";
            this.coefTxt.Size = new System.Drawing.Size(122, 30);
            this.coefTxt.TabIndex = 0;
            // 
            // coefLbl
            // 
            this.coefLbl.AutoSize = true;
            this.coefLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefLbl.Location = new System.Drawing.Point(57, 145);
            this.coefLbl.Name = "coefLbl";
            this.coefLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.coefLbl.Size = new System.Drawing.Size(354, 25);
            this.coefLbl.TabIndex = 1;
            this.coefLbl.Text = "Insert the coefficient of variable number ";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(499, 197);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(122, 35);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // currentTxt
            // 
            this.currentTxt.Enabled = false;
            this.currentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTxt.Location = new System.Drawing.Point(499, 85);
            this.currentTxt.Name = "currentTxt";
            this.currentTxt.Size = new System.Drawing.Size(122, 30);
            this.currentTxt.TabIndex = 5;
            // 
            // indexLbl
            // 
            this.indexLbl.AutoSize = true;
            this.indexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLbl.Location = new System.Drawing.Point(247, 33);
            this.indexLbl.Name = "indexLbl";
            this.indexLbl.Size = new System.Drawing.Size(212, 25);
            this.indexLbl.TabIndex = 6;
            this.indexLbl.Text = "Choose variable index:";
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(87, 88);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(309, 25);
            this.currentLbl.TabIndex = 7;
            this.currentLbl.Text = "The coefficient of variable number ";
            // 
            // indexCmb
            // 
            this.indexCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexCmb.FormattingEnabled = true;
            this.indexCmb.Location = new System.Drawing.Point(499, 30);
            this.indexCmb.Name = "indexCmb";
            this.indexCmb.Size = new System.Drawing.Size(122, 33);
            this.indexCmb.TabIndex = 8;
            this.indexCmb.SelectedIndexChanged += new System.EventHandler(this.indexCmb_SelectedIndexChanged);
            // 
            // quickBtn
            // 
            this.quickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickBtn.Location = new System.Drawing.Point(52, 200);
            this.quickBtn.Name = "quickBtn";
            this.quickBtn.Size = new System.Drawing.Size(399, 32);
            this.quickBtn.TabIndex = 9;
            this.quickBtn.Text = "Quick Add";
            this.quickBtn.UseVisualStyleBackColor = true;
            this.quickBtn.Click += new System.EventHandler(this.quickBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(450, 271);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(171, 30);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(52, 271);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 30);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Variables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 326);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.quickBtn);
            this.Controls.Add(this.indexCmb);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.indexLbl);
            this.Controls.Add(this.currentTxt);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.coefLbl);
            this.Controls.Add(this.coefTxt);
            this.Name = "Variables";
            this.Text = "Objective Coefficients";
            this.Load += new System.EventHandler(this.Variables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coefTxt;
        private System.Windows.Forms.Label coefLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label indexLbl;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Button quickBtn;
        public System.Windows.Forms.TextBox currentTxt;
        public System.Windows.Forms.ComboBox indexCmb;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
    }
}