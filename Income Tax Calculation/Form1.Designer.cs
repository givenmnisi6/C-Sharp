namespace Income_Tax_Calculation
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
            this.GrosstextBox = new System.Windows.Forms.TextBox();
            this.DeductiontextBox = new System.Windows.Forms.TextBox();
            this.OthertextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Grosslabel = new System.Windows.Forms.Label();
            this.NetIncomelabel = new System.Windows.Forms.Label();
            this.Taxlabel = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yearly gross income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Standard deduction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Other exemption:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gross Income:";
            // 
            // GrosstextBox
            // 
            this.GrosstextBox.Location = new System.Drawing.Point(243, 49);
            this.GrosstextBox.Name = "GrosstextBox";
            this.GrosstextBox.Size = new System.Drawing.Size(100, 20);
            this.GrosstextBox.TabIndex = 4;
            this.GrosstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeductiontextBox
            // 
            this.DeductiontextBox.Location = new System.Drawing.Point(244, 92);
            this.DeductiontextBox.Name = "DeductiontextBox";
            this.DeductiontextBox.Size = new System.Drawing.Size(99, 20);
            this.DeductiontextBox.TabIndex = 5;
            this.DeductiontextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OthertextBox
            // 
            this.OthertextBox.Location = new System.Drawing.Point(244, 135);
            this.OthertextBox.Name = "OthertextBox";
            this.OthertextBox.Size = new System.Drawing.Size(99, 20);
            this.OthertextBox.TabIndex = 6;
            this.OthertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Net Income:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tax Payable:";
            // 
            // Grosslabel
            // 
            this.Grosslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grosslabel.Location = new System.Drawing.Point(243, 178);
            this.Grosslabel.Name = "Grosslabel";
            this.Grosslabel.Size = new System.Drawing.Size(100, 23);
            this.Grosslabel.TabIndex = 9;
            this.Grosslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NetIncomelabel
            // 
            this.NetIncomelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetIncomelabel.Location = new System.Drawing.Point(243, 217);
            this.NetIncomelabel.Name = "NetIncomelabel";
            this.NetIncomelabel.Size = new System.Drawing.Size(100, 23);
            this.NetIncomelabel.TabIndex = 10;
            this.NetIncomelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Taxlabel
            // 
            this.Taxlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Taxlabel.Location = new System.Drawing.Point(243, 259);
            this.Taxlabel.Name = "Taxlabel";
            this.Taxlabel.Size = new System.Drawing.Size(100, 23);
            this.Taxlabel.TabIndex = 11;
            this.Taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(160, 309);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(78, 36);
            this.Calculatebutton.TabIndex = 12;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(414, 309);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 36);
            this.Exitbutton.TabIndex = 13;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(287, 309);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 36);
            this.Clearbutton.TabIndex = 14;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Taxlabel);
            this.Controls.Add(this.NetIncomelabel);
            this.Controls.Add(this.Grosslabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OthertextBox);
            this.Controls.Add(this.DeductiontextBox);
            this.Controls.Add(this.GrosstextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Income Tax Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GrosstextBox;
        private System.Windows.Forms.TextBox DeductiontextBox;
        private System.Windows.Forms.TextBox OthertextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Grosslabel;
        private System.Windows.Forms.Label NetIncomelabel;
        private System.Windows.Forms.Label Taxlabel;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Clearbutton;
    }
}

