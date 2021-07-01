namespace Colour_Mixer
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
            this.FirstgroupBox = new System.Windows.Forms.GroupBox();
            this.SecondarygroupBox = new System.Windows.Forms.GroupBox();
            this.FRedradioButton = new System.Windows.Forms.RadioButton();
            this.FBlueradioButton = new System.Windows.Forms.RadioButton();
            this.FYellowradioButton = new System.Windows.Forms.RadioButton();
            this.SRedradioButton = new System.Windows.Forms.RadioButton();
            this.SBlueradioButton = new System.Windows.Forms.RadioButton();
            this.SYellowradioButton = new System.Windows.Forms.RadioButton();
            this.Mixbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.FirstgroupBox.SuspendLayout();
            this.SecondarygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstgroupBox
            // 
            this.FirstgroupBox.Controls.Add(this.FYellowradioButton);
            this.FirstgroupBox.Controls.Add(this.FBlueradioButton);
            this.FirstgroupBox.Controls.Add(this.FRedradioButton);
            this.FirstgroupBox.Location = new System.Drawing.Point(59, 53);
            this.FirstgroupBox.Name = "FirstgroupBox";
            this.FirstgroupBox.Size = new System.Drawing.Size(160, 120);
            this.FirstgroupBox.TabIndex = 0;
            this.FirstgroupBox.TabStop = false;
            this.FirstgroupBox.Text = "Select the First Color";
            // 
            // SecondarygroupBox
            // 
            this.SecondarygroupBox.Controls.Add(this.SYellowradioButton);
            this.SecondarygroupBox.Controls.Add(this.SBlueradioButton);
            this.SecondarygroupBox.Controls.Add(this.SRedradioButton);
            this.SecondarygroupBox.Location = new System.Drawing.Point(235, 53);
            this.SecondarygroupBox.Name = "SecondarygroupBox";
            this.SecondarygroupBox.Size = new System.Drawing.Size(157, 121);
            this.SecondarygroupBox.TabIndex = 1;
            this.SecondarygroupBox.TabStop = false;
            this.SecondarygroupBox.Text = "Select the Secondary Color";
            // 
            // FRedradioButton
            // 
            this.FRedradioButton.AutoSize = true;
            this.FRedradioButton.Location = new System.Drawing.Point(3, 16);
            this.FRedradioButton.Name = "FRedradioButton";
            this.FRedradioButton.Size = new System.Drawing.Size(45, 17);
            this.FRedradioButton.TabIndex = 0;
            this.FRedradioButton.TabStop = true;
            this.FRedradioButton.Text = "Red";
            this.FRedradioButton.UseVisualStyleBackColor = true;
            // 
            // FBlueradioButton
            // 
            this.FBlueradioButton.AutoSize = true;
            this.FBlueradioButton.Location = new System.Drawing.Point(3, 39);
            this.FBlueradioButton.Name = "FBlueradioButton";
            this.FBlueradioButton.Size = new System.Drawing.Size(46, 17);
            this.FBlueradioButton.TabIndex = 1;
            this.FBlueradioButton.TabStop = true;
            this.FBlueradioButton.Text = "Blue";
            this.FBlueradioButton.UseVisualStyleBackColor = true;
            // 
            // FYellowradioButton
            // 
            this.FYellowradioButton.AutoSize = true;
            this.FYellowradioButton.Location = new System.Drawing.Point(3, 62);
            this.FYellowradioButton.Name = "FYellowradioButton";
            this.FYellowradioButton.Size = new System.Drawing.Size(56, 17);
            this.FYellowradioButton.TabIndex = 2;
            this.FYellowradioButton.TabStop = true;
            this.FYellowradioButton.Text = "Yellow";
            this.FYellowradioButton.UseVisualStyleBackColor = true;
            // 
            // SRedradioButton
            // 
            this.SRedradioButton.AutoSize = true;
            this.SRedradioButton.Location = new System.Drawing.Point(3, 16);
            this.SRedradioButton.Name = "SRedradioButton";
            this.SRedradioButton.Size = new System.Drawing.Size(45, 17);
            this.SRedradioButton.TabIndex = 0;
            this.SRedradioButton.TabStop = true;
            this.SRedradioButton.Text = "Red";
            this.SRedradioButton.UseVisualStyleBackColor = true;
            // 
            // SBlueradioButton
            // 
            this.SBlueradioButton.AutoSize = true;
            this.SBlueradioButton.Location = new System.Drawing.Point(3, 39);
            this.SBlueradioButton.Name = "SBlueradioButton";
            this.SBlueradioButton.Size = new System.Drawing.Size(46, 17);
            this.SBlueradioButton.TabIndex = 1;
            this.SBlueradioButton.TabStop = true;
            this.SBlueradioButton.Text = "Blue";
            this.SBlueradioButton.UseVisualStyleBackColor = true;
            // 
            // SYellowradioButton
            // 
            this.SYellowradioButton.AutoSize = true;
            this.SYellowradioButton.Location = new System.Drawing.Point(3, 62);
            this.SYellowradioButton.Name = "SYellowradioButton";
            this.SYellowradioButton.Size = new System.Drawing.Size(56, 17);
            this.SYellowradioButton.TabIndex = 2;
            this.SYellowradioButton.TabStop = true;
            this.SYellowradioButton.Text = "Yellow";
            this.SYellowradioButton.UseVisualStyleBackColor = true;
            // 
            // Mixbutton
            // 
            this.Mixbutton.Location = new System.Drawing.Point(144, 190);
            this.Mixbutton.Name = "Mixbutton";
            this.Mixbutton.Size = new System.Drawing.Size(75, 23);
            this.Mixbutton.TabIndex = 2;
            this.Mixbutton.Text = "Mix";
            this.Mixbutton.UseVisualStyleBackColor = true;
            this.Mixbutton.Click += new System.EventHandler(this.Mixbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(235, 190);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Mixbutton);
            this.Controls.Add(this.SecondarygroupBox);
            this.Controls.Add(this.FirstgroupBox);
            this.Name = "Form1";
            this.Text = "Colour Mixer";
            this.FirstgroupBox.ResumeLayout(false);
            this.FirstgroupBox.PerformLayout();
            this.SecondarygroupBox.ResumeLayout(false);
            this.SecondarygroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FirstgroupBox;
        private System.Windows.Forms.RadioButton FYellowradioButton;
        private System.Windows.Forms.RadioButton FBlueradioButton;
        private System.Windows.Forms.RadioButton FRedradioButton;
        private System.Windows.Forms.GroupBox SecondarygroupBox;
        private System.Windows.Forms.RadioButton SRedradioButton;
        private System.Windows.Forms.RadioButton SYellowradioButton;
        private System.Windows.Forms.RadioButton SBlueradioButton;
        private System.Windows.Forms.Button Mixbutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

