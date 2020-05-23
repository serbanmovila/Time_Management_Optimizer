namespace SimplexParametrizat
{
    partial class Home
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
            this.varTxt = new System.Windows.Forms.TextBox();
            this.introd = new System.Windows.Forms.Label();
            this.varBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minRdo = new System.Windows.Forms.RadioButton();
            this.maxRdo = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // varTxt
            // 
            this.varTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varTxt.Location = new System.Drawing.Point(281, 79);
            this.varTxt.Name = "varTxt";
            this.varTxt.Size = new System.Drawing.Size(140, 30);
            this.varTxt.TabIndex = 0;
            // 
            // introd
            // 
            this.introd.AutoSize = true;
            this.introd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introd.Location = new System.Drawing.Point(12, 79);
            this.introd.Name = "introd";
            this.introd.Size = new System.Drawing.Size(241, 25);
            this.introd.TabIndex = 1;
            this.introd.Text = "Insert number of variables:";
            // 
            // varBtn
            // 
            this.varBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varBtn.Location = new System.Drawing.Point(281, 120);
            this.varBtn.Name = "varBtn";
            this.varBtn.Size = new System.Drawing.Size(140, 46);
            this.varBtn.TabIndex = 2;
            this.varBtn.Text = "Next";
            this.varBtn.UseVisualStyleBackColor = true;
            this.varBtn.Click += new System.EventHandler(this.varBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select problem type:";
            // 
            // minRdo
            // 
            this.minRdo.AutoSize = true;
            this.minRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRdo.Location = new System.Drawing.Point(281, 25);
            this.minRdo.Name = "minRdo";
            this.minRdo.Size = new System.Drawing.Size(64, 29);
            this.minRdo.TabIndex = 4;
            this.minRdo.TabStop = true;
            this.minRdo.Text = "min";
            this.minRdo.UseVisualStyleBackColor = true;
            this.minRdo.CheckedChanged += new System.EventHandler(this.minRdo_CheckedChanged);
            // 
            // maxRdo
            // 
            this.maxRdo.AutoSize = true;
            this.maxRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxRdo.Location = new System.Drawing.Point(351, 25);
            this.maxRdo.Name = "maxRdo";
            this.maxRdo.Size = new System.Drawing.Size(70, 29);
            this.maxRdo.TabIndex = 5;
            this.maxRdo.TabStop = true;
            this.maxRdo.Text = "max";
            this.maxRdo.UseVisualStyleBackColor = true;
            this.maxRdo.CheckedChanged += new System.EventHandler(this.maxRdo_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(17, 120);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(140, 46);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 178);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.maxRdo);
            this.Controls.Add(this.minRdo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varBtn);
            this.Controls.Add(this.introd);
            this.Controls.Add(this.varTxt);
            this.Name = "Home";
            this.Text = "Objective Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox varTxt;
        private System.Windows.Forms.Label introd;
        private System.Windows.Forms.Button varBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton minRdo;
        private System.Windows.Forms.RadioButton maxRdo;
        private System.Windows.Forms.Button backBtn;
    }
}

