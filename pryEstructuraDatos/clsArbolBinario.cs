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
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        //PROCEDIMIENTOS RECORRER INORDENASC
        public void InOrdenAsc(ListBox Lista, clsNodo R) //POR LISTA
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }



        public void InOrdenAsc(ComboBox Combo, clsNodo R) //POR COMBO
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, clsNodo R) //POR GRILLA 
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);

        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(TreeNodeCollection nodoPadre, clsNodo Raiz)
        {
            TreeNode nodonuevo = nodoPadre.Add(Raiz.Codigo.ToString());
            if (Raiz.Izquierdo != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Izquierdo);

            if (Raiz.Derecho != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Derecho);
        }

        public void Recorrer(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenAsc(treeView.Nodes, Raiz);
        }

        public void RecorrerSW(StreamWriter sw) //CREAR ARCHIVO
        {
            InOrdenAsc(sw, Raiz);
        }

        public void InOrdenAsc(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(sw, R.Izquierdo);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Derecho != null) InOrdenAsc(sw, R.Derecho);
        }
        //PROCEDIMIENTOS RECORRER INORDEN DESCENDENTE

        public void InOrdenDes(ListBox Lista, clsNodo R) //POR LISTA
        {
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
        }

        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, clsNodo R) //POR COMBO
        {
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
        }

        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, clsNodo R) //POR GRILLA
        {
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
        }

        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void InOrdenDes(TreeNodeCollection NodoPadre, clsNodo R)
        {
            if (R.Derecho != null) InOrdenAsc(NodoPadre, R.Derecho);
            TreeNode nodoNuevo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(NodoPadre, R.Izquierdo);
        }

        public void RecorrerDes(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenDes(treeView.Nodes, Raiz);
        }

        public void RecorrerDesSW(StreamWriter sw) //CREAR ARCHIVO
        {
            InOrdenDes(sw, Raiz);
        }

        public void InOrdenDes(StreamWriter Sw, clsNodo R)
        {
            if (R.Derecho != null) InOrdenDes(Sw, R.Derecho);
            Sw.Write(R.Codigo);
            Sw.Write(";");
            Sw.Write(R.Nombre);
            Sw.Write(";");
            Sw.WriteLine(R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(Sw, R.Izquierdo);
        }



        //PROCEDIMIENTOS RECORRER PREORDEN

        public void PreOrden(ListBox Lista, clsNodo R) //POR LISTA
        {
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }

        public void PreOrden(ComboBox Combo, clsNodo R) //POR COMBO
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void PreOrden(DataGridView Grilla, clsNodo R) //POR GRILLA
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void PreOrden(TreeNodeCollection Npadre, clsNodo R)
        {
            TreeNode nodoNuevo = Npadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);
        }

        public void RecorrerPreOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PreOrden(treeView.Nodes, Raiz);
        }

        public void RecorrerPreOrdenSW(StreamWriter sw) //CREAR ARCHIVO
        {
            PreOrden(sw, Raiz);
        }
        public void PreOrden(StreamWriter sw, clsNodo R)
        {
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(sw, R.Izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
        }



        //PROCEDIMIENTOS RECORRER POSTORDEN

        public void PostOrden(ListBox Lista, clsNodo R) //POR LISTA
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }

        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        public void PostOrden(ComboBox Combo, clsNodo R) //POR COMBO
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }

        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(DataGridView Grilla, clsNodo R) //POR GRILLA
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        public void PostOrden(TreeNodeCollection Npadre, clsNodo R)
        {
            TreeNode nodoNuevo = Npadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);

        }

        public void RecorrerPostOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PostOrden(treeView.Nodes, Raiz);
        }

        public void RecorrerPostOrdenSW(StreamWriter sw)
        {
            PostOrden(sw, Raiz);
        }
        public void PostOrden(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenDes(sw, R.Izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
        }



        //METODO ELIMINAR
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        private int EliminoNodos;

        public void Equilibrar()
        {
            i = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Equilibrar(int Nodo)
        {
            EliminoNodos = Nodo;
            i = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);

        }

        private void CargarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        //METODO ELIMINAR
        private clsNodo EliminarNodos(clsNodo NodoActual, Int32 Codigo)
        {
            if (NodoActual == null)
            {
                return null;
            }
            if (Codigo < NodoActual.Codigo)
            {
                NodoActual.Izquierdo = EliminarNodos(NodoActual.Izquierdo, Codigo);
            }
            else if (Codigo > NodoActual.Codigo)
            {
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, Codigo);
            }
            else
            {
                if (NodoActual.Izquierdo == null)
                {
                    return NodoActual.Derecho;
                }
                else if (NodoActual.Derecho == null)
                {
                    return NodoActual.Izquierdo;
                }

                clsNodo Sucesor = NodoActual.Derecho;
                while (Sucesor.Izquierdo != null)
                {
                    Sucesor = Sucesor.Izquierdo;
                }
                NodoActual.Codigo = Sucesor.Codigo;
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, Sucesor.Codigo);
            }
            return NodoActual;
        }

        public void Eliminar(Int32 Codigo)
        {
            Raiz = EliminarNodos(Raiz, Codigo);
        }

        //Recorrer
        public void Recorrer(ComboBox combo, bool ascedente, string recorrer)
        {
            combo.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(combo, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(combo, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(combo, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(combo, Raiz);
            }
        }
        public void Recorrer(ListBox lst, bool ascedente, string recorrer)
        {
            lst.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(lst, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(lst, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(lst, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(lst, Raiz);
            }
        }
        public void Recorrer(StreamWriter sw, bool ascedente, string recorrer)
        {
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(sw, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(sw, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(sw, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(sw, Raiz);
            }
        }
        public void Recorrer(DataGridView Grilla, string recorrer, bool ascedente)
        {
            Grilla.Rows.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(Grilla, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(Grilla, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(Grilla, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(Grilla, Raiz);
            }
        }

        public bool Busqueda(Int32 Codigo)
        {
            clsNodo auxiliar = Raiz;
            while (auxiliar != null && auxiliar.Codigo != Codigo)
            {
                if (Codigo < auxiliar.Codigo)
                {
                    auxiliar = auxiliar.Izquierdo;
                }
                else
                {
                    auxiliar = auxiliar.Derecho;
                }
            }
            if (auxiliar != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
