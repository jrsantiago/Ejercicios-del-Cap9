using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasEnumeraciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productoDeTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cuenaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoTienda tienda = new ProductoTienda();
            tienda.Show();
        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaBancaria ban = new CuentaBancaria();
            ban.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MascotaDueno m = new MascotaDueno();
            m.Show();
        }

        private void neumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neumaticos neu = new Neumaticos();
            neu.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TiposEstrellas tipo = new TiposEstrellas();
            tipo.Show();
        }
    }
}
