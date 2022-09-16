using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class eliminar : Form
    {
        int id;
        public eliminar(int id)
        {
            InitializeComponent();
            this.id = id;
            int precio = 0;
            metlistas olistas = new metlistas();
            objetoslst olst = olistas.mostrar((int)id);
            textBox1.Text = olst.Codigolista;
            textBox2.Text = olst.Fechacompra;
            textBox3.Text = olst.Supermercado;
            textBox4.Text = olst.Producto;
            precio = (int)olst.Precio;
            textBox5.Text = precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metlistas borrar = new metlistas();
            try
            {
                borrar.eliminar((int)id);
                MessageBox.Show("La información se ha borrado");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch
            {
                MessageBox.Show("Error al borrar la información");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
