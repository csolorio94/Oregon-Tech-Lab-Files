namespace AirlineGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoecon = new System.Windows.Forms.RadioButton();
            this.rdofirst = new System.Windows.Forms.RadioButton();
            this.rsvbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoecon);
            this.groupBox1.Controls.Add(this.rdofirst);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Seating Area";
            // 
            // rdoecon
            // 
            this.rdoecon.AutoSize = true;
            this.rdoecon.Location = new System.Drawing.Point(119, 43);
            this.rdoecon.Name = "rdoecon";
            this.rdoecon.Size = new System.Drawing.Size(69, 17);
            this.rdoecon.TabIndex = 1;
            this.rdoecon.TabStop = true;
            this.rdoecon.Text = "Economy";
            this.rdoecon.UseVisualStyleBackColor = true;
            // 
            // rdofirst
            // 
            this.rdofirst.AutoSize = true;
            this.rdofirst.Location = new System.Drawing.Point(19, 43);
            this.rdofirst.Name = "rdofirst";
            this.rdofirst.Size = new System.Drawing.Size(72, 17);
            this.rdofirst.TabIndex = 0;
            this.rdofirst.TabStop = true;
            this.rdofirst.Text = "First Class";
            this.rdofirst.UseVisualStyleBackColor = true;
            // 
            // rsvbtn
            // 
            this.rsvbtn.Location = new System.Drawing.Point(73, 117);
            this.rsvbtn.Name = "rsvbtn";
            this.rsvbtn.Size = new System.Drawing.Size(98, 37);
            this.rsvbtn.TabIndex = 1;
            this.rsvbtn.Text = "Reserve";
            this.rsvbtn.UseVisualStyleBackColor = true;
            this.rsvbtn.Click += new System.EventHandler(this.rsvbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(183, 117);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(98, 37);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "&Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(73, 180);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(82, 17);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "First Class 1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(73, 203);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(82, 17);
            this.cb2.TabIndex = 4;
            this.cb2.Text = "First Class 2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(73, 226);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(82, 17);
            this.cb3.TabIndex = 5;
            this.cb3.Text = "First Class 3";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(73, 249);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(82, 17);
            this.cb4.TabIndex = 6;
            this.cb4.Text = "First Class 4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(73, 272);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(82, 17);
            this.cb5.TabIndex = 7;
            this.cb5.Text = "First Class 5";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(179, 180);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(79, 17);
            this.cb6.TabIndex = 8;
            this.cb6.Text = "Economy 1";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.CheckedChanged += new System.EventHandler(this.cb6_CheckedChanged);
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Location = new System.Drawing.Point(179, 203);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(79, 17);
            this.cb7.TabIndex = 9;
            this.cb7.Text = "Economy 2";
            this.cb7.UseVisualStyleBackColor = true;
            this.cb7.CheckedChanged += new System.EventHandler(this.cb7_CheckedChanged);
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(179, 226);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(79, 17);
            this.cb8.TabIndex = 10;
            this.cb8.Text = "Economy 3";
            this.cb8.UseVisualStyleBackColor = true;
            this.cb8.CheckedChanged += new System.EventHandler(this.cb8_CheckedChanged);
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.Location = new System.Drawing.Point(179, 249);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(79, 17);
            this.cb9.TabIndex = 11;
            this.cb9.Text = "Economy 4";
            this.cb9.UseVisualStyleBackColor = true;
            this.cb9.CheckedChanged += new System.EventHandler(this.cb9_CheckedChanged);
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Location = new System.Drawing.Point(179, 272);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(79, 17);
            this.cb10.TabIndex = 12;
            this.cb10.Text = "Economy 5";
            this.cb10.UseVisualStyleBackColor = true;
            this.cb10.CheckedChanged += new System.EventHandler(this.cb10_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.rsvbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(356, 317);
            this.Controls.Add(this.cb10);
            this.Controls.Add(this.cb9);
            this.Controls.Add(this.cb8);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.rsvbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Airline Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoecon;
        private System.Windows.Forms.RadioButton rdofirst;
        private System.Windows.Forms.Button rsvbtn;
        public System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb9;
        private System.Windows.Forms.CheckBox cb10;
    }
}

