﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                    return;
            }
            
            
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            Form1 ventana = new Form1();
            ventana.ShowDialog();

        }
    }
}
