using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace pryEstructuraDatos
{
    internal class clsListaSimple
    {
        private clsNodo pri;
        public clsNodo Primero
        { get { return pri; } set { pri = value; } }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo Ant = Primero;
                    clsNodo Aux = Primero;
                    while (Aux != null && Nuevo.Codigo > Aux.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }
                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = Aux;

                }
            }
        }
        public void Eliminar(Int32 Cod)
        {
            if (Cod == Primero.Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Aux = Primero;
                clsNodo Ant = Primero;
                while (Cod != Aux.Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }
                Ant.Siguiente = Aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView grilla)
        {
            clsNodo AUX = Primero;
            grilla.Rows.Clear();
            while (AUX != null)
            {
                grilla.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
            }
        }
        public void Recorrer(ListBox listBox)
        {
            clsNodo AUX = Primero;
            listBox.Items.Clear();
            while (AUX != null)
            {
                listBox.Items.Add(AUX.Codigo);
                AUX = AUX.Siguiente;
            }
        }
        public void Recorrer(ComboBox cmb)
        {
            clsNodo AUX = Primero;
            cmb.Items.Clear();
            while (AUX != null)
            {
                cmb.Items.Add(AUX.Nombre);
                AUX = AUX.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo AUX = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (AUX != null)
            {
                AD.Write(AUX.Codigo);
                AD.Write(";");
                AD.Write(AUX.Nombre);
                AD.Write(";");
                AD.Write(AUX.Tramite);
                AUX = AUX.Siguiente;
            }
            AD.Close();
        }
    }
}
