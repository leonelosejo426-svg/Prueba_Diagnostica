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

    public partial class ArbolesYRecorridos : Form
    {
        private GestorArbol miArbol;
        public ArbolesYRecorridos()
        {
            InitializeComponent();
        }

        private void ArbolesYRecorridos_Load(object sender, EventArgs e)
        {
            // Inicializamos el árbol con la raíz por defecto
            miArbol = new GestorArbol();
            miArbol.Raiz = new NodoArbol("Dir.");

            lblResultado.Text = "Resultado: Árbol inicializado con la raíz 'Dir.'.";

        }

        private void btnAgregarIzquierdo_Click(object sender, EventArgs e)
        {
            AgregarNodoAlArbol('l');
        }

        private void btnAgregarDerecho_Click(object sender, EventArgs e)
        {
            AgregarNodoAlArbol('r');
        }

        private void AgregarNodoAlArbol(char lado)
        {
            string nuevoValor = textBox1.Text.Trim();
            string nombrePadre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(nuevoValor) || string.IsNullOrEmpty(nombrePadre))
            {
                MessageBox.Show("Por favor, completa ambos campos:\n- textBox1: Nuevo cargo\n- textBox2: Nodo padre", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NodoArbol padre = miArbol.BuscarNodo(miArbol.Raiz, nombrePadre);
            if (padre == null)
            {
                MessageBox.Show($"No se encontró el nodo padre '{nombrePadre}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lado == 'l')
            {
                if (padre.Izquierdo != null)
                {
                    MessageBox.Show($"El nodo '{padre.Valor}' ya tiene hijo izquierdo.", "Posición ocupada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                padre.Izquierdo = new NodoArbol(nuevoValor);
            }
            else
            {
                if (padre.Derecho != null)
                {
                    MessageBox.Show($"El nodo '{padre.Valor}' ya tiene hijo derecho.", "Posición ocupada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                padre.Derecho = new NodoArbol(nuevoValor);
            }

            MessageBox.Show($"¡Cargo '{nuevoValor}' agregado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            miArbol.Preorden(miArbol.Raiz, resultado);
            lblResultado.Text = "Resultado (Preorden): " + string.Join(" · ", resultado);
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            miArbol.Inorden(miArbol.Raiz, resultado);
            lblResultado.Text = "Resultado (Inorden): " + string.Join(" · ", resultado);
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            miArbol.Postorden(miArbol.Raiz, resultado);
            lblResultado.Text = "Resultado (Postorden): " + string.Join(" · ", resultado);
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            // Evento de la etiqueta (puede dejarse vacío o sin lógica de botones)
        }
    
    }
    public class NodoArbol
    {
        public string Valor { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        public NodoArbol(string valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }

    public class GestorArbol
    {
        public NodoArbol Raiz { get; set; }

        public void Preorden(NodoArbol nodo, List<string> resultado)
        {
            if (nodo == null) return;
            resultado.Add(nodo.Valor);
            Preorden(nodo.Izquierdo, resultado);
            Preorden(nodo.Derecho, resultado);
        }

        public void Inorden(NodoArbol nodo, List<string> resultado)
        {
            if (nodo == null) return;
            Inorden(nodo.Izquierdo, resultado);
            resultado.Add(nodo.Valor);
            Inorden(nodo.Derecho, resultado);
        }

        public void Postorden(NodoArbol nodo, List<string> resultado)
        {
            if (nodo == null) return;
            Postorden(nodo.Izquierdo, resultado);
            Postorden(nodo.Derecho, resultado);
            resultado.Add(nodo.Valor);
        }

        public NodoArbol BuscarNodo(NodoArbol actual, string valorBuscado)
        {
            if (actual == null) return null;
            if (actual.Valor.Equals(valorBuscado, StringComparison.OrdinalIgnoreCase)) return actual;

            NodoArbol encontrado = BuscarNodo(actual.Izquierdo, valorBuscado);
            if (encontrado != null) return encontrado;

            return BuscarNodo(actual.Derecho, valorBuscado);
        }
    }
}
