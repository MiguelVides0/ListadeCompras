using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class verlst : Form
    {
        string codlista;
        public verlst(string codlista)
        {
            InitializeComponent();
            this.codlista = codlista;
            metlistas ensenar = new metlistas();
            dataGridView1.DataSource = ensenar.buscar((string)codlista);
            rsum sum = ensenar.sumar(codlista);
            textBox1.Text = sum.Total.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            crlst abrir = new crlst();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
          
                id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                editar edita = new editar(id);
                edita.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cdlst;
            metlistas ensenar = new metlistas();
            try
            {
                cdlst = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                dataGridView1.DataSource = ensenar.buscar((string)cdlst);
                rsum sum = ensenar.sumar(cdlst);
                textBox1.Text = sum.Total.ToString();
            }catch
            {
                MessageBox.Show("No se pudo actualizar");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            eliminar elim = new eliminar(id);
            elim.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
