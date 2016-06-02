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

    public partial class TiposEstrellas : Form
    {
        enum estrellas { Protoestrella=1,EnanaBlanca,EnanaRoja,EstrellaRoja};
        public TiposEstrellas()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumerotextBox.Text);
            estrellas estre = (estrellas)num;



            listBox.Items.Add((estrellas)num);
        }
    }
}
