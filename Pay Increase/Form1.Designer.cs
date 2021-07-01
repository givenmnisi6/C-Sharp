namespace Pay_Increase
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
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the teacher\'s initial compensation:\r\n";
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(281, 64);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(100, 20);
            this.InputtextBox.TabIndex = 1;
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(75, 112);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(191, 173);
            this.OutputlistBox.TabIndex = 2;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(334, 112);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(90, 43);
            this.Calculatebutton.TabIndex = 3;
            this.Calculatebutton.Text = "Show Pay";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(334, 242);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(90, 43);
            this.Exitbutton.TabIndex = 4;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 344);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Teacher\'s Pay Increase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.ListBox OutputlistBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

