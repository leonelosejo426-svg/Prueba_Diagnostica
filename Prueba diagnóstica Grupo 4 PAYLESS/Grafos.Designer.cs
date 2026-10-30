namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class Grafos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarSede = new System.Windows.Forms.Button();
            this.btnConexionesDirecta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrigeri = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnRecorrerenProfundidad = new System.Windows.Forms.Button();
            this.lblDFS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConexionesDirecta);
            this.groupBox1.Controls.Add(this.btnAgregarSede);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo vertice";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 19);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregarSede
            // 
            this.btnAgregarSede.Location = new System.Drawing.Point(7, 75);
            this.btnAgregarSede.Name = "btnAgregarSede";
            this.btnAgregarSede.Size = new System.Drawing.Size(109, 36);
            this.btnAgregarSede.TabIndex = 2;
            this.btnAgregarSede.Text = "Agregar Sede";
            this.btnAgregarSede.UseVisualStyleBackColor = true;
            // 
            // btnConexionesDirecta
            // 
            this.btnConexionesDirecta.Location = new System.Drawing.Point(122, 75);
            this.btnConexionesDirecta.Name = "btnConexionesDirecta";
            this.btnConexionesDirecta.Size = new System.Drawing.Size(151, 36);
            this.btnConexionesDirecta.TabIndex = 3;
            this.btnConexionesDirecta.Text = "Conexiones Directa";
            this.btnConexionesDirecta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConectar);
            this.groupBox2.Controls.Add(this.txtDistancia);
            this.groupBox2.Controls.Add(this.txtDestino);
            this.groupBox2.Controls.Add(this.txtOrigeri);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Conexion";
            // 
            // txtOrigeri
            // 
            this.txtOrigeri.Location = new System.Drawing.Point(6, 19);
            this.txtOrigeri.Multiline = true;
            this.txtOrigeri.Name = "txtOrigeri";
            this.txtOrigeri.Size = new System.Drawing.Size(363, 35);
            this.txtOrigeri.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(6, 75);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(363, 35);
            this.txtDestino.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(6, 133);
            this.txtDistancia.Multiline = true;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(363, 35);
            this.txtDistancia.TabIndex = 2;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(6, 187);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 36);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 147);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRecorrerenProfundidad);
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listade adyacencia";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(8, 25);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(363, 35);
            this.txtA.TabIndex = 4;
            // 
            // btnRecorrerenProfundidad
            // 
            this.btnRecorrerenProfundidad.Location = new System.Drawing.Point(8, 71);
            this.btnRecorrerenProfundidad.Name = "btnRecorrerenProfundidad";
            this.btnRecorrerenProfundidad.Size = new System.Drawing.Size(231, 36);
            this.btnRecorrerenProfundidad.TabIndex = 5;
            this.btnRecorrerenProfundidad.Text = "Recorrer en Profundidad (DFS)";
            this.btnRecorrerenProfundidad.UseVisualStyleBackColor = true;
            // 
            // lblDFS
            // 
            this.lblDFS.AutoSize = true;
            this.lblDFS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFS.Location = new System.Drawing.Point(17, 557);
            this.lblDFS.Name = "lblDFS";
            this.lblDFS.Size = new System.Drawing.Size(105, 19);
            this.lblDFS.TabIndex = 4;
            this.lblDFS.Text = "DFS desde A: ";
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 601);
            this.Controls.Add(this.lblDFS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Grafos";
            this.Text = "Grafos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConexionesDirecta;
        private System.Windows.Forms.Button btnAgregarSede;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRecorrerenProfundidad;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblDFS;
    }
}