using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void MenúPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            Pila ventana= new Pila();
            ventana.Show();
            this.Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            Colas ventana = new Colas();
            ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaEnlazada ventana = new ListaEnlazada();
            ventana.Show();
            this.Hide();
        }
    }
}
