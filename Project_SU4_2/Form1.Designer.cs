namespace Project_SU4
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
            this.LoantextBox = new System.Windows.Forms.TextBox();
            this.MonthstextBox = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter loan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter months:";
            // 
            // LoantextBox
            // 
            this.LoantextBox.Location = new System.Drawing.Point(194, 52);
            this.LoantextBox.Name = "LoantextBox";
            this.LoantextBox.Size = new System.Drawing.Size(100, 20);
            this.LoantextBox.TabIndex = 2;
            // 
            // MonthstextBox
            // 
            this.MonthstextBox.Location = new System.Drawing.Point(194, 92);
            this.MonthstextBox.Name = "MonthstextBox";
            this.MonthstextBox.Size = new System.Drawing.Size(100, 20);
            this.MonthstextBox.TabIndex = 3;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(145, 304);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(69, 33);
            this.Calculatebutton.TabIndex = 4;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(230, 304);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 33);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(41, 138);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(384, 160);
            this.OutputlistBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.MonthstextBox);
            this.Controls.Add(this.LoantextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Project_SU4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoantextBox;
        private System.Windows.Forms.TextBox MonthstextBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ListBox OutputlistBox;
    }
}

