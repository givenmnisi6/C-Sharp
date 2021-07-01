namespace Salesperson_s_Commission_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RevenuetextBox = new System.Windows.Forms.TextBox();
            this.PercentagetextBox = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue Sale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Commission Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Earned Commission:";
            // 
            // RevenuetextBox
            // 
            this.RevenuetextBox.Location = new System.Drawing.Point(220, 37);
            this.RevenuetextBox.Name = "RevenuetextBox";
            this.RevenuetextBox.Size = new System.Drawing.Size(128, 20);
            this.RevenuetextBox.TabIndex = 3;
            // 
            // PercentagetextBox
            // 
            this.PercentagetextBox.Location = new System.Drawing.Point(248, 91);
            this.PercentagetextBox.Name = "PercentagetextBox";
            this.PercentagetextBox.Size = new System.Drawing.Size(100, 20);
            this.PercentagetextBox.TabIndex = 4;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(130, 211);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(91, 23);
            this.Calculatebutton.TabIndex = 5;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(257, 211);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(91, 23);
            this.Exitbutton.TabIndex = 6;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Outputlabel
            // 
            this.Outputlabel.AutoSize = true;
            this.Outputlabel.Location = new System.Drawing.Point(245, 140);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(35, 13);
            this.Outputlabel.TabIndex = 7;
            this.Outputlabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 322);
            this.Controls.Add(this.Outputlabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.PercentagetextBox);
            this.Controls.Add(this.RevenuetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Salesperson’s Commission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RevenuetextBox;
        private System.Windows.Forms.TextBox PercentagetextBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Outputlabel;
    }
}

