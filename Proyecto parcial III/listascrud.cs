using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class listascrud : Form
    {
        public listascrud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metlistas ver = new metlistas();
            dataGridView1.DataSource = ver.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codlista;
            try
            {
                codlista = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                verlst ver = new verlst(codlista);
                ver.Show();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una lista");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
