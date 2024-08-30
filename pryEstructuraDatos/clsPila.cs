using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsPila
    {
        private clsNodo pri;
        
        public clsNodo Primero { get { return pri; } set { pri = value; } }

        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else 
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;   
            }
        }
        public void Eliminar() 
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
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
