namespace TwoLargestNum
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.largestLbl = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.secLargestLbl = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.recentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 127);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(120, 127);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Number:";
            // 
            // largestLbl
            // 
            this.largestLbl.AutoSize = true;
            this.largestLbl.Location = new System.Drawing.Point(47, 79);
            this.largestLbl.Name = "largestLbl";
            this.largestLbl.Size = new System.Drawing.Size(148, 13);
            this.largestLbl.TabIndex = 3;
            this.largestLbl.Text = "The First Largest Number is: 0";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(145, 17);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(118, 20);
            this.numBox.TabIndex = 4;
            // 
            // secLargestLbl
            // 
            this.secLargestLbl.AutoSize = true;
            this.secLargestLbl.Location = new System.Drawing.Point(47, 102);
            this.secLargestLbl.Name = "secLargestLbl";
            this.secLargestLbl.Size = new System.Drawing.Size(164, 13);
            this.secLargestLbl.TabIndex = 5;
            this.secLargestLbl.Text = "The Second Largest number is: 0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Numbers";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // recentLbl
            // 
            this.recentLbl.AutoSize = true;
            this.recentLbl.Location = new System.Drawing.Point(47, 53);
            this.recentLbl.Name = "recentLbl";
            this.recentLbl.Size = new System.Drawing.Size(147, 13);
            this.recentLbl.TabIndex = 7;
            this.recentLbl.Text = "Number of Entries (Max 10): 0";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 168);
            this.Controls.Add(this.recentLbl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.secLargestLbl);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.largestLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Find the two largest numbers!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label largestLbl;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label secLargestLbl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label recentLbl;
    }
}

