using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioListaDoble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista l = new Lista();
        int codigo;
        string nombre;
        int cantidad;
        int precio;
        Nodo n1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            nombre = textBox2.Text;
            cantidad = Convert.ToInt32(textBox3.Text);
            precio = Convert.ToInt32(textBox4.Text);
            n1 = new Nodo(codigo, nombre, cantidad, precio);
            l.agregar(n1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            l.eliminar(codigo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            int cantidad = Convert.ToInt32(textBox3.Text);
            int precio = Convert.ToInt32(textBox4.Text);
            int posicion = int.Parse(textBox6.Text);

            l.insertar(new Nodo(codigo, nombre, cantidad, precio), posicion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nodo n1;
            int b = Convert.ToInt32(textBox6.Text);
            n1 = l.buscar(b);
            if (n1 != null)
            {
                textBox5.Text = n1.ToString();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text += l.lista();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text += l.reporteI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l.eliminarPrimero();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            l.eliminarUltimo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
            nombre = textBox2.Text;
            cantidad = Convert.ToInt32(textBox3.Text);
            precio = Convert.ToInt32(textBox4.Text);
            n1 = new Nodo(codigo, nombre, cantidad, precio);
            l.agregarInicio(n1);
        }
    }
}