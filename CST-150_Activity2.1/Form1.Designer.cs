namespace CST_150_Activity2._1
{
    partial class Form1
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
            this.wtLbLbl = new System.Windows.Forms.Label();
            this.wtLbTxt = new System.Windows.Forms.TextBox();
            this.wtKgLbl = new System.Windows.Forms.Label();
            this.wtKgTxt = new System.Windows.Forms.TextBox();
            this.wtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wtLbLbl
            // 
            this.wtLbLbl.AutoSize = true;
            this.wtLbLbl.Location = new System.Drawing.Point(12, 9);
            this.wtLbLbl.Name = "wtLbLbl";
            this.wtLbLbl.Size = new System.Drawing.Size(175, 13);
            this.wtLbLbl.TabIndex = 0;
            this.wtLbLbl.Text = "Please enter your weight in pounds:";
            // 
            // wtLbTxt
            // 
            this.wtLbTxt.Location = new System.Drawing.Point(193, 12);
            this.wtLbTxt.Name = "wtLbTxt";
            this.wtLbTxt.Size = new System.Drawing.Size(100, 20);
            this.wtLbTxt.TabIndex = 1;
            // 
            // wtKgLbl
            // 
            this.wtKgLbl.AutoSize = true;
            this.wtKgLbl.Location = new System.Drawing.Point(12, 57);
            this.wtKgLbl.Name = "wtKgLbl";
            this.wtKgLbl.Size = new System.Drawing.Size(125, 13);
            this.wtKgLbl.TabIndex = 2;
            this.wtKgLbl.Text = "Your weight in Kilograms:";
            // 
            // wtKgTxt
            // 
            this.wtKgTxt.Location = new System.Drawing.Point(143, 50);
            this.wtKgTxt.Name = "wtKgTxt";
            this.wtKgTxt.Size = new System.Drawing.Size(100, 20);
            this.wtKgTxt.TabIndex = 3;
            // 
            // wtBtn
            // 
            this.wtBtn.Location = new System.Drawing.Point(112, 128);
            this.wtBtn.Name = "wtBtn";
            this.wtBtn.Size = new System.Drawing.Size(75, 23);
            this.wtBtn.TabIndex = 4;
            this.wtBtn.Text = "Result";
            this.wtBtn.UseVisualStyleBackColor = true;
            this.wtBtn.Click += new System.EventHandler(this.wtBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 210);
            this.Controls.Add(this.wtBtn);
            this.Controls.Add(this.wtKgTxt);
            this.Controls.Add(this.wtKgLbl);
            this.Controls.Add(this.wtLbTxt);
            this.Controls.Add(this.wtLbLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wtLbLbl;
        private System.Windows.Forms.TextBox wtLbTxt;
        private System.Windows.Forms.Label wtKgLbl;
        private System.Windows.Forms.TextBox wtKgTxt;
        private System.Windows.Forms.Button wtBtn;
    }
}

