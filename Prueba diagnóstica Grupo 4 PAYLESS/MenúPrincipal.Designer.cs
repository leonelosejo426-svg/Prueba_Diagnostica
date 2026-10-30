namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class MenúPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPila
            // 
            this.btnPila.FlatAppearance.BorderSize = 0;
            this.btnPila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPila.Location = new System.Drawing.Point(62, 102);
            this.btnPila.Margin = new System.Windows.Forms.Padding(4);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(112, 34);
            this.btnPila.TabIndex = 0;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú Principal";
            // 
            // btnCola
            // 
            this.btnCola.FlatAppearance.BorderSize = 0;
            this.btnCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCola.Location = new System.Drawing.Point(204, 102);
            this.btnCola.Margin = new System.Windows.Forms.Padding(4);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(112, 34);
            this.btnCola.TabIndex = 2;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnListas
            // 
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Location = new System.Drawing.Point(358, 102);
            this.btnListas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(161, 34);
            this.btnListas.TabIndex = 3;
            this.btnListas.Text = "Listas Enlazadas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(62, 204);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Arboles/Recorridos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(299, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Arboles Binarios";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(113, 295);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Grafos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(315, 295);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Recursividad";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MenúPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 387);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPila);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenúPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MenúPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

