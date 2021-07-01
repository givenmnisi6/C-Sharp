namespace Prak11
{
    partial class MainForm
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
            this.DormitorylistBox = new System.Windows.Forms.ListBox();
            this.MealPlanlistBox = new System.Windows.Forms.ListBox();
            this.Displaybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DormitorylistBox
            // 
            this.DormitorylistBox.FormattingEnabled = true;
            this.DormitorylistBox.Items.AddRange(new object[] {
            "Allan Hall",
            "Pike Hall",
            "Farthing Hall",
            "Universities Suites"});
            this.DormitorylistBox.Location = new System.Drawing.Point(12, 25);
            this.DormitorylistBox.Name = "DormitorylistBox";
            this.DormitorylistBox.Size = new System.Drawing.Size(170, 121);
            this.DormitorylistBox.TabIndex = 0;
            // 
            // MealPlanlistBox
            // 
            this.MealPlanlistBox.FormattingEnabled = true;
            this.MealPlanlistBox.Items.AddRange(new object[] {
            "7 Meals Per Week",
            "14 Meals Per Week",
            "Unlimited Meals"});
            this.MealPlanlistBox.Location = new System.Drawing.Point(198, 25);
            this.MealPlanlistBox.Name = "MealPlanlistBox";
            this.MealPlanlistBox.Size = new System.Drawing.Size(164, 121);
            this.MealPlanlistBox.TabIndex = 1;
            // 
            // Displaybutton
            // 
            this.Displaybutton.Location = new System.Drawing.Point(287, 152);
            this.Displaybutton.Name = "Displaybutton";
            this.Displaybutton.Size = new System.Drawing.Size(75, 23);
            this.Displaybutton.TabIndex = 4;
            this.Displaybutton.Text = "Display";
            this.Displaybutton.UseVisualStyleBackColor = true;
            this.Displaybutton.Click += new System.EventHandler(this.Displaybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dormitory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Meal Plan:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Displaybutton);
            this.Controls.Add(this.MealPlanlistBox);
            this.Controls.Add(this.DormitorylistBox);
            this.Name = "MainForm";
            this.Text = "Program9_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DormitorylistBox;
        private System.Windows.Forms.ListBox MealPlanlistBox;
        public System.Windows.Forms.Button Displaybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

