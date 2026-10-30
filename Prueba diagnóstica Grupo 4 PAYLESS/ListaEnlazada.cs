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

namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    public partial class ListaEnlazada : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private NodoTarea head = null;
        private int contadorId = 1;
        private int totalTareas = 0;

        // Clase propia para representar cada Nodo de la lista enlazada
        public class NodoTarea
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public string Prioridad { get; set; }
            public NodoTarea Next { get; set; } 

            public NodoTarea(int id, string descripcion, string prioridad)
            {
                Id = id;
                Descripcion = descripcion;
                Prioridad = prioridad;
                Next = null;
            }
        }
        public ListaEnlazada()
        {
            InitializeComponent();
            InicializarDatosEjemplo();
            ActualizarInterfaz();

            SendMessage(txtDescripcion.Handle, EM_SETCUEBANNER, 0, "Descripcion de la tarea");
            SendMessage(cmbPrioridad.Handle, EM_SETCUEBANNER, 0, "Prioridad de la tarea");
            SendMessage(txtIdBusqueda.Handle, EM_SETCUEBANNER, 0, "ID de la tarea a buscar");
        }

        // Carga opcional de datos idénticos al diseño de referencia
        private void InicializarDatosEjemplo()
        {
            AgregarAlFinalInternal("Estudiar", "Media");
            AgregarAlFinalInternal("Practicar", "Media");
            AgregarAlFinalInternal("Entregar", "Alta");
        }

        // Método auxiliar privado para insertar sin limpiar campos
        private void AgregarAlFinalInternal(string desc, string prio)
        {
            NodoTarea nuevo = new NodoTarea(contadorId++, desc, prio);
            totalTareas++;

            if (head == null)
            {
                head = nuevo;
            }
            else
            {
                NodoTarea temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = nuevo;
            }
        }

        // Método central para recorrer la lista y refrescar la pantalla
        private void ActualizarInterfaz()
        {
            lstNodos.Items.Clear();

            if (head == null)
            {
                lstNodos.Items.Add("head -> NULL");
            }
            else
            {
                // Recorrido de los nodos desde Head hasta NULL
                NodoTarea actual = head;
                while (actual != null)
                {
                    string idFormateado = actual.Id.ToString("D2");
                    lstNodos.Items.Add($"ID {idFormateado} · {actual.Descripcion} [{actual.Prioridad}]  -->");
                    actual = actual.Next;
                }
                lstNodos.Items.Add("NULL");
            }

            lblTotal.Text = $"Total: {totalTareas} " + (totalTareas == 1 ? "tarea" : "tareas");
        }

        private void ListaEnlazada_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            string desc = txtDescripcion.Text.Trim();
            string prio = string.IsNullOrEmpty(cmbPrioridad.Text) ? "Media" : cmbPrioridad.Text;

            if (string.IsNullOrEmpty(desc))
            {
                MostrarMensaje("Escribe la descripción de la tarea.", esError: true);
                return;
            }

            // Enlace manual: el nuevo nodo apunta a la cabeza antigua y pasa a ser la nueva cabeza
            NodoTarea nuevo = new NodoTarea(contadorId++, desc, prio);
            nuevo.Next = head;
            head = nuevo;
            totalTareas++;

            txtDescripcion.Clear();
            ActualizarInterfaz();
            MostrarMensaje($"Tarea {nuevo.Id} agregada al inicio.", esError: false);
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            string desc = txtDescripcion.Text.Trim();
            string prio = string.IsNullOrEmpty(cmbPrioridad.Text) ? "Media" : cmbPrioridad.Text;

            if (string.IsNullOrEmpty(desc))
            {
                MostrarMensaje("Escribe la descripción de la tarea.", esError: true);
                return;
            }

            AgregarAlFinalInternal(desc, prio);

            txtDescripcion.Clear();
            ActualizarInterfaz();
            MostrarMensaje($"Tarea {contadorId - 1} agregada al final.", esError: false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdBusqueda.Text.Trim(), out int idBuscado))
            {
                MostrarMensaje("Escribe un ID numérico válido.", esError: true);
                return;
            }

            NodoTarea actual = head;
            int posicion = 1;

            while (actual != null)
            {
                if (actual.Id == idBuscado)
                {
                    MostrarMensaje($"Tarea {actual.Id}: \"{actual.Descripcion}\" · prioridad {actual.Prioridad} · posición {posicion} de {totalTareas}.", esError: false);
                    return;
                }
                actual = actual.Next;
                posicion++;
            }

            MostrarMensaje($"No existe la tarea con ID {idBuscado}.", esError: true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdBusqueda.Text.Trim(), out int idEliminar))
            {
                MostrarMensaje("Escribe un ID numérico válido.", esError: true);
                return;
            }

            if (head == null)
            {
                MostrarMensaje("La lista está vacía.", esError: true);
                return;
            }

            // Caso 1: El nodo a eliminar es la cabeza (Head)
            if (head.Id == idEliminar)
            {
                head = head.Next; // Reconexión de cabeza
                totalTareas--;
                txtIdBusqueda.Clear();
                ActualizarInterfaz();
                MostrarMensaje($"Tarea {idEliminar} eliminada.", esError: false);
                return;
            }

            // Caso 2: El nodo a eliminar está en medio o al final
            NodoTarea previo = head;
            while (previo.Next != null && previo.Next.Id != idEliminar)
            {
                previo = previo.Next;
            }

            if (previo.Next != null)
            {
                // Reconexión omitiendo el nodo eliminado
                previo.Next = previo.Next.Next;
                totalTareas--;
                txtIdBusqueda.Clear();
                ActualizarInterfaz();
                MostrarMensaje($"Tarea {idEliminar} eliminada.", esError: false);
            }
            else
            {
                MostrarMensaje($"No existe la tarea con ID {idEliminar}.", esError: true);
            }
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
