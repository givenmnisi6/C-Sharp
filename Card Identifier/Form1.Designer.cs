namespace Card_Identifier
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
            this.statementlabel = new System.Windows.Forms.Label();
            this.DiamondpictureBox = new System.Windows.Forms.PictureBox();
            this.ClubpictureBox = new System.Windows.Forms.PictureBox();
            this.KingpictureBox = new System.Windows.Forms.PictureBox();
            this.AcepictureBox = new System.Windows.Forms.PictureBox();
            this.JokerpictureBox = new System.Windows.Forms.PictureBox();
            this.answerlabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiamondpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JokerpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statementlabel
            // 
            this.statementlabel.AutoSize = true;
            this.statementlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementlabel.Location = new System.Drawing.Point(257, 42);
            this.statementlabel.Name = "statementlabel";
            this.statementlabel.Size = new System.Drawing.Size(294, 26);
            this.statementlabel.TabIndex = 0;
            this.statementlabel.Text = "Click a Card to See Its Name";
            // 
            // DiamondpictureBox
            // 
            this.DiamondpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DiamondpictureBox.Image")));
            this.DiamondpictureBox.Location = new System.Drawing.Point(54, 98);
            this.DiamondpictureBox.Name = "DiamondpictureBox";
            this.DiamondpictureBox.Size = new System.Drawing.Size(100, 139);
            this.DiamondpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiamondpictureBox.TabIndex = 1;
            this.DiamondpictureBox.TabStop = false;
            this.DiamondpictureBox.Click += new System.EventHandler(this.DiamondpictureBox_Click);
            // 
            // ClubpictureBox
            // 
            this.ClubpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClubpictureBox.Image")));
            this.ClubpictureBox.Location = new System.Drawing.Point(201, 98);
            this.ClubpictureBox.Name = "ClubpictureBox";
            this.ClubpictureBox.Size = new System.Drawing.Size(100, 139);
            this.ClubpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClubpictureBox.TabIndex = 2;
            this.ClubpictureBox.TabStop = false;
            this.ClubpictureBox.Click += new System.EventHandler(this.ClubpictureBox_Click);
            // 
            // KingpictureBox
            // 
            this.KingpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KingpictureBox.Image")));
            this.KingpictureBox.Location = new System.Drawing.Point(359, 98);
            this.KingpictureBox.Name = "KingpictureBox";
            this.KingpictureBox.Size = new System.Drawing.Size(100, 139);
            this.KingpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KingpictureBox.TabIndex = 3;
            this.KingpictureBox.TabStop = false;
            this.KingpictureBox.Click += new System.EventHandler(this.KingpictureBox_Click);
            // 
            // AcepictureBox
            // 
            this.AcepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AcepictureBox.Image")));
            this.AcepictureBox.Location = new System.Drawing.Point(502, 98);
            this.AcepictureBox.Name = "AcepictureBox";
            this.AcepictureBox.Size = new System.Drawing.Size(100, 139);
            this.AcepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcepictureBox.TabIndex = 4;
            this.AcepictureBox.TabStop = false;
            this.AcepictureBox.Click += new System.EventHandler(this.AcepictureBox_Click);
            // 
            // JokerpictureBox
            // 
            this.JokerpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("JokerpictureBox.Image")));
            this.JokerpictureBox.Location = new System.Drawing.Point(650, 98);
            this.JokerpictureBox.Name = "JokerpictureBox";
            this.JokerpictureBox.Size = new System.Drawing.Size(100, 139);
            this.JokerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JokerpictureBox.TabIndex = 5;
            this.JokerpictureBox.TabStop = false;
            this.JokerpictureBox.Click += new System.EventHandler(this.JokerpictureBox_Click);
            // 
            // answerlabel
            // 
            this.answerlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerlabel.Location = new System.Drawing.Point(54, 261);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(696, 40);
            this.answerlabel.TabIndex = 6;
            this.answerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(359, 316);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(100, 41);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 408);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.JokerpictureBox);
            this.Controls.Add(this.AcepictureBox);
            this.Controls.Add(this.KingpictureBox);
            this.Controls.Add(this.ClubpictureBox);
            this.Controls.Add(this.DiamondpictureBox);
            this.Controls.Add(this.statementlabel);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.DiamondpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JokerpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statementlabel;
        private System.Windows.Forms.PictureBox DiamondpictureBox;
        private System.Windows.Forms.PictureBox ClubpictureBox;
        private System.Windows.Forms.PictureBox KingpictureBox;
        private System.Windows.Forms.PictureBox AcepictureBox;
        private System.Windows.Forms.PictureBox JokerpictureBox;
        private System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.Button exitbutton;
    }
}

