namespace Tip__Tax__and_Total
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
            this.label4 = new System.Windows.Forms.Label();
            this.FoodChargetextBox = new System.Windows.Forms.TextBox();
            this.Tiplabel = new System.Windows.Forms.Label();
            this.Taxlabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Charge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // FoodChargetextBox
            // 
            this.FoodChargetextBox.Location = new System.Drawing.Point(290, 82);
            this.FoodChargetextBox.Name = "FoodChargetextBox";
            this.FoodChargetextBox.Size = new System.Drawing.Size(100, 20);
            this.FoodChargetextBox.TabIndex = 4;
            this.FoodChargetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tiplabel
            // 
            this.Tiplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tiplabel.Location = new System.Drawing.Point(290, 122);
            this.Tiplabel.Name = "Tiplabel";
            this.Tiplabel.Size = new System.Drawing.Size(100, 23);
            this.Tiplabel.TabIndex = 5;
            this.Tiplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Taxlabel
            // 
            this.Taxlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Taxlabel.Location = new System.Drawing.Point(290, 160);
            this.Taxlabel.Name = "Taxlabel";
            this.Taxlabel.Size = new System.Drawing.Size(100, 24);
            this.Taxlabel.TabIndex = 6;
            this.Taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Totallabel
            // 
            this.Totallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Totallabel.Location = new System.Drawing.Point(290, 198);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(100, 24);
            this.Totallabel.TabIndex = 7;
            this.Totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(175, 263);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(102, 36);
            this.Calculatebutton.TabIndex = 8;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(388, 263);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(102, 36);
            this.Exitbutton.TabIndex = 9;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Taxlabel);
            this.Controls.Add(this.Tiplabel);
            this.Controls.Add(this.FoodChargetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tip, Tax, and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FoodChargetextBox;
        private System.Windows.Forms.Label Tiplabel;
        private System.Windows.Forms.Label Taxlabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

