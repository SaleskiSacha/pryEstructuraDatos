using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero { get { return pri; }set { pri = value; } }
        public clsNodo Ultimo { get { return ult; }set { ult = value; } }

        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Auxiliar = Primero;//Puntero Guia
                        clsNodo Anterior = Primero;//Toma el valor anterior del puntero AUX

                        while (Auxiliar.Codigo < Nuevo.Codigo)
                        {
                            Anterior = Auxiliar;
                            Auxiliar = Auxiliar.Siguiente;
                        }
                        Anterior.Siguiente = Nuevo;
                        Nuevo.Siguiente = Auxiliar;
                        Auxiliar.Anterior = Nuevo;
                        Nuevo.Anterior = Anterior;
                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo) 
        {

            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {

                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {

                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo != Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Aux = Aux.Siguiente;
                        Ant.Siguiente = Aux;
                        Aux.Anterior = Ant;

                    }
                }


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
                listBox.Items.Add(AUX.Codigo + "  " + AUX.Nombre + "  " + AUX.Tramite);
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
        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }

        }
        public void RecorrerDes(ListBox Lista)
        {
            clsNodo aux = ult;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }

        }
    }
}
