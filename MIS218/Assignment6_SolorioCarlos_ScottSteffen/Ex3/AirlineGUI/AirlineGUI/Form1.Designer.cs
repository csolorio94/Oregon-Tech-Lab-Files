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
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonEconomy = new System.Windows.Forms.RadioButton();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.cbFC1 = new System.Windows.Forms.CheckBox();
            this.cbFC2 = new System.Windows.Forms.CheckBox();
            this.cbFC3 = new System.Windows.Forms.CheckBox();
            this.cbFC4 = new System.Windows.Forms.CheckBox();
            this.cbFC5 = new System.Windows.Forms.CheckBox();
            this.cbEC1 = new System.Windows.Forms.CheckBox();
            this.cbEC2 = new System.Windows.Forms.CheckBox();
            this.cbEC3 = new System.Windows.Forms.CheckBox();
            this.cbEC4 = new System.Windows.Forms.CheckBox();
            this.cbEC5 = new System.Windows.Forms.CheckBox();
            this.buttonClearReservation = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.groupBoxFirst = new System.Windows.Forms.GroupBox();
            this.groupBoxEconomy = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioButtons.SuspendLayout();
            this.groupBoxFirst.SuspendLayout();
            this.groupBoxEconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonEconomy);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonFirst);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(615, 28);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(235, 106);
            this.groupBoxRadioButtons.TabIndex = 0;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Text = "Choose a Seating Area";
            // 
            // radioButtonEconomy
            // 
            this.radioButtonEconomy.AutoSize = true;
            this.radioButtonEconomy.Location = new System.Drawing.Point(140, 53);
            this.radioButtonEconomy.Name = "radioButtonEconomy";
            this.radioButtonEconomy.Size = new System.Drawing.Size(69, 17);
            this.radioButtonEconomy.TabIndex = 1;
            this.radioButtonEconomy.TabStop = true;
            this.radioButtonEconomy.Text = "Economy";
            this.radioButtonEconomy.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(29, 53);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFirst.TabIndex = 0;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.Text = "First Class";
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(668, 151);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(135, 53);
            this.buttonReserve.TabIndex = 1;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(668, 507);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 50);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // cbFC1
            // 
            this.cbFC1.AutoSize = true;
            this.cbFC1.Location = new System.Drawing.Point(6, 19);
            this.cbFC1.Name = "cbFC1";
            this.cbFC1.Size = new System.Drawing.Size(82, 17);
            this.cbFC1.TabIndex = 3;
            this.cbFC1.Text = "First Class 1";
            this.cbFC1.UseVisualStyleBackColor = true;
            // 
            // cbFC2
            // 
            this.cbFC2.AutoSize = true;
            this.cbFC2.Location = new System.Drawing.Point(113, 19);
            this.cbFC2.Name = "cbFC2";
            this.cbFC2.Size = new System.Drawing.Size(82, 17);
            this.cbFC2.TabIndex = 4;
            this.cbFC2.Text = "First Class 2";
            this.cbFC2.UseVisualStyleBackColor = true;
            // 
            // cbFC3
            // 
            this.cbFC3.AutoSize = true;
            this.cbFC3.Location = new System.Drawing.Point(6, 46);
            this.cbFC3.Name = "cbFC3";
            this.cbFC3.Size = new System.Drawing.Size(82, 17);
            this.cbFC3.TabIndex = 5;
            this.cbFC3.Text = "First Class 3";
            this.cbFC3.UseVisualStyleBackColor = true;
            // 
            // cbFC4
            // 
            this.cbFC4.AutoSize = true;
            this.cbFC4.Location = new System.Drawing.Point(113, 46);
            this.cbFC4.Name = "cbFC4";
            this.cbFC4.Size = new System.Drawing.Size(82, 17);
            this.cbFC4.TabIndex = 6;
            this.cbFC4.Text = "First Class 4";
            this.cbFC4.UseVisualStyleBackColor = true;
            // 
            // cbFC5
            // 
            this.cbFC5.AutoSize = true;
            this.cbFC5.Location = new System.Drawing.Point(62, 69);
            this.cbFC5.Name = "cbFC5";
            this.cbFC5.Size = new System.Drawing.Size(82, 17);
            this.cbFC5.TabIndex = 7;
            this.cbFC5.Text = "First Class 5";
            this.cbFC5.UseVisualStyleBackColor = true;
            // 
            // cbEC1
            // 
            this.cbEC1.AutoSize = true;
            this.cbEC1.Location = new System.Drawing.Point(6, 19);
            this.cbEC1.Name = "cbEC1";
            this.cbEC1.Size = new System.Drawing.Size(79, 17);
            this.cbEC1.TabIndex = 8;
            this.cbEC1.Text = "Economy 1";
            this.cbEC1.UseVisualStyleBackColor = true;
            // 
            // cbEC2
            // 
            this.cbEC2.AutoSize = true;
            this.cbEC2.Location = new System.Drawing.Point(111, 19);
            this.cbEC2.Name = "cbEC2";
            this.cbEC2.Size = new System.Drawing.Size(79, 17);
            this.cbEC2.TabIndex = 9;
            this.cbEC2.Text = "Economy 2";
            this.cbEC2.UseVisualStyleBackColor = true;
            // 
            // cbEC3
            // 
            this.cbEC3.AutoSize = true;
            this.cbEC3.Location = new System.Drawing.Point(6, 46);
            this.cbEC3.Name = "cbEC3";
            this.cbEC3.Size = new System.Drawing.Size(79, 17);
            this.cbEC3.TabIndex = 10;
            this.cbEC3.Text = "Economy 3";
            this.cbEC3.UseVisualStyleBackColor = true;
            // 
            // cbEC4
            // 
            this.cbEC4.AutoSize = true;
            this.cbEC4.Location = new System.Drawing.Point(111, 46);
            this.cbEC4.Name = "cbEC4";
            this.cbEC4.Size = new System.Drawing.Size(79, 17);
            this.cbEC4.TabIndex = 11;
            this.cbEC4.Text = "Economy 4";
            this.cbEC4.UseVisualStyleBackColor = true;
            // 
            // cbEC5
            // 
            this.cbEC5.AutoSize = true;
            this.cbEC5.Location = new System.Drawing.Point(70, 69);
            this.cbEC5.Name = "cbEC5";
            this.cbEC5.Size = new System.Drawing.Size(79, 17);
            this.cbEC5.TabIndex = 12;
            this.cbEC5.Text = "Economy 5";
            this.cbEC5.UseVisualStyleBackColor = true;
            // 
            // buttonClearReservation
            // 
            this.buttonClearReservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClearReservation.Location = new System.Drawing.Point(334, 372);
            this.buttonClearReservation.Name = "buttonClearReservation";
            this.buttonClearReservation.Size = new System.Drawing.Size(164, 54);
            this.buttonClearReservation.TabIndex = 13;
            this.buttonClearReservation.Text = "Clear Reservation";
            this.buttonClearReservation.UseVisualStyleBackColor = false;
            this.buttonClearReservation.Click += new System.EventHandler(this.buttonClearReservation_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(118, 81);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(222, 18);
            this.MessageLabel.TabIndex = 14;
            this.MessageLabel.Text = "Welcome to the best airline ever!";
            // 
            // groupBoxFirst
            // 
            this.groupBoxFirst.Controls.Add(this.cbFC1);
            this.groupBoxFirst.Controls.Add(this.cbFC2);
            this.groupBoxFirst.Controls.Add(this.cbFC3);
            this.groupBoxFirst.Controls.Add(this.cbFC4);
            this.groupBoxFirst.Controls.Add(this.cbFC5);
            this.groupBoxFirst.Location = new System.Drawing.Point(177, 254);
            this.groupBoxFirst.Name = "groupBoxFirst";
            this.groupBoxFirst.Size = new System.Drawing.Size(228, 95);
            this.groupBoxFirst.TabIndex = 15;
            this.groupBoxFirst.TabStop = false;
            this.groupBoxFirst.Text = "First Class";
            // 
            // groupBoxEconomy
            // 
            this.groupBoxEconomy.Controls.Add(this.cbEC1);
            this.groupBoxEconomy.Controls.Add(this.cbEC2);
            this.groupBoxEconomy.Controls.Add(this.cbEC3);
            this.groupBoxEconomy.Controls.Add(this.cbEC4);
            this.groupBoxEconomy.Controls.Add(this.cbEC5);
            this.groupBoxEconomy.Location = new System.Drawing.Point(421, 254);
            this.groupBoxEconomy.Name = "groupBoxEconomy";
            this.groupBoxEconomy.Size = new System.Drawing.Size(205, 95);
            this.groupBoxEconomy.TabIndex = 16;
            this.groupBoxEconomy.TabStop = false;
            this.groupBoxEconomy.Text = "Economy";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonReserve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirlineGUI.Properties.Resources.AirplaneOutline2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(957, 627);
            this.Controls.Add(this.groupBoxEconomy);
            this.Controls.Add(this.groupBoxFirst);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.buttonClearReservation);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Airline Reservation";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.groupBoxFirst.ResumeLayout(false);
            this.groupBoxFirst.PerformLayout();
            this.groupBoxEconomy.ResumeLayout(false);
            this.groupBoxEconomy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonEconomy;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.Button buttonReserve;
        public System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox cbFC1;
        private System.Windows.Forms.CheckBox cbFC2;
        private System.Windows.Forms.CheckBox cbFC3;
        private System.Windows.Forms.CheckBox cbFC4;
        private System.Windows.Forms.CheckBox cbFC5;
        private System.Windows.Forms.CheckBox cbEC1;
        private System.Windows.Forms.CheckBox cbEC2;
        private System.Windows.Forms.CheckBox cbEC3;
        private System.Windows.Forms.CheckBox cbEC4;
        private System.Windows.Forms.CheckBox cbEC5;
        private System.Windows.Forms.Button buttonClearReservation;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.GroupBox groupBoxFirst;
        private System.Windows.Forms.GroupBox groupBoxEconomy;
    }
}

