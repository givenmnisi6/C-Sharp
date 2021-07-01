namespace Paint_Job_Estimator
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
            this.SquarefeettextBox = new System.Windows.Forms.TextBox();
            this.GallontextBox = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square feet of wall space:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price of paint per gallon:";
            // 
            // SquarefeettextBox
            // 
            this.SquarefeettextBox.Location = new System.Drawing.Point(231, 29);
            this.SquarefeettextBox.Name = "SquarefeettextBox";
            this.SquarefeettextBox.Size = new System.Drawing.Size(117, 20);
            this.SquarefeettextBox.TabIndex = 2;
            // 
            // GallontextBox
            // 
            this.GallontextBox.Location = new System.Drawing.Point(231, 83);
            this.GallontextBox.Name = "GallontextBox";
            this.GallontextBox.Size = new System.Drawing.Size(117, 20);
            this.GallontextBox.TabIndex = 3;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(303, 134);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(94, 29);
            this.Calculatebutton.TabIndex = 4;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Outputlabel
            // 
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outputlabel.Location = new System.Drawing.Point(75, 199);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(322, 169);
            this.Outputlabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 403);
            this.Controls.Add(this.Outputlabel);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.GallontextBox);
            this.Controls.Add(this.SquarefeettextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program3_12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SquarefeettextBox;
        private System.Windows.Forms.TextBox GallontextBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Label Outputlabel;
    }
}

