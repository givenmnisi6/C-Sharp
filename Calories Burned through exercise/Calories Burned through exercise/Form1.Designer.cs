namespace Calories_Burned_through_exercise
{
    partial class Calories
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
            this.Weightlabel = new System.Windows.Forms.Label();
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RowingradioButton = new System.Windows.Forms.RadioButton();
            this.RunningradioButton = new System.Windows.Forms.RadioButton();
            this.CyclingradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Location = new System.Drawing.Point(81, 52);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(44, 13);
            this.Weightlabel.TabIndex = 0;
            this.Weightlabel.Text = "Weight:";
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(131, 45);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(100, 20);
            this.InputtextBox.TabIndex = 1;
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(103, 101);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(191, 212);
            this.OutputlistBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RowingradioButton);
            this.groupBox1.Controls.Add(this.RunningradioButton);
            this.groupBox1.Controls.Add(this.CyclingradioButton);
            this.groupBox1.Location = new System.Drawing.Point(350, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exercise";
            // 
            // RowingradioButton
            // 
            this.RowingradioButton.AutoSize = true;
            this.RowingradioButton.Location = new System.Drawing.Point(15, 91);
            this.RowingradioButton.Name = "RowingradioButton";
            this.RowingradioButton.Size = new System.Drawing.Size(61, 17);
            this.RowingradioButton.TabIndex = 2;
            this.RowingradioButton.TabStop = true;
            this.RowingradioButton.Text = "Rowing";
            this.RowingradioButton.UseVisualStyleBackColor = true;
            // 
            // RunningradioButton
            // 
            this.RunningradioButton.AutoSize = true;
            this.RunningradioButton.Location = new System.Drawing.Point(15, 55);
            this.RunningradioButton.Name = "RunningradioButton";
            this.RunningradioButton.Size = new System.Drawing.Size(65, 17);
            this.RunningradioButton.TabIndex = 1;
            this.RunningradioButton.TabStop = true;
            this.RunningradioButton.Text = "Running";
            this.RunningradioButton.UseVisualStyleBackColor = true;
            // 
            // CyclingradioButton
            // 
            this.CyclingradioButton.AutoSize = true;
            this.CyclingradioButton.Location = new System.Drawing.Point(15, 19);
            this.CyclingradioButton.Name = "CyclingradioButton";
            this.CyclingradioButton.Size = new System.Drawing.Size(59, 17);
            this.CyclingradioButton.TabIndex = 0;
            this.CyclingradioButton.TabStop = true;
            this.CyclingradioButton.Text = "Cycling";
            this.CyclingradioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "kg";
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(350, 222);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(140, 40);
            this.Calculatebutton.TabIndex = 5;
            this.Calculatebutton.Text = "Show Calories Burnt";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(350, 268);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(140, 40);
            this.Exitbutton.TabIndex = 6;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 334);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.Weightlabel);
            this.Name = "Calories";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.ListBox OutputlistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RowingradioButton;
        private System.Windows.Forms.RadioButton RunningradioButton;
        private System.Windows.Forms.RadioButton CyclingradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

