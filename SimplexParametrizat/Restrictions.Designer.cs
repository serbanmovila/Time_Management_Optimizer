namespace SimplexParametrizat
{
    partial class Restrictions
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
            this.backBtn = new System.Windows.Forms.Button();
            this.restRtb = new System.Windows.Forms.RichTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.restLbl = new System.Windows.Forms.Label();
            this.exampleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(26, 336);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(166, 29);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // restRtb
            // 
            this.restRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRtb.Location = new System.Drawing.Point(426, 12);
            this.restRtb.Name = "restRtb";
            this.restRtb.Size = new System.Drawing.Size(495, 298);
            this.restRtb.TabIndex = 1;
            this.restRtb.Text = "";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(755, 336);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(166, 29);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Show Result";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(426, 336);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(166, 29);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // restLbl
            // 
            this.restLbl.AutoSize = true;
            this.restLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restLbl.Location = new System.Drawing.Point(23, 12);
            this.restLbl.Name = "restLbl";
            this.restLbl.Size = new System.Drawing.Size(64, 25);
            this.restLbl.TabIndex = 5;
            this.restLbl.Text = "label1";
            // 
            // exampleBtn
            // 
            this.exampleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleBtn.Location = new System.Drawing.Point(28, 272);
            this.exampleBtn.Name = "exampleBtn";
            this.exampleBtn.Size = new System.Drawing.Size(370, 38);
            this.exampleBtn.TabIndex = 6;
            this.exampleBtn.Text = "Click for example";
            this.exampleBtn.UseVisualStyleBackColor = true;
            this.exampleBtn.Click += new System.EventHandler(this.exampleBtn_Click);
            // 
            // Restrictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 388);
            this.Controls.Add(this.exampleBtn);
            this.Controls.Add(this.restLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.restRtb);
            this.Controls.Add(this.backBtn);
            this.Name = "Restrictions";
            this.Text = "Restrictions";
            this.Load += new System.EventHandler(this.Restrictions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.RichTextBox restRtb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label restLbl;
        private System.Windows.Forms.Button exampleBtn;
    }
}