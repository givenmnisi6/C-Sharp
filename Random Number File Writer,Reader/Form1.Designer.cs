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
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.Readbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number:\r\n";
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(135, 46);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(109, 20);
            this.InputtextBox.TabIndex = 1;
            // 
            // Readbutton
            // 
            this.Readbutton.Enabled = false;
            this.Readbutton.Location = new System.Drawing.Point(135, 101);
            this.Readbutton.Name = "Readbutton";
            this.Readbutton.Size = new System.Drawing.Size(109, 23);
            this.Readbutton.TabIndex = 2;
            this.Readbutton.Text = "Read";
            this.Readbutton.UseVisualStyleBackColor = true;
            this.Readbutton.Click += new System.EventHandler(this.Readbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(135, 72);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(109, 23);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(12, 149);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(547, 238);
            this.OutputlistBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 438);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Readbutton);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.Button Readbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ListBox OutputlistBox;
    }
}

