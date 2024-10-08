﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lineaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple newobj = new frmListaSimple();
            newobj.ShowDialog();
            this.Hide();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola newobj = new frmCola();
            newobj.ShowDialog();
            this.Hide();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila newobj = new frmPila();
            newobj.ShowDialog();
            this.Hide();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario newobj = new frmArbolBinario();
            newobj.ShowDialog();
            this.Hide();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble newobj = new frmListaDoble();
            newobj.ShowDialog();
            this.Hide();
        }
    }
}
