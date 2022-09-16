using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class editar : Form
    {
        int id;
        public editar(int id)
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
            metlistas act = new metlistas();
            try
            {
                act.editar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), (int)id);
                MessageBox.Show("La información de ha editado");
            }
            catch
            {
                MessageBox.Show("Fallo al editar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
