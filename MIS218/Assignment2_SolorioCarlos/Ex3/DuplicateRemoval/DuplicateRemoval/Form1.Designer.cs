namespace DuplicateRemoval
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
            this.label1 = new System.Windows.Forms.Label();
            this.sentenceBox = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.duplicatesBox = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Sentence";
            // 
            // sentenceBox
            // 
            this.sentenceBox.Location = new System.Drawing.Point(52, 35);
            this.sentenceBox.Name = "sentenceBox";
            this.sentenceBox.Size = new System.Drawing.Size(203, 20);
            this.sentenceBox.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(12, 73);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "&Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(210, 73);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // duplicatesBox
            // 
            this.duplicatesBox.Location = new System.Drawing.Point(22, 102);
            this.duplicatesBox.Name = "duplicatesBox";
            this.duplicatesBox.Size = new System.Drawing.Size(245, 147);
            this.duplicatesBox.TabIndex = 4;
            this.duplicatesBox.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(111, 73);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.checkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.duplicatesBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.sentenceBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Duplicate Word Removal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sentenceBox;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RichTextBox duplicatesBox;
        private System.Windows.Forms.Button clearBtn;
    }
}

