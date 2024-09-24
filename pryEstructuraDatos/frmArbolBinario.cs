using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nuevo = new clsNodo();
            Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Tramite = txtTramite.Text;

            Arbol.Agregar(Nuevo);
            Arbol.Recorrer(trvVer);
            Arbol.RecorrerAsc(dgv1);
            Arbol.RecorrerAsc(cmb1);
            optInOrden.Checked = true;

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            btnEquilibrar.Enabled = true;
            txtCodigo.Select();
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.Recorrer(trvVer);
        }

        private void optInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDes(dgv1);
            Arbol.RecorrerDes(cmb1);
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerAsc(dgv1);
            Arbol.RecorrerAsc(cmb1);
        }
        private void Validaciones()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            Validaciones();
            btnEquilibrar.Enabled = false;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(trvVer);
            Arbol.RecorrerAsc(dgv1);
            Arbol.RecorrerAsc(cmb1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                if (cmb1.Text != "")
                {
                    int cod = Convert.ToInt32(cmb1.Text);
                    Arbol.Eliminar(cod);
                    Arbol.Recorrer(trvVer);
                    Arbol.RecorrerAsc(dgv1);
                    Arbol.RecorrerAsc(cmb1);
                    cmb1.Text = "";
                }
                else
                {
                    MessageBox.Show("Debe colocar un código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacía", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            newobj.ShowDialog();
            this.Hide();
        }
    }
}
