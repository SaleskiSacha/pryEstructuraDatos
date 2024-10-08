﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace pryEstructuraDatos
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsNodo clsNodo = new clsNodo();
        clsCola FilaPersonas = new clsCola();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaPersonas.Agregar(objNodo);
            FilaPersonas.Recorrer(dgv1);
            FilaPersonas.Recorrer(lsbMostrar);
            FilaPersonas.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                lblCodigo.Text = FilaPersonas.Primero.Codigo.ToString();
                lblNombre.Text = FilaPersonas.Primero.Nombre;
                lblTramite.Text = FilaPersonas.Primero.Tramite;
                FilaPersonas.Eliminar();
                FilaPersonas.Recorrer(dgv1);
                FilaPersonas.Recorrer(lsbMostrar);
                FilaPersonas.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
        private void Validaciones()
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtTramite.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            newobj.ShowDialog();
            this.Hide();
        }
    }
}
