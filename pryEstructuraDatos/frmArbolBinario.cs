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
        clsArbolBinario ArbolBinario = new clsArbolBinario();
        public bool asc;
        public string recorrer;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ArbolBinario.Busqueda(Convert.ToInt32(txtCodigo.Text)) == false)
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;
                StreamWriter Sw = new StreamWriter("./ArbolBinario.csv", false);

                ArbolBinario.Agregar(objNodo);

                if (optInOrden.Checked)
                {
                    if (optInOrden.Checked)
                    {
                        ArbolBinario.Recorrer(dgv1);
                        //ArbolBinario.Recorrer(lst1);
                        ArbolBinario.Recorrer(cmb1);
                        ArbolBinario.Recorrer(trvVer);
                        ArbolBinario.RecorrerSW(Sw);


                    }
                    else
                    {
                        ArbolBinario.RecorrerDes(dgv1);
                        ArbolBinario.RecorrerDes(cmb1);
                        //ArbolBinario.RecorrerDes(lstB);
                        ArbolBinario.RecorrerDes(trvVer);
                        ArbolBinario.RecorrerDesSW(Sw);

                    }
                }
                if (optPreOrden.Checked)
                {
                    ArbolBinario.RecorrerPreOrden(dgv1);
                    ArbolBinario.RecorrerPreOrden(cmb1);
                    //ArbolBinario.RecorrerPreOrden(lstB);
                    ArbolBinario.RecorrerPreOrden(trvVer);
                    ArbolBinario.RecorrerPreOrdenSW(Sw);
                }
                if (optPostOrden.Checked)
                {
                    ArbolBinario.RecorrerPostOrden(dgv1);
                    ArbolBinario.RecorrerPostOrden(cmb1);
                    //ArbolBinario.RecorrerPostOrden(lstB);
                    ArbolBinario.RecorrerPostOrden(trvVer);
                    ArbolBinario.RecorrerPostOrdenSW(Sw);
                }
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                Sw.Close();
                Sw.Dispose();

            }
            else
            {
                MessageBox.Show("El codigo se repite, no se pudo cargar");
            }

        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            optInOrden.Checked = true;
            optInOrdenDes.Checked = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if ((ArbolBinario.Raiz != null) && (cmb1.SelectedIndex != -1))
            {
                ArbolBinario.Eliminar(Convert.ToInt32(cmb1.SelectedItem));
                SeleccionRecorrido();
               // RecorrerElementos();


                if (ArbolBinario.Raiz == null)
                {
                    dgv1.Rows.Clear();
                    cmb1.Items.Clear();
                    //lstB.Items.Clear();
                    trvVer.Nodes.Clear();
                    File.Delete("./ArbolBinario.csv");
                }

            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigo.Focus();

        }
        public void SeleccionRecorrido()
        {
            if (optInOrden.Checked)
            {
                recorrer = "InOrden";
                if (optInOrden.Checked)
                {
                    asc = true;
                }
                else if (optInOrdenDes.Checked)
                {
                    asc = false;
                }
            }
            else if (optPostOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (optPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
