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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Listadoble = new clsListaDoble();
        Int32 Codigo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            Listadoble.Agregar(objNodo);
            Listadoble.Recorrer(dgv1);
            Listadoble.Recorrer(lst1);
            Listadoble.Recorrer(cmb1);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Listadoble.Primero != null)
            {

                Codigo = Convert.ToInt32(cmb1.Text);
                Listadoble.Eliminar(Codigo);
                Listadoble.Recorrer(dgv1);
                Listadoble.Recorrer(cmb1);
                Listadoble.Recorrer(lst1);
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Listadoble.Recorrer(dgv1);
            Listadoble.Recorrer(cmb1);
            Listadoble.Recorrer(lst1);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Listadoble.RecorrerDes(dgv1);
            Listadoble.RecorrerDes(cmb1);
            Listadoble.RecorrerDes(lst1);
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
