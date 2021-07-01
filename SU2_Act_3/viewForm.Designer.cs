
namespace SU2_Act_3
{
    partial class viewData
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Actionbutton = new System.Windows.Forms.Button();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Displaylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(569, 260);
            this.dataGridView.TabIndex = 0;
            // 
            // Actionbutton
            // 
            this.Actionbutton.Location = new System.Drawing.Point(12, 287);
            this.Actionbutton.Name = "Actionbutton";
            this.Actionbutton.Size = new System.Drawing.Size(89, 41);
            this.Actionbutton.TabIndex = 1;
            this.Actionbutton.Text = "Action";
            this.Actionbutton.UseVisualStyleBackColor = true;
            this.Actionbutton.Click += new System.EventHandler(this.Actionbutton_Click);
            // 
            // hScrollBar
            // 
            this.hScrollBar.LargeChange = 1;
            this.hScrollBar.Location = new System.Drawing.Point(520, 310);
            this.hScrollBar.Maximum = 18;
            this.hScrollBar.Minimum = 7;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar.TabIndex = 2;
            this.hScrollBar.Value = 7;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Age:";
            // 
            // Displaylbl
            // 
            this.Displaylbl.AutoSize = true;
            this.Displaylbl.Location = new System.Drawing.Point(546, 336);
            this.Displaylbl.Name = "Displaylbl";
            this.Displaylbl.Size = new System.Drawing.Size(35, 13);
            this.Displaylbl.TabIndex = 4;
            this.Displaylbl.Text = "label2";
            this.Displaylbl.Visible = false;
            // 
            // viewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Displaylbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.Actionbutton);
            this.Controls.Add(this.dataGridView);
            this.Name = "viewData";
            this.Text = "DVD List";
            this.Load += new System.EventHandler(this.viewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Actionbutton;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Displaylbl;
    }
}