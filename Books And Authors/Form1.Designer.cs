namespace Books_And_Authors
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
            this.questionlabel = new System.Windows.Forms.Label();
            this.answerlabel = new System.Windows.Forms.Label();
            this.book1button = new System.Windows.Forms.Button();
            this.book2button = new System.Windows.Forms.Button();
            this.book3button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlabel.Location = new System.Drawing.Point(193, 91);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(312, 17);
            this.questionlabel.TabIndex = 0;
            this.questionlabel.Text = "What is the author\'s name for a particluar book?\r\n";
            // 
            // answerlabel
            // 
            this.answerlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerlabel.Location = new System.Drawing.Point(196, 133);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(309, 37);
            this.answerlabel.TabIndex = 1;
            this.answerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // book1button
            // 
            this.book1button.Location = new System.Drawing.Point(109, 220);
            this.book1button.Name = "book1button";
            this.book1button.Size = new System.Drawing.Size(90, 44);
            this.book1button.TabIndex = 2;
            this.book1button.Text = "Gone with the Wind";
            this.book1button.UseVisualStyleBackColor = true;
            this.book1button.Click += new System.EventHandler(this.book1button_Click);
            // 
            // book2button
            // 
            this.book2button.Location = new System.Drawing.Point(274, 220);
            this.book2button.Name = "book2button";
            this.book2button.Size = new System.Drawing.Size(90, 44);
            this.book2button.TabIndex = 3;
            this.book2button.Text = "Roots";
            this.book2button.UseVisualStyleBackColor = true;
            this.book2button.Click += new System.EventHandler(this.book2button_Click);
            // 
            // book3button
            // 
            this.book3button.Location = new System.Drawing.Point(415, 220);
            this.book3button.Name = "book3button";
            this.book3button.Size = new System.Drawing.Size(90, 44);
            this.book3button.TabIndex = 4;
            this.book3button.Text = "Atlas Shrugged";
            this.book3button.UseVisualStyleBackColor = true;
            this.book3button.Click += new System.EventHandler(this.book3button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 350);
            this.Controls.Add(this.book3button);
            this.Controls.Add(this.book2button);
            this.Controls.Add(this.book1button);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.questionlabel);
            this.Name = "Form1";
            this.Text = "Books and Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionlabel;
        private System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.Button book1button;
        private System.Windows.Forms.Button book2button;
        private System.Windows.Forms.Button book3button;
    }
}

