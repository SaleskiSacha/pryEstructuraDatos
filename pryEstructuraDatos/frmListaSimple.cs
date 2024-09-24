using System;
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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsNodo clsNodo = new clsNodo();
       clsListaSimple ListaSimple = new clsListaSimple();
        Int32 Codigo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            ListaSimple.Agregar(nuevo);
            ListaSimple.Recorrer(dgv1);
            ListaSimple.Recorrer(cmb1);
            ListaSimple.Recorrer(lst1);
            ListaSimple.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaSimple.Primero != null)
            {


                Codigo = Convert.ToInt32(cmb1.Text);
                ListaSimple.Eliminar(Codigo);
                ListaSimple.Recorrer(dgv1);
                ListaSimple.Recorrer(lst1);
                ListaSimple.Recorrer(cmb1);
                ListaSimple.Recorrer();

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
