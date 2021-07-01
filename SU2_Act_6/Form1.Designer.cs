
namespace Act_6
{
    partial class frmTheatres
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
            this.ViewAllbutton = new System.Windows.Forms.Button();
            this.OpenSeatsbutton = new System.Windows.Forms.Button();
            this.Totalbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(521, 279);
            this.dataGridView.TabIndex = 0;
            // 
            // ViewAllbutton
            // 
            this.ViewAllbutton.Location = new System.Drawing.Point(660, 25);
            this.ViewAllbutton.Name = "ViewAllbutton";
            this.ViewAllbutton.Size = new System.Drawing.Size(108, 34);
            this.ViewAllbutton.TabIndex = 1;
            this.ViewAllbutton.Text = "View All";
            this.ViewAllbutton.UseVisualStyleBackColor = true;
            this.ViewAllbutton.Click += new System.EventHandler(this.ViewAllbutton_Click);
            // 
            // OpenSeatsbutton
            // 
            this.OpenSeatsbutton.Location = new System.Drawing.Point(660, 65);
            this.OpenSeatsbutton.Name = "OpenSeatsbutton";
            this.OpenSeatsbutton.Size = new System.Drawing.Size(108, 34);
            this.OpenSeatsbutton.TabIndex = 2;
            this.OpenSeatsbutton.Text = "Open Seats < 50";
            this.OpenSeatsbutton.UseVisualStyleBackColor = true;
            this.OpenSeatsbutton.Click += new System.EventHandler(this.OpenSeatsbutton_Click);
            // 
            // Totalbutton
            // 
            this.Totalbutton.Location = new System.Drawing.Point(660, 105);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(108, 34);
            this.Totalbutton.TabIndex = 3;
            this.Totalbutton.Text = "Total Seats 120 - 260";
            this.Totalbutton.UseVisualStyleBackColor = true;
            this.Totalbutton.Click += new System.EventHandler(this.Totalbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(660, 145);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(108, 34);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "Add Record";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(660, 212);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(108, 34);
            this.Deletebutton.TabIndex = 5;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(660, 185);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(108, 21);
            this.comboBox.TabIndex = 6;
            // 
            // frmTheatres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 436);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Totalbutton);
            this.Controls.Add(this.OpenSeatsbutton);
            this.Controls.Add(this.ViewAllbutton);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmTheatres";
            this.Text = "Theatres";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ViewAllbutton;
        private System.Windows.Forms.Button OpenSeatsbutton;
        private System.Windows.Forms.Button Totalbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

