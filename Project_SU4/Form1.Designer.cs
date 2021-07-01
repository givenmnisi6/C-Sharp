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
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Readbutton = new System.Windows.Forms.Button();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(72, 82);
            this.InputtextBox.Multiline = true;
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(143, 121);
            this.InputtextBox.TabIndex = 1;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(115, 224);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(100, 33);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Readbutton
            // 
            this.Readbutton.Location = new System.Drawing.Point(234, 224);
            this.Readbutton.Name = "Readbutton";
            this.Readbutton.Size = new System.Drawing.Size(101, 33);
            this.Readbutton.TabIndex = 3;
            this.Readbutton.Text = "Read";
            this.Readbutton.UseVisualStyleBackColor = true;
            this.Readbutton.Click += new System.EventHandler(this.Readbutton_Click);
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(260, 82);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(143, 121);
            this.OutputlistBox.TabIndex = 4;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name of baseball players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Verification Of The Players";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.Readbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baseball SA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Readbutton;
        private System.Windows.Forms.ListBox OutputlistBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

