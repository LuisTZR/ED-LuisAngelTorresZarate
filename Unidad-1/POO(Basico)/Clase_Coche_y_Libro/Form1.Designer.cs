namespace Clase_Coche_y_Libro
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
            this.tabLibroCoche = new System.Windows.Forms.TabControl();
            this.pagCoche = new System.Windows.Forms.TabPage();
            this.pagLibro = new System.Windows.Forms.TabPage();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.lblValorVelocidad = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.tabLibroCoche.SuspendLayout();
            this.pagCoche.SuspendLayout();
            this.pagLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLibroCoche
            // 
            this.tabLibroCoche.Controls.Add(this.pagCoche);
            this.tabLibroCoche.Controls.Add(this.pagLibro);
            this.tabLibroCoche.Location = new System.Drawing.Point(12, 12);
            this.tabLibroCoche.Name = "tabLibroCoche";
            this.tabLibroCoche.SelectedIndex = 0;
            this.tabLibroCoche.Size = new System.Drawing.Size(320, 250);
            this.tabLibroCoche.TabIndex = 0;
            // 
            // pagCoche
            // 
            this.pagCoche.Controls.Add(this.txtModelo);
            this.pagCoche.Controls.Add(this.txtMarca);
            this.pagCoche.Controls.Add(this.lblValorVelocidad);
            this.pagCoche.Controls.Add(this.btnFrenar);
            this.pagCoche.Controls.Add(this.btnAcelerar);
            this.pagCoche.Controls.Add(this.lblVelocidad);
            this.pagCoche.Controls.Add(this.lblModelo);
            this.pagCoche.Controls.Add(this.lblMarca);
            this.pagCoche.Location = new System.Drawing.Point(4, 22);
            this.pagCoche.Name = "pagCoche";
            this.pagCoche.Padding = new System.Windows.Forms.Padding(3);
            this.pagCoche.Size = new System.Drawing.Size(312, 224);
            this.pagCoche.TabIndex = 0;
            this.pagCoche.Text = "Coche";
            this.pagCoche.UseVisualStyleBackColor = true;
            // 
            // pagLibro
            // 
            this.pagLibro.Controls.Add(this.btnMostrarInformacion);
            this.pagLibro.Controls.Add(this.txtAutor);
            this.pagLibro.Controls.Add(this.txtTitulo);
            this.pagLibro.Controls.Add(this.lblAutor);
            this.pagLibro.Controls.Add(this.lblTitulo);
            this.pagLibro.Location = new System.Drawing.Point(4, 22);
            this.pagLibro.Name = "pagLibro";
            this.pagLibro.Padding = new System.Windows.Forms.Padding(3);
            this.pagLibro.Size = new System.Drawing.Size(312, 224);
            this.pagLibro.TabIndex = 1;
            this.pagLibro.Text = "Libro";
            this.pagLibro.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(42, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(45, 75);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(78, 160);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(57, 13);
            this.lblVelocidad.TabIndex = 2;
            this.lblVelocidad.Text = "Velocidad:";
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(15, 111);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(104, 23);
            this.btnAcelerar.TabIndex = 3;
            this.btnAcelerar.Text = "Acelerar 10 km/h";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(137, 111);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(75, 23);
            this.btnFrenar.TabIndex = 4;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // lblValorVelocidad
            // 
            this.lblValorVelocidad.AutoSize = true;
            this.lblValorVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorVelocidad.Location = new System.Drawing.Point(134, 160);
            this.lblValorVelocidad.Name = "lblValorVelocidad";
            this.lblValorVelocidad.Size = new System.Drawing.Size(18, 15);
            this.lblValorVelocidad.TabIndex = 5;
            this.lblValorVelocidad.Text = "...";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(99, 28);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(99, 67);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(29, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo del libro:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(30, 66);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(74, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor del libro:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(110, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(110, 63);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(66, 101);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(94, 40);
            this.btnMostrarInformacion.TabIndex = 4;
            this.btnMostrarInformacion.Text = "Mostrar informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 272);
            this.Controls.Add(this.tabLibroCoche);
            this.Name = "Form1";
            this.Text = "POO(Basico)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabLibroCoche.ResumeLayout(false);
            this.pagCoche.ResumeLayout(false);
            this.pagCoche.PerformLayout();
            this.pagLibro.ResumeLayout(false);
            this.pagLibro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLibroCoche;
        private System.Windows.Forms.TabPage pagCoche;
        private System.Windows.Forms.TabPage pagLibro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblValorVelocidad;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
    }
}

