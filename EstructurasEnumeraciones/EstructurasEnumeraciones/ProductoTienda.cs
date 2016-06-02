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
    public partial class ProductoTienda : Form
    {
        public ProductoTienda()
        {
            InitializeComponent();
        }

       public struct tienda
        {
        public string product;
        public float val;
            
            public tienda(string producto,float valor)
            {
                product = producto;
                val = valor;
            }

        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            tienda t;
            t.product = NombretextBox.Text;
            t.val =float.Parse(CostotextBox2.Text);

            ResultadolistBox.Items.Add("Nombre: "+t.product.ToString());
            ResultadolistBox.Items.Add("Costo : "+t.val.ToString());
        }
    }
    
}
