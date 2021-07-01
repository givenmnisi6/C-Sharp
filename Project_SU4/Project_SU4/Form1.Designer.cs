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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MACradioButton = new System.Windows.Forms.RadioButton();
            this.LENOVOradioButton = new System.Windows.Forms.RadioButton();
            this.HPradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InitialstextBox = new System.Windows.Forms.TextBox();
            this.DeposittextBox = new System.Windows.Forms.TextBox();
            this.OutputlistBox = new System.Windows.Forms.ListBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MACradioButton);
            this.groupBox1.Controls.Add(this.LENOVOradioButton);
            this.groupBox1.Controls.Add(this.HPradioButton);
            this.groupBox1.Location = new System.Drawing.Point(324, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick A Laptop";
            // 
            // MACradioButton
            // 
            this.MACradioButton.AutoSize = true;
            this.MACradioButton.Location = new System.Drawing.Point(18, 78);
            this.MACradioButton.Name = "MACradioButton";
            this.MACradioButton.Size = new System.Drawing.Size(78, 17);
            this.MACradioButton.TabIndex = 3;
            this.MACradioButton.TabStop = true;
            this.MACradioButton.Text = "MACBOOK";
            this.MACradioButton.UseVisualStyleBackColor = true;
            // 
            // LENOVOradioButton
            // 
            this.LENOVOradioButton.AutoSize = true;
            this.LENOVOradioButton.Location = new System.Drawing.Point(18, 53);
            this.LENOVOradioButton.Name = "LENOVOradioButton";
            this.LENOVOradioButton.Size = new System.Drawing.Size(69, 17);
            this.LENOVOradioButton.TabIndex = 1;
            this.LENOVOradioButton.TabStop = true;
            this.LENOVOradioButton.Text = "LENOVO";
            this.LENOVOradioButton.UseVisualStyleBackColor = true;
            // 
            // HPradioButton
            // 
            this.HPradioButton.AutoSize = true;
            this.HPradioButton.Location = new System.Drawing.Point(18, 30);
            this.HPradioButton.Name = "HPradioButton";
            this.HPradioButton.Size = new System.Drawing.Size(40, 17);
            this.HPradioButton.TabIndex = 0;
            this.HPradioButton.TabStop = true;
            this.HPradioButton.Text = "HP";
            this.HPradioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Initials:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a deposit:";
            // 
            // InitialstextBox
            // 
            this.InitialstextBox.Location = new System.Drawing.Point(181, 77);
            this.InitialstextBox.Name = "InitialstextBox";
            this.InitialstextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialstextBox.TabIndex = 3;
            // 
            // DeposittextBox
            // 
            this.DeposittextBox.Location = new System.Drawing.Point(181, 103);
            this.DeposittextBox.Name = "DeposittextBox";
            this.DeposittextBox.Size = new System.Drawing.Size(100, 20);
            this.DeposittextBox.TabIndex = 4;
            // 
            // OutputlistBox
            // 
            this.OutputlistBox.FormattingEnabled = true;
            this.OutputlistBox.Location = new System.Drawing.Point(247, 200);
            this.OutputlistBox.Name = "OutputlistBox";
            this.OutputlistBox.Size = new System.Drawing.Size(278, 147);
            this.OutputlistBox.TabIndex = 5;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(206, 136);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 6;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(81, 136);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.Calculatebutton.TabIndex = 7;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(142, 165);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 8;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 406);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.OutputlistBox);
            this.Controls.Add(this.DeposittextBox);
            this.Controls.Add(this.InitialstextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MACradioButton;
        private System.Windows.Forms.RadioButton LENOVOradioButton;
        private System.Windows.Forms.RadioButton HPradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InitialstextBox;
        private System.Windows.Forms.TextBox DeposittextBox;
        private System.Windows.Forms.ListBox OutputlistBox;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

