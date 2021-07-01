
namespace SU2_Act1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Displaylb = new System.Windows.Forms.ListBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.Movebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Data";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(450, 223);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Displaylb);
            this.groupBox2.Location = new System.Drawing.Point(494, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listbox Data";
            // 
            // Displaylb
            // 
            this.Displaylb.FormattingEnabled = true;
            this.Displaylb.Location = new System.Drawing.Point(6, 19);
            this.Displaylb.Name = "Displaylb";
            this.Displaylb.Size = new System.Drawing.Size(450, 212);
            this.Displaylb.TabIndex = 0;
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(18, 292);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(75, 23);
            this.Connectbtn.TabIndex = 2;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Displaybtn
            // 
            this.Displaybtn.Location = new System.Drawing.Point(99, 292);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(75, 23);
            this.Displaybtn.TabIndex = 3;
            this.Displaybtn.Text = "Display";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // Movebtn
            // 
            this.Movebtn.Location = new System.Drawing.Point(180, 292);
            this.Movebtn.Name = "Movebtn";
            this.Movebtn.Size = new System.Drawing.Size(75, 23);
            this.Movebtn.TabIndex = 4;
            this.Movebtn.Text = "Move Data";
            this.Movebtn.UseVisualStyleBackColor = true;
            this.Movebtn.Click += new System.EventHandler(this.Movebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(875, 292);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "E&xit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 410);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Movebtn);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListBox Displaylb;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.Button Movebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

