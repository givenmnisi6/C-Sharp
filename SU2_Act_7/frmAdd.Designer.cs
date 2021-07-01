
namespace Act_7
{
    partial class frmAdd
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
            this.components = new System.ComponentModel.Container();
            this.Insertmoviebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.DirectortextBox = new System.Windows.Forms.TextBox();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.RatingtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertmoviebutton
            // 
            this.Insertmoviebutton.Location = new System.Drawing.Point(136, 177);
            this.Insertmoviebutton.Name = "Insertmoviebutton";
            this.Insertmoviebutton.Size = new System.Drawing.Size(86, 28);
            this.Insertmoviebutton.TabIndex = 0;
            this.Insertmoviebutton.Text = "Insert";
            this.Insertmoviebutton.UseVisualStyleBackColor = true;
            this.Insertmoviebutton.Click += new System.EventHandler(this.Insertmoviebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Movie name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movie year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movie rating:";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(153, 32);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(107, 20);
            this.NametextBox.TabIndex = 5;
            // 
            // DirectortextBox
            // 
            this.DirectortextBox.Location = new System.Drawing.Point(153, 62);
            this.DirectortextBox.Name = "DirectortextBox";
            this.DirectortextBox.Size = new System.Drawing.Size(107, 20);
            this.DirectortextBox.TabIndex = 6;
            // 
            // YeartextBox
            // 
            this.YeartextBox.Location = new System.Drawing.Point(153, 130);
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.Size = new System.Drawing.Size(107, 20);
            this.YeartextBox.TabIndex = 7;
            // 
            // RatingtextBox
            // 
            this.RatingtextBox.Location = new System.Drawing.Point(153, 97);
            this.RatingtextBox.Name = "RatingtextBox";
            this.RatingtextBox.Size = new System.Drawing.Size(107, 20);
            this.RatingtextBox.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.RatingtextBox);
            this.Controls.Add(this.YeartextBox);
            this.Controls.Add(this.DirectortextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insertmoviebutton);
            this.Name = "frmAdd";
            this.Text = "Insert";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertmoviebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox DirectortextBox;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.TextBox RatingtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}