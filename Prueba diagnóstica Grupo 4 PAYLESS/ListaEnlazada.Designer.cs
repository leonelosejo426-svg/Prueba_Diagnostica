namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class ListaEnlazada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstNodos = new System.Windows.Forms.ListBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(49, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 26);
            this.txtDescripcion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nueva tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mis Tareas";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInicio.Location = new System.Drawing.Point(49, 156);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(128, 31);
            this.btnAgregarInicio.TabIndex = 8;
            this.btnAgregarInicio.Text = "Agregar al inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.FlatAppearance.BorderSize = 0;
            this.btnAgregarFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFinal.Location = new System.Drawing.Point(183, 156);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(128, 31);
            this.btnAgregarFinal.TabIndex = 13;
            this.btnAgregarFinal.Text = "Agregar al final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(565, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 31);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdBusqueda
            // 
            this.txtIdBusqueda.Location = new System.Drawing.Point(431, 81);
            this.txtIdBusqueda.Name = "txtIdBusqueda";
            this.txtIdBusqueda.Size = new System.Drawing.Size(252, 26);
            this.txtIdBusqueda.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buscar / Eliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(431, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 31);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstNodos
            // 
            this.lstNodos.FormattingEnabled = true;
            this.lstNodos.ItemHeight = 19;
            this.lstNodos.Location = new System.Drawing.Point(49, 213);
            this.lstNodos.Name = "lstNodos";
            this.lstNodos.Size = new System.Drawing.Size(353, 175);
            this.lstNodos.TabIndex = 19;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(45, 412);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 19);
            this.lblMensaje.TabIndex = 20;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(427, 168);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 19);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Location = new System.Drawing.Point(49, 122);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(252, 26);
            this.cmbPrioridad.TabIndex = 23;
            // 
            // ListaEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lstNodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarInicio);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaEnlazada";
            this.Text = "ListaEnlazada GESTOR DE TAREAS";
            this.Load += new System.EventHandler(this.ListaEnlazada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstNodos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox cmbPrioridad;
    }
}