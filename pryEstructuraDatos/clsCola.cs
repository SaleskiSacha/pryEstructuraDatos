using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
namespace pryEstructuraDatos
{
    internal class clsCola

    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero { get { return pri; } set { pri = value; } }
        public clsNodo Ultimo { get { return ult; } set { ult = value; } }

        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo; //el ultimo dato en llegar es el siguiente y se convierte en el ultimo
                Ultimo = Nuevo;
            }
        }
        public void Eliminar() 
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
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
                listBox.Items.Add(AUX.Codigo + " " + AUX.Nombre + " " + AUX.Tramite);
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
                AUX= AUX.Siguiente;
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
