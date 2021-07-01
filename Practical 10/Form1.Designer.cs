namespace Practical_10
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
            this.label5 = new System.Windows.Forms.Label();
            this.DaystextBox = new System.Windows.Forms.TextBox();
            this.MedicationtextBox = new System.Windows.Forms.TextBox();
            this.SpatextBox = new System.Windows.Forms.TextBox();
            this.CartextBox = new System.Windows.Forms.TextBox();
            this.RestauranttextBox = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Of Days Stayed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurant Charges Including VAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spa and Health Treatments Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Charges for Car Rental:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medication and Rehabilitation Bill:";
            // 
            // DaystextBox
            // 
            this.DaystextBox.Location = new System.Drawing.Point(304, 56);
            this.DaystextBox.Name = "DaystextBox";
            this.DaystextBox.Size = new System.Drawing.Size(93, 20);
            this.DaystextBox.TabIndex = 5;
            // 
            // MedicationtextBox
            // 
            this.MedicationtextBox.Location = new System.Drawing.Point(304, 186);
            this.MedicationtextBox.Name = "MedicationtextBox";
            this.MedicationtextBox.Size = new System.Drawing.Size(93, 20);
            this.MedicationtextBox.TabIndex = 7;
            // 
            // SpatextBox
            // 
            this.SpatextBox.Location = new System.Drawing.Point(304, 122);
            this.SpatextBox.Name = "SpatextBox";
            this.SpatextBox.Size = new System.Drawing.Size(93, 20);
            this.SpatextBox.TabIndex = 8;
            // 
            // CartextBox
            // 
            this.CartextBox.Location = new System.Drawing.Point(304, 153);
            this.CartextBox.Name = "CartextBox";
            this.CartextBox.Size = new System.Drawing.Size(93, 20);
            this.CartextBox.TabIndex = 9;
            // 
            // RestauranttextBox
            // 
            this.RestauranttextBox.Location = new System.Drawing.Point(304, 88);
            this.RestauranttextBox.Name = "RestauranttextBox";
            this.RestauranttextBox.Size = new System.Drawing.Size(93, 20);
            this.RestauranttextBox.TabIndex = 10;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(116, 223);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(142, 23);
            this.Calculatebutton.TabIndex = 11;
            this.Calculatebutton.Text = "Calculate Total Charges";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(291, 223);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(106, 23);
            this.Exitbutton.TabIndex = 12;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(116, 269);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(281, 147);
            this.OutputlistBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.RestauranttextBox);
            this.Controls.Add(this.CartextBox);
            this.Controls.Add(this.SpatextBox);
            this.Controls.Add(this.MedicationtextBox);
            this.Controls.Add(this.DaystextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DaystextBox;
        private System.Windows.Forms.TextBox MedicationtextBox;
        private System.Windows.Forms.TextBox SpatextBox;
        private System.Windows.Forms.TextBox CartextBox;
        private System.Windows.Forms.TextBox RestauranttextBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ListBox OutputlistBox;
    }
}

