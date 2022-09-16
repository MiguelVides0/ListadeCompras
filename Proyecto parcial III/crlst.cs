using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class crlst : Form
    {
        public crlst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metlistas ometelistas = new metlistas();
            int precio = 0;
            precio = int.Parse(textBox5.Text);
            try
            {
                ometelistas.agregar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, precio);
                dataGridView1.DataSource = ometelistas.buscar(textBox1.Text);
                rsum sumar = ometelistas.sumar(textBox1.Text);
                textBox6.Text = sumar.Total.ToString();
                textBox4.Clear();
                textBox5.Clear();
                textBox4.Focus();
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dataGridView1.DataSource=null;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
