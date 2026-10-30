namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class ArbolesYRecorridos
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
            this.btnAgregarDerecho = new System.Windows.Forms.Button();
            this.btnAgregarIzquierdo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarDerecho);
            this.groupBox1.Controls.Add(this.btnAgregarIzquierdo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(539, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Nodo";
            // 
            // btnAgregarDerecho
            // 
            this.btnAgregarDerecho.Location = new System.Drawing.Point(309, 166);
            this.btnAgregarDerecho.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDerecho.Name = "btnAgregarDerecho";
            this.btnAgregarDerecho.Size = new System.Drawing.Size(170, 42);
            this.btnAgregarDerecho.TabIndex = 3;
            this.btnAgregarDerecho.Text = "Agregar Derecho";
            this.btnAgregarDerecho.UseVisualStyleBackColor = true;
            this.btnAgregarDerecho.Click += new System.EventHandler(this.btnAgregarDerecho_Click);
            // 
            // btnAgregarIzquierdo
            // 
            this.btnAgregarIzquierdo.Location = new System.Drawing.Point(55, 157);
            this.btnAgregarIzquierdo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarIzquierdo.Name = "btnAgregarIzquierdo";
            this.btnAgregarIzquierdo.Size = new System.Drawing.Size(182, 51);
            this.btnAgregarIzquierdo.TabIndex = 2;
            this.btnAgregarIzquierdo.Text = "Agregar Izquierdo";
            this.btnAgregarIzquierdo.UseVisualStyleBackColor = true;
            this.btnAgregarIzquierdo.Click += new System.EventHandler(this.btnAgregarIzquierdo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 36);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 36);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(580, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 212);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.btnPostorden);
            this.groupBox2.Controls.Add(this.btnInorden);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(18, 253);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(539, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejecutar Recorrido";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(29, 141);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 22);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnPostorden
            // 
            this.btnPostorden.Location = new System.Drawing.Point(353, 44);
            this.btnPostorden.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(126, 47);
            this.btnPostorden.TabIndex = 2;
            this.btnPostorden.Text = "Postorden";
            this.btnPostorden.UseVisualStyleBackColor = true;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);
            // 
            // btnInorden
            // 
            this.btnInorden.Location = new System.Drawing.Point(187, 45);
            this.btnInorden.Margin = new System.Windows.Forms.Padding(4);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(125, 45);
            this.btnInorden.TabIndex = 1;
            this.btnInorden.Text = "Inorden";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preorden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar Izquierdo";
            this.button2.UseVisualStyleBackColor = true;
           
            // 
            // ArbolesYRecorridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArbolesYRecorridos";
            this.Text = "ArbolesYRecorridos";
            this.Load += new System.EventHandler(this.ArbolesYRecorridos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarIzquierdo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarDerecho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}