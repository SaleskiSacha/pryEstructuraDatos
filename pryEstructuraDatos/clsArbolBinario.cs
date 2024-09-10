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
        private void InOrdenAsc(DataGridView grilla, clsNodo R)
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
        private void InOrdenAsc(ComboBox lst, clsNodo R) 
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }
    }
}
