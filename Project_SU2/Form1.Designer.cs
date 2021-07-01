namespace Project_SU2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.BMIbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Outputlabel);
            this.groupBox1.Controls.Add(this.HeighttextBox);
            this.groupBox1.Controls.Add(this.WeighttextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Clearbutton);
            this.groupBox1.Controls.Add(this.BMIbutton);
            this.groupBox1.Location = new System.Drawing.Point(178, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Outputlabel
            // 
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outputlabel.Location = new System.Drawing.Point(85, 138);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(261, 23);
            this.Outputlabel.TabIndex = 10;
            this.Outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(240, 80);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.HeighttextBox.TabIndex = 7;
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(240, 49);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.WeighttextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height in meters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight in kilograms:\r\n";
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Clearbutton.Location = new System.Drawing.Point(253, 221);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(87, 33);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "Cl&ear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // BMIbutton
            // 
            this.BMIbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BMIbutton.Location = new System.Drawing.Point(120, 221);
            this.BMIbutton.Name = "BMIbutton";
            this.BMIbutton.Size = new System.Drawing.Size(89, 33);
            this.BMIbutton.TabIndex = 0;
            this.BMIbutton.Text = "BMI";
            this.BMIbutton.UseVisualStyleBackColor = false;
            this.BMIbutton.Click += new System.EventHandler(this.BMIbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button BMIbutton;
        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

