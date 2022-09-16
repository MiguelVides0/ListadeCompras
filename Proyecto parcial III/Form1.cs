using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_parcial_III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metlistas probar = new metlistas();
            if (probar.conectado())
            {
                MessageBox.Show("Si funciona, Alegrése");
            }
            else
            {
                MessageBox.Show("No sirve la conexión");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crlst crearlsts = new crlst();
            crearlsts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listascrud verlst = new listascrud();
            verlst.Show();
        }
    }
}
