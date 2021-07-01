namespace Prak11
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
            this.button1 = new System.Windows.Forms.Button();
            this.Restaurant = new System.Windows.Forms.GroupBox();
            this.RoccoradioButton = new System.Windows.Forms.RadioButton();
            this.MuggradioButton = new System.Windows.Forms.RadioButton();
            this.MacDradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BreakfastradioButton = new System.Windows.Forms.RadioButton();
            this.BurgerradioButton = new System.Windows.Forms.RadioButton();
            this.FishradioButton = new System.Windows.Forms.RadioButton();
            this.Restaurant.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Restaurant
            // 
            this.Restaurant.Controls.Add(this.MacDradioButton);
            this.Restaurant.Controls.Add(this.MuggradioButton);
            this.Restaurant.Controls.Add(this.RoccoradioButton);
            this.Restaurant.Location = new System.Drawing.Point(48, 87);
            this.Restaurant.Name = "Restaurant";
            this.Restaurant.Size = new System.Drawing.Size(200, 121);
            this.Restaurant.TabIndex = 5;
            this.Restaurant.TabStop = false;
            this.Restaurant.Text = "Restaurant";
            // 
            // RoccoradioButton
            // 
            this.RoccoradioButton.AutoSize = true;
            this.RoccoradioButton.Location = new System.Drawing.Point(6, 19);
            this.RoccoradioButton.Name = "RoccoradioButton";
            this.RoccoradioButton.Size = new System.Drawing.Size(94, 17);
            this.RoccoradioButton.TabIndex = 6;
            this.RoccoradioButton.TabStop = true;
            this.RoccoradioButton.Text = "Rocco Mamas";
            this.RoccoradioButton.UseVisualStyleBackColor = true;
            // 
            // MuggradioButton
            // 
            this.MuggradioButton.AutoSize = true;
            this.MuggradioButton.Location = new System.Drawing.Point(6, 42);
            this.MuggradioButton.Name = "MuggradioButton";
            this.MuggradioButton.Size = new System.Drawing.Size(102, 17);
            this.MuggradioButton.TabIndex = 6;
            this.MuggradioButton.TabStop = true;
            this.MuggradioButton.Text = "Mugg And Bean";
            this.MuggradioButton.UseVisualStyleBackColor = true;
            // 
            // MacDradioButton
            // 
            this.MacDradioButton.AutoSize = true;
            this.MacDradioButton.Location = new System.Drawing.Point(6, 65);
            this.MacDradioButton.Name = "MacDradioButton";
            this.MacDradioButton.Size = new System.Drawing.Size(85, 17);
            this.MacDradioButton.TabIndex = 6;
            this.MacDradioButton.TabStop = true;
            this.MacDradioButton.Text = "MacDonalds";
            this.MacDradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BreakfastradioButton);
            this.groupBox1.Controls.Add(this.BurgerradioButton);
            this.groupBox1.Controls.Add(this.FishradioButton);
            this.groupBox1.Location = new System.Drawing.Point(284, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meals";
            // 
            // BreakfastradioButton
            // 
            this.BreakfastradioButton.AutoSize = true;
            this.BreakfastradioButton.Location = new System.Drawing.Point(6, 65);
            this.BreakfastradioButton.Name = "BreakfastradioButton";
            this.BreakfastradioButton.Size = new System.Drawing.Size(110, 17);
            this.BreakfastradioButton.TabIndex = 6;
            this.BreakfastradioButton.TabStop = true;
            this.BreakfastradioButton.Text = "Medium Breakfast";
            this.BreakfastradioButton.UseVisualStyleBackColor = true;
            // 
            // BurgerradioButton
            // 
            this.BurgerradioButton.AutoSize = true;
            this.BurgerradioButton.Location = new System.Drawing.Point(6, 42);
            this.BurgerradioButton.Name = "BurgerradioButton";
            this.BurgerradioButton.Size = new System.Drawing.Size(110, 17);
            this.BurgerradioButton.TabIndex = 6;
            this.BurgerradioButton.TabStop = true;
            this.BurgerradioButton.Text = "Burger With Chips";
            this.BurgerradioButton.UseVisualStyleBackColor = true;
            // 
            // FishradioButton
            // 
            this.FishradioButton.AutoSize = true;
            this.FishradioButton.Location = new System.Drawing.Point(6, 19);
            this.FishradioButton.Name = "FishradioButton";
            this.FishradioButton.Size = new System.Drawing.Size(82, 17);
            this.FishradioButton.TabIndex = 6;
            this.FishradioButton.TabStop = true;
            this.FishradioButton.Text = "Fish && Chips";
            this.FishradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Restaurant);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Restaurant.ResumeLayout(false);
            this.Restaurant.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Restaurant;
        private System.Windows.Forms.RadioButton MacDradioButton;
        private System.Windows.Forms.RadioButton MuggradioButton;
        private System.Windows.Forms.RadioButton RoccoradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BreakfastradioButton;
        private System.Windows.Forms.RadioButton BurgerradioButton;
        private System.Windows.Forms.RadioButton FishradioButton;
    }
}

