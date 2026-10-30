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

    public partial class ArbolesBinario : Form
    {
        private ArbolBinarioBusqueda miABB;
        public ArbolesBinario()
        {
            InitializeComponent();
        }

        private void ArbolesBinario_Load(object sender, EventArgs e)
        {
            miABB = new ArbolBinarioBusqueda();

            // Insertamos algunos valores iniciales de prueba (ej. 50, 30, 70, etc.)
            int[] valoresIniciales = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (var v in valoresIniciales)
            {
                miABB.Insertar(v);
            }
            ActualizarVistaInorden();

        }

        private void ActualizarVistaInorden()
        {
            List<int> lista = new List<int>();
            miABB.ObtenerInorden(miABB.Raiz, lista);

            // Si tienes un Label o TextBox para mostrar el recorrido Inorden, puedes asignarlo aquí.
            // Por ejemplo, si tu label se llama lblInorden:
            // lblInorden.Text = "Inorden: " + string.Join(", ", lista);
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Trim(), out int codigo))
            {
                if (miABB.Buscar(codigo) == null)
                {
                    MessageBox.Show("No se puede eliminar: el código no existe en el árbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                miABB.Eliminar(codigo);
                MessageBox.Show($"Código {codigo} eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarVistaInorden();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un número válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Asume que tu TextBox para el código numérico se llama txtCodigo
            if (int.TryParse(textBox1.Text.Trim(), out int codigo))
            {
                bool exito = miABB.Insertar(codigo);
                if (exito)
                {
                    MessageBox.Show($"Código {codigo} insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarVistaInorden();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("El código ya existe en el árbol (no se permiten duplicados).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Trim(), out int codigo))
            {
                NodoABB encontrado = miABB.Buscar(codigo);
                if (encontrado != null)
                {
                    MessageBox.Show($"¡Código {codigo} encontrado en el inventario!", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El código {codigo} no existe.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Introduce un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class NodoABB
        {
            public int Clave { get; set; }
            public NodoABB Izquierdo { get; set; }
            public NodoABB Derecho { get; set; }

            public NodoABB(int clave)
            {
                Clave = clave;
                Izquierdo = null;
                Derecho = null;
            }
        }

        public class ArbolBinarioBusqueda
        {
            public NodoABB Raiz { get; private set; }

            public bool Insertar(int clave)
            {
                if (Buscar(clave) != null) return false; // Evita duplicados
                Raiz = InsertarRecursivo(Raiz, clave);
                return true;
            }

            private NodoABB InsertarRecursivo(NodoABB nodo, int clave)
            {
                if (nodo == null) return new NodoABB(clave);

                if (clave < nodo.Clave)
                    nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, clave);
                else if (clave > nodo.Clave)
                    nodo.Derecho = InsertarRecursivo(nodo.Derecho, clave);

                return nodo;
            }

            public NodoABB Buscar(int clave)
            {
                return BuscarRecursivo(Raiz, clave);
            }

            private NodoABB BuscarRecursivo(NodoABB nodo, int clave)
            {
                if (nodo == null || nodo.Clave == clave) return nodo;

                if (clave < nodo.Clave)
                    return BuscarRecursivo(nodo.Izquierdo, clave);

                return BuscarRecursivo(nodo.Derecho, clave);
            }

            public void ObtenerInorden(NodoABB nodo, List<int> lista)
            {
                if (nodo == null) return;
                ObtenerInorden(nodo.Izquierdo, lista);
                lista.Add(nodo.Clave);
                ObtenerInorden(nodo.Derecho, lista);
            }

            public void Eliminar(int clave)
            {
                Raiz = EliminarRecursivo(Raiz, clave);
            }

            private NodoABB EliminarRecursivo(NodoABB nodo, int clave)
            {
                if (nodo == null) return null;

                if (clave < nodo.Clave)
                    nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, clave);
                else if (clave > nodo.Clave)
                    nodo.Derecho = EliminarRecursivo(nodo.Derecho, clave);
                else
                {
                    // Caso 1: Hoja o un solo hijo
                    if (nodo.Izquierdo == null) return nodo.Derecho;
                    if (nodo.Derecho == null) return nodo.Izquierdo;

                    // Caso 2: Dos hijos -> Sucesor inorden (el menor del subárbol derecho)
                    NodoABB sucesor = EncontrarMinimo(nodo.Derecho);
                    nodo.Clave = sucesor.Clave;
                    nodo.Derecho = EliminarRecursivo(nodo.Derecho, sucesor.Clave);
                }
                return nodo;
            }

            private NodoABB EncontrarMinimo(NodoABB nodo)
            {
                while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;
                return nodo;
            }
        }
    }
}
