﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList myListForm = new frmList();
            myListForm.MdiParent = this;
            myListForm.Show();
        }
    }
}
