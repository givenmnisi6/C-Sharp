namespace Heads_or_Tails
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
            this.headspictureBox = new System.Windows.Forms.PictureBox();
            this.tailspictureBox = new System.Windows.Forms.PictureBox();
            this.showheadbutton = new System.Windows.Forms.Button();
            this.showtailsbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headspictureBox
            // 
            this.headspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headspictureBox.Image")));
            this.headspictureBox.Location = new System.Drawing.Point(115, 94);
            this.headspictureBox.Name = "headspictureBox";
            this.headspictureBox.Size = new System.Drawing.Size(148, 150);
            this.headspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headspictureBox.TabIndex = 0;
            this.headspictureBox.TabStop = false;
            // 
            // tailspictureBox
            // 
            this.tailspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailspictureBox.Image")));
            this.tailspictureBox.Location = new System.Drawing.Point(358, 94);
            this.tailspictureBox.Name = "tailspictureBox";
            this.tailspictureBox.Size = new System.Drawing.Size(148, 150);
            this.tailspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailspictureBox.TabIndex = 1;
            this.tailspictureBox.TabStop = false;
            // 
            // showheadbutton
            // 
            this.showheadbutton.Location = new System.Drawing.Point(129, 300);
            this.showheadbutton.Name = "showheadbutton";
            this.showheadbutton.Size = new System.Drawing.Size(70, 45);
            this.showheadbutton.TabIndex = 2;
            this.showheadbutton.Text = "Show Heads";
            this.showheadbutton.UseVisualStyleBackColor = true;
            this.showheadbutton.Click += new System.EventHandler(this.showheadbutton_Click);
            // 
            // showtailsbutton
            // 
            this.showtailsbutton.Location = new System.Drawing.Point(273, 300);
            this.showtailsbutton.Name = "showtailsbutton";
            this.showtailsbutton.Size = new System.Drawing.Size(70, 45);
            this.showtailsbutton.TabIndex = 3;
            this.showtailsbutton.Text = "Show Tails";
            this.showtailsbutton.UseVisualStyleBackColor = true;
            this.showtailsbutton.Click += new System.EventHandler(this.showtailsbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(396, 300);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(70, 45);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.showtailsbutton);
            this.Controls.Add(this.showheadbutton);
            this.Controls.Add(this.tailspictureBox);
            this.Controls.Add(this.headspictureBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailspictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headspictureBox;
        private System.Windows.Forms.PictureBox tailspictureBox;
        private System.Windows.Forms.Button showheadbutton;
        private System.Windows.Forms.Button showtailsbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

