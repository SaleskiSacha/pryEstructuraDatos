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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            Pila.Agregar(nuevo);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigo.Text = Pila.Primero.Codigo.ToString();
                lblNombre.Text = Pila.Primero.Nombre;
                lblTramite.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
            }
            else
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
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
    }
}
