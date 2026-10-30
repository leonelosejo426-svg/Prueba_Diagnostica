using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    public partial class Colas : Form
    {

        // Declaración de la Cola nativa de C#
        private Queue<Cliente> colaEspera = new Queue<Cliente>();

        // Controladores del turno actual en ventanilla
        private int contadorTurnos = 25;
        private string turnoActualCodigo = "T-024";
        private string turnoActualNombre = "María López";

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public Colas()
        {
            InitializeComponent();
            InicializarDatosEjemplo();
            ActualizarInterfaz();


            SendMessage(txtNombre.Handle, EM_SETCUEBANNER, 0, "Nombre del Cliente");
            SendMessage(txtMotivo.Handle, EM_SETCUEBANNER, 0, "Motivo de Consulta");
        }

        public class Cliente
        {
            public string Turno { get; set; }
            public string Nombre { get; set; }
            public string Motivo { get; set; }
        }

        private void Colas_Load(object sender, EventArgs e)
        {

        }

        private void InicializarDatosEjemplo()
        {
            colaEspera.Enqueue(new Cliente { Turno = "T-025", Nombre = "José", Motivo = "Consulta general" });
            colaEspera.Enqueue(new Cliente { Turno = "T-026", Nombre = "Ana", Motivo = "Control médico" });
            colaEspera.Enqueue(new Cliente { Turno = "T-027", Nombre = "Luis", Motivo = "Examen de laboratorio" });
            colaEspera.Enqueue(new Cliente { Turno = "T-028", Nombre = "Rosa", Motivo = "Receta médica" });
        }

        // Método central para actualizar la interfaz visualmente
        private void ActualizarInterfaz()
        {
            // 1. Mostrar turno activo en atención
            lblTurnoActual.Text = turnoActualCodigo;
            lblClienteActual.Text = turnoActualNombre;

            // 2. Refrescar la lista de espera (ListBox)
            lstColaEspera.Items.Clear();
            if (colaEspera.Count > 0)
            {
                foreach (var cliente in colaEspera)
                {
                    lstColaEspera.Items.Add($"{cliente.Turno} — {cliente.Nombre} ({cliente.Motivo})");
                }
            }
            else
            {
                lstColaEspera.Items.Add("(No hay personas en espera)");
            }

            // 3. Actualizar etiquetas de resumen (Etiquetas inferiores)
            lblTotalEspera.Text = $"En espera: {colaEspera.Count}";
            lblProximo.Text = $"Siguiente: {(colaEspera.Count > 0 ? colaEspera.Peek().Turno : "—")}";
        }

        private void btnTomarTurno_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string motivo = txtMotivo.Text.Trim();

            // Validaciones obligatorias de campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(motivo))
            {
                MostrarMensaje("Completa el nombre y el motivo para tomar turno.", esError: true);
                return;
            }

            // Generar código de turno correlativo (ej. T-029, T-030...)
            string nuevoTurno = "T-" + contadorTurnos.ToString("D3");
            contadorTurnos++;

            // Crear instancia y agregar a la cola (Enqueue)
            Cliente nuevoCliente = new Cliente
            {
                Turno = nuevoTurno,
                Nombre = nombre,
                Motivo = motivo
            };

            colaEspera.Enqueue(nuevoCliente);

            // Limpiar inputs
            txtNombre.Clear();
            txtMotivo.Clear();

            ActualizarInterfaz();
            MostrarMensaje($"{nombre} recibió el turno {nuevoTurno} (Enqueue).", esError: false);
        }

        private void btnLlamarSiguiente_Click(object sender, EventArgs e)
        {
            // Validación clave: Impedir llamada si la cola está vacía
            if (colaEspera.Count > 0)
            {
                // Dequeue extrae al primer elemento de la fila (el frente)
                Cliente clienteAtendido = colaEspera.Dequeue();

                turnoActualCodigo = clienteAtendido.Turno;
                turnoActualNombre = clienteAtendido.Nombre;

                ActualizarInterfaz();
                MostrarMensaje($"Atendiendo {clienteAtendido.Turno} · {clienteAtendido.Nombre} ({clienteAtendido.Motivo}) (Dequeue).", esError: false);
            }
            else
            {
                MostrarMensaje("No hay clientes en espera: la cola está vacía.", esError: true);
            }
        }

        private void btnVerSiguiente_Click(object sender, EventArgs e)
        {
            if (colaEspera.Count > 0)
            {
                Cliente siguiente = colaEspera.Peek();
                MostrarMensaje($"Siguiente en la fila: {siguiente.Turno} · {siguiente.Nombre} ({siguiente.Motivo}). Esperan {colaEspera.Count} personas.", esError: false);
            }
            else
            {
                MostrarMensaje("La cola está vacía.", esError: true);
            }
        }

        // Método auxiliar para el cuadro de mensajes inferior (Verde éxito / Rojo error)
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
