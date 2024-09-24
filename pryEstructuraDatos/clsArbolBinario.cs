using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {

        private clsNodo PrimerNodo;
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null) Raiz = Nuevo;
            else
            {
                clsNodo nodoPadre = Raiz; // Este seria el nodo padre del que se agrega el nuevo
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    nodoPadre = aux;
                    if (Nuevo.Codigo < aux.Codigo) aux = aux.Izquierdo;
                    else aux = aux.Derecho;
                }
                if (Nuevo.Codigo < nodoPadre.Codigo) nodoPadre.Izquierdo = Nuevo;
                else nodoPadre.Derecho = Nuevo;
            }
        }
        public void Eliminar(Int32 cod)
        {
            i = 0; // inicializar el indice
            GrabarVectorInOrden(Raiz, cod); // Aca graba en orden en el vector
            Raiz = null; // se destruye el arbol
            EquilibrarArbol(0, i - 1); // Aca se crea denuevo el arbol
        }
        private void GrabarVectorInOrden(clsNodo NodoRecibido, Int32 cod)
        {
            if (NodoRecibido.Izquierdo != null) GrabarVectorInOrden(NodoRecibido.Izquierdo, cod);
            if (NodoRecibido.Codigo != cod)
            {
                Vector[i] = NodoRecibido;
                i++;
            }
            if (NodoRecibido.Derecho != null) GrabarVectorInOrden(NodoRecibido.Derecho, cod);
        }
        public void Equilibrar()
        {
            i = 0; // inicializar el indice
            GrabarVectorInOrden(Raiz); // Aca graba en orden en el vector
            Raiz = null; // se destruye el arbol
            EquilibrarArbol(0, i - 1); // Aca se crea denuevo el arbol
        }
        private void GrabarVectorInOrden(clsNodo NodoRecibido)
        {
            if (NodoRecibido.Izquierdo != null) GrabarVectorInOrden(NodoRecibido.Izquierdo);
            Vector[i] = NodoRecibido;
            i++;
            if (NodoRecibido.Derecho != null) GrabarVectorInOrden(NodoRecibido.Derecho);
        }
        private void EquilibrarArbol(Int32 inicio, Int32 fin)
        {
            Int32 mitad = (inicio + fin) / 2;
            if (inicio <= fin)
            {
                Agregar(Vector[mitad]);
                EquilibrarArbol(inicio, mitad - 1);
                EquilibrarArbol(mitad + 1, fin);
            }
        }
        public void RecorrerAsc(DataGridView dgvGrilla)
        {
            dgvGrilla.Rows.Clear();
            InOrdenAsc(dgvGrilla, Raiz);
        }
        private void InOrdenAsc(DataGridView dgvGrilla, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgvGrilla, R.Izquierdo);
            dgvGrilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgvGrilla, R.Derecho);
        }
        public void RecorrerDes(DataGridView dgvGrilla)
        {
            dgvGrilla.Rows.Clear();
            InOrdenDes(dgvGrilla, Raiz);
        }
        private void InOrdenDes(DataGridView dgvGrilla, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDes(dgvGrilla, R.Derecho);
            dgvGrilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(dgvGrilla, R.Izquierdo);
        }
        public void RecorrerAsc(ComboBox cmbListado)
        {
            cmbListado.Items.Clear();
            InOrdenAsc(cmbListado, Raiz);
        }
        private void InOrdenAsc(ComboBox cmbListado, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmbListado, R.Izquierdo);
            cmbListado.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(cmbListado, R.Derecho);
        }
        public void RecorrerDes(ComboBox cmbListado)
        {
            cmbListado.Items.Clear();
            InOrdenDes(cmbListado, Raiz);
        }
        private void InOrdenDes(ComboBox cmbListado, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDes(cmbListado, R.Derecho);
            cmbListado.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenDes(cmbListado, R.Izquierdo);
        }
        public void Recorrer(TreeView tvArbol)
        {
            tvArbol.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tvArbol.Nodes.Add(nodoPadre);
            PreOrden(nodoPadre, Raiz);
            tvArbol.ExpandAll();
        }
        private void PreOrden(TreeNode nodoTree, clsNodo R)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTree.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(nodoPadre, R.Izquierdo);
            if (R.Derecho != null) PreOrden(nodoPadre, R.Derecho);
        }
    }


}

