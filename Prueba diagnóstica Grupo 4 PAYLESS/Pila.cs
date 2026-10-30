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
    public partial class Pila : Form
    {
        private Stack<string> historialPila = new Stack<string>();

        public Pila()
        {
            InitializeComponent();
            ActualizarInterfaz();
        }

        private void Pila_Load(object sender, EventArgs e)
        {

        }


        private void ActualizarInterfaz()
        {
            // 1. Actualizar el ListBox con los elementos de la pila
            lstContenidoPila.Items.Clear();

            if (historialPila.Count > 0)
            {
                // Convertimos la pila a array para mantener el orden visual (cima arriba)
                string[] elementos = historialPila.ToArray();
                for (int i = 0; i < elementos.Length; i++)
                {
                    // Mostramos el número de orden y la URL (ej: "3 · curso-csharp.com")
                    int nivel = elementos.Length - i;
                    lstContenidoPila.Items.Add($"{nivel} · {elementos[i]}");
                }

                // 2. Actualizar el cuadro de "Página actual" con la cima (Peek)
                txtPaginaActual.Text = historialPila.Peek();
            }
            else
            {
                lstContenidoPila.Items.Add("(historial vacío)");
                txtPaginaActual.Text = "—";
            }
        }

        private void btnVisitar_Click(object sender, EventArgs e)
        {
            string url = txtDireccion.Text.Trim();

            // Validación de entrada en blanco
            if (string.IsNullOrEmpty(url))
            {
                MostrarMensaje("Escribe una dirección web antes de visitar.", esError: true);
                return;
            }

            // Limpiamos prefijos si el usuario los escribe para estandarizar
            url = url.Replace("https://", "").Replace("http://", "");

            // Operación Push
            historialPila.Push(url);
            txtDireccion.Clear();

            ActualizarInterfaz();
            MostrarMensaje($"Visitaste {url} (Push).", esError: false);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Validación para evitar excepciones si la pila está vacía
            if (historialPila.Count > 0)
            {
                string urlSalida = historialPila.Pop();
                ActualizarInterfaz();

                string aviso = historialPila.Count > 0
                    ? $"Saliste de {urlSalida} (Pop)."
                    : $"Saliste de {urlSalida} (Pop). Ya no quedan páginas.";

                MostrarMensaje(aviso, esError: false);
            }
            else
            {
                MostrarMensaje("El historial está vacío: no hay página a la que regresar.", esError: true);
            }
        }

        private void btnVerCima_Click(object sender, EventArgs e)
        {
            if (historialPila.Count > 0)
            {
                string cima = historialPila.Peek();
                MostrarMensaje($"Página actual (cima): {cima}", esError: false);
            }
            else
            {
                MostrarMensaje("El historial está vacío.", esError: true);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            historialPila.Clear();
            ActualizarInterfaz();
            MostrarMensaje("Historial limpiado. La pila está vacía.", esError: false);
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            if (esError)
            {
                lblMensaje.BackColor = Color.FromArgb(253, 238, 238); // Fondo rojizo suave
                lblMensaje.ForeColor = Color.FromArgb(179, 56, 44);   // Texto rojo
            }
            else
            {
                lblMensaje.BackColor = Color.FromArgb(234, 246, 239); // Fondo verde suave[cite: 1]
                lblMensaje.ForeColor = Color.FromArgb(24, 115, 79);   // Texto verde oscuro[cite: 1]
            }
        }
    }
}
