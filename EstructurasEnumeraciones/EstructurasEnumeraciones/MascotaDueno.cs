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
    public partial class MascotaDueno : Form
    {
        public MascotaDueno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = duenotextBox.Text;
            string oficio = oficiotextBox.Text;
            string domicilio = domiciliotextBox.Text;


            string mascota = MascotatextBox.Text;
            int dia = int.Parse(DiatextBox.Text);
            int mes = int.Parse(MestextBox.Text);
            int ano = int.Parse(AnotextBox.Text);
            string papeles = CompratextBox.Text;

            try
            {
                mascota mas = new mascota(mascota, dia, mes, ano, papeles, nombre, oficio, domicilio);
            }
            catch (Exception) { MessageBox.Show("Complete Espacios bacios");}
            finally
            {
                MessageBox.Show("Registro Realizado");
            }
        }
    }

    public struct dueno
    {
        string nombre;
        string trabajo;
        string Domicilio;

        public dueno(string n, string t, string d)
        {
            nombre = n;
            trabajo = t;
            Domicilio = d;
        }

    }


    public struct mascota
    {
        string nombre;
        int dia, mes, ano;
        string papeles;

        public mascota(string n, int d, int m, int a, string pa, string nomDue, string trabajo, string domicilio)
        {
            nombre = n;
            dia = d;
            mes = m;
            ano = a;
            papeles = pa;

            dueno dueno = new dueno(nomDue, trabajo, domicilio);

        }
    }
}