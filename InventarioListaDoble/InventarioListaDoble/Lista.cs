using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListaDoble
{
    class Lista
    {
        public Nodo primero = null;
        public Nodo ultimo = null;
    

        public Lista()
        {

        }
        //AGREGAR
        public void agregar(Nodo nodo)
        {
            if (primero == null)
                primero = nodo;
            else
                agregar(primero, nodo);
        }

        private void agregar(Nodo ultimo, Nodo nodo)
        {
            if (ultimo.siguiente == null)
                ultimo.siguiente = nodo;
            else
                agregar(ultimo.siguiente, nodo);

        }
        //AGREGAR INICIO
        public void agregarInicio(Nodo nuevoNodo)
        {
            if (primero == null)
            {
                primero = nuevoNodo;
               
            }
            else
            {
                nuevoNodo.siguiente = primero;
                primero.anterior = nuevoNodo;
                primero = nuevoNodo;
            }
        }
        //BUSQUEDA
        public Nodo buscar(int codigo)
        {
            Nodo search = primero;
            while (search != null)
            {
                if (search.Codigo == codigo)
                {
                    return search;
                }
                else
                {
                    search = search.siguiente;
                }
            }
            return null;
        }
        //ELIMINAR
        public void eliminar(int codigo)
        {
            if (primero.Codigo == codigo)
            {
                primero = primero.siguiente;

            }
            else
            {
                Nodo temporal = primero;

                while (temporal.siguiente != null)
                {
                    if (temporal.siguiente.Codigo == codigo)
                    {
                        temporal.siguiente = temporal.siguiente.siguiente;

                        break;
                    }
                    else
                    {
                        temporal = temporal.siguiente;
                    }
                }
            }

        }
        //ELIMINAR PRIMERO
        public string eliminarPrimero()
        {
            if (primero != null)
            {
                primero = primero.siguiente;
                primero.anterior = null;
                return " ";
            }
            else
                return null;
        }
        //ELIMINAR ULTIMO
        public string eliminarUltimo()
        {
            
            if (ultimo != null)
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;
                return " ";
            }
            else
                return null;
        }
        //INSERTAR
        public void insertar(Nodo producto, int posicion)
        {
            {
                if ((primero != null) && (posicion > 0))
                {
                    Nodo temp = primero;
                    int inicio = 1;
                    while (true)
                    {
                        if (inicio <= posicion)
                        {
                            producto.siguiente = temp.siguiente;
                            temp.siguiente = producto;
                            break;
                        }
                        else
                        {
                            inicio++;
                            temp = temp.siguiente;
                        }
                    }
                }

            }
        }
        //REPORTE INVERSO
        public string reporteI()
        {
            if (primero == null)
                return "";
            else
                return reporteI(primero);

        }
        public string reporteI(Nodo nodo)
        {
            if (nodo.siguiente == null)
                return nodo.ToString() + Environment.NewLine;
            else
                return reporteI(nodo.siguiente) + nodo.ToString() + Environment.NewLine;
        }
        //LISTA
        public string lista()
        {
            string show = ToString() + Environment.NewLine;
            Nodo temporal = primero;
            while (temporal != null)
            {
                show += " " + Environment.NewLine;
                show += temporal.ToString();
                temporal = temporal.siguiente;
            }
            return show;
        }

    }
}

