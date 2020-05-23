namespace SimplexParametrizat
{
    partial class QuickAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.valuesTxt = new System.Windows.Forms.TextBox();
            this.quickBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert each coefficient, delimited by a single space bar";
            // 
            // valuesTxt
            // 
            this.valuesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesTxt.Location = new System.Drawing.Point(36, 71);
            this.valuesTxt.Name = "valuesTxt";
            this.valuesTxt.Size = new System.Drawing.Size(473, 30);
            this.valuesTxt.TabIndex = 1;
            // 
            // quickBtn
            // 
            this.quickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickBtn.Location = new System.Drawing.Point(396, 119);
            this.quickBtn.Name = "quickBtn";
            this.quickBtn.Size = new System.Drawing.Size(113, 36);
            this.quickBtn.TabIndex = 2;
            this.quickBtn.Text = "OK";
            this.quickBtn.UseVisualStyleBackColor = true;
            this.quickBtn.Click += new System.EventHandler(this.quickBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(36, 119);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(113, 36);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(529, 71);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 30);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // QuickAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 188);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.quickBtn);
            this.Controls.Add(this.valuesTxt);
            this.Controls.Add(this.label1);
            this.Name = "QuickAdd";
            this.Text = "Quick Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valuesTxt;
        private System.Windows.Forms.Button quickBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}