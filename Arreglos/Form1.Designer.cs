
namespace Arreglos
{
    partial class Form1
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
            this.Cargar = new System.Windows.Forms.Button();
            this.Promedio1 = new System.Windows.Forms.Button();
            this.listBoxPromedio1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1prom2 = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2mayornota = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Button();
            this.button2promGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(12, 11);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(62, 21);
            this.Cargar.TabIndex = 2;
            this.Cargar.Text = "Cargar ";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Promedio1
            // 
            this.Promedio1.Location = new System.Drawing.Point(12, 38);
            this.Promedio1.Name = "Promedio1";
            this.Promedio1.Size = new System.Drawing.Size(61, 38);
            this.Promedio1.TabIndex = 5;
            this.Promedio1.Text = "Prom Parcial 1";
            this.Promedio1.UseVisualStyleBackColor = true;
            this.Promedio1.Click += new System.EventHandler(this.Promedio1_Click);
            // 
            // listBoxPromedio1
            // 
            this.listBoxPromedio1.FormattingEnabled = true;
            this.listBoxPromedio1.Location = new System.Drawing.Point(502, 21);
            this.listBoxPromedio1.Name = "listBoxPromedio1";
            this.listBoxPromedio1.Size = new System.Drawing.Size(358, 212);
            this.listBoxPromedio1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(313, 230);
            this.textBox1.TabIndex = 7;
            // 
            // button1prom2
            // 
            this.button1prom2.Location = new System.Drawing.Point(12, 82);
            this.button1prom2.Name = "button1prom2";
            this.button1prom2.Size = new System.Drawing.Size(61, 34);
            this.button1prom2.TabIndex = 8;
            this.button1prom2.Text = "prom Parcial2";
            this.button1prom2.UseVisualStyleBackColor = true;
            this.button1prom2.Click += new System.EventHandler(this.button1prom2_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(80, 9);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(66, 23);
            this.Limpiar.TabIndex = 9;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Prom Parcial3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2mayornota
            // 
            this.button2mayornota.Location = new System.Drawing.Point(12, 210);
            this.button2mayornota.Name = "button2mayornota";
            this.button2mayornota.Size = new System.Drawing.Size(75, 23);
            this.button2mayornota.TabIndex = 11;
            this.button2mayornota.Text = "Mayor Nota";
            this.button2mayornota.UseVisualStyleBackColor = true;
            this.button2mayornota.Click += new System.EventHandler(this.button2mayornota_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(80, 38);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(66, 23);
            this.nombre.TabIndex = 12;
            this.nombre.Text = "Nombre";
            this.nombre.UseVisualStyleBackColor = true;
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // button2promGeneral
            // 
            this.button2promGeneral.Location = new System.Drawing.Point(12, 165);
            this.button2promGeneral.Name = "button2promGeneral";
            this.button2promGeneral.Size = new System.Drawing.Size(62, 36);
            this.button2promGeneral.TabIndex = 13;
            this.button2promGeneral.Text = "Prom General";
            this.button2promGeneral.UseVisualStyleBackColor = true;
            this.button2promGeneral.Click += new System.EventHandler(this.button2promGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.button2promGeneral);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.button2mayornota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.button1prom2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxPromedio1);
            this.Controls.Add(this.Promedio1);
            this.Controls.Add(this.Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Promedio1;
        private System.Windows.Forms.ListBox listBoxPromedio1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1prom2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2mayornota;
        private System.Windows.Forms.Button nombre;
        private System.Windows.Forms.Button button2promGeneral;
    }
}

