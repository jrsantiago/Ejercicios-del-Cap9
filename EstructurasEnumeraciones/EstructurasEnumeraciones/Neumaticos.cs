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
    public partial class Neumaticos : Form
    {
        enum neumaticos { Diagonales = 1, Radianes, Autoportante, AllSeasons, Tubuless, PerfilBajo };
        public Neumaticos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(numtextBox.Text);
            neumaticos neu = (neumaticos)numero;

            listBox1.Items.Add((neumaticos)numero);

        }
    }
}






