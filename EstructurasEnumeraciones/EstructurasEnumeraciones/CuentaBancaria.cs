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
    public struct banco
    {
        string nombre;
        float ahorros;
        float corriente;
        float credito;

        public banco(string n,float a,float co,float cr)
        {
            nombre=n;
            ahorros = a;
            corriente = co;
            credito = cr;

        }
    }
    public partial class CuentaBancaria : Form
    {
        public CuentaBancaria()
        {
            InitializeComponent();
        }

        private void cuentaEnter_Click(object sender, EventArgs e)
        {


            string nombre = "";
                nombre = NombretextBox.Text;
           float ahorros = 0;
                ahorros= float.Parse(AhorrosBox1.Text);
            float corriente = 0;
            corriente= float.Parse(CorrienteBox2.Text);
            float credito = 0;
            credito= float.Parse(CreditostextBox3.Text);

            if(nombre=="" && ahorros==0 && corriente==0 && credito==0)
            {
                MessageBox.Show("LLene las casillas ");
            }
            else
            {
                banco ban = new banco(nombre,ahorros,corriente,credito);

                MessageBox.Show("Guardado Completo");

            }
          



        }
    }
}
