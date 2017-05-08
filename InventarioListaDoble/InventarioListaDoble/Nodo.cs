using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListaDoble
{
    class Nodo
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        public Nodo siguiente;
        public Nodo anterior;

        public Nodo(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
            siguiente = null;
        }
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public override string ToString()
        {
            string show = "";
            show += "Código  : " + Codigo + Environment.NewLine;
            show += "Nombre  : " + Nombre + Environment.NewLine;
            show += "Cantidad: " + Cantidad + Environment.NewLine;
            show += "Costo $ : " + Costo + Environment.NewLine;
            return show;
        }
    }
}

