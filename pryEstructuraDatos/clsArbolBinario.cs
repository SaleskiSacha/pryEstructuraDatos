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
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodo nvo)
        {
            nvo.Izquierdo = null;
            nvo.Derecho = null;
            if (Raiz == null) Raiz = nvo;
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (nvo.Codigo < NodoPadre.Codigo) NodoPadre.Izquierdo = nvo;
                else NodoPadre.Derecho = nvo;
            }
        }
        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenAsc(grilla, Raiz);

        }
        public void InOrdenAsc(DataGridView grilla, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(grilla, R.Izquierdo);
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(grilla, R.Derecho);
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ComboBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }
        private void InOrdendes(DataGridView grilla, clsNodo R)
        {

            if (R.Derecho != null) InOrdenAsc(grilla, R.Derecho);
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(grilla, R.Izquierdo);
        }
        private void InOrdendes(ComboBox lst, clsNodo R)
        {
            if (R.Derecho != null) InOrdendes(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdendes(lst, R.Izquierdo);

        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        private void Eliminar(Int32 Codigo) 
        {
            i = 0;//inicializo el vector para mover los datos
            GrabarVectorInOrden(Raiz, Codigo);//grabamos in orden
            Raiz = null; //al declararle nulo borra la raiz y el arbol queda nullo
            EquilibrarArbol(0, i - 1);//esto crea el arbol nuevamente
        }
        private void GrabarVectorInOrden(clsNodo NodoRecibido, Int32 Codigo)
        {
            if (NodoRecibido.Izquierdo != null)
                GrabarVectorInOrden(NodoRecibido.Izquierdo);
            if (NodoRecibido.Codigo != Codigo)
            {
                Vector[i] = NodoRecibido;
                i++;
            }
            if (NodoRecibido.Derecho != null)
                GrabarVectorInOrden(NodoRecibido.Derecho);
        }
        public void Equilibrar() 
        {
            i = 0;//inicializo el vector para mover los datos
            GrabarVectorInOrden(Raiz);//grabamos in orden
            Raiz = null; //al declararle nulo borra la raiz y el arbol queda nullo
            EquilibrarArbol(0, i - 1);//esto crea el arbol nuevamente

        }
        private void EquilibrarArbol(Int32 ini, Int32 fin) 
        {
            Int32 m = (ini / fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m-1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoRecibido) 
        {
            if (NodoRecibido.Izquierdo != null)
                GrabarVectorInOrden(NodoRecibido.Izquierdo);
            Vector[i] = NodoRecibido;
            i++;
            if (NodoRecibido.Derecho != null)
                GrabarVectorInOrden(NodoRecibido.Derecho);
        }
        
    }
}
