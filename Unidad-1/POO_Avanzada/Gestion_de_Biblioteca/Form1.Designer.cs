namespace Gestion_de_Biblioteca
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
            this.grpRegistroLibro = new System.Windows.Forms.GroupBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRegistroUsuario = new System.Windows.Forms.GroupBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.txtISBNDevolver = new System.Windows.Forms.TextBox();
            this.txtIDPrestar = new System.Windows.Forms.TextBox();
            this.txtISBNPrestar = new System.Windows.Forms.TextBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpRegistroLibro.SuspendLayout();
            this.grpRegistroUsuario.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistroLibro
            // 
            this.grpRegistroLibro.Controls.Add(this.btnAgregarLibro);
            this.grpRegistroLibro.Controls.Add(this.txtISBN);
            this.grpRegistroLibro.Controls.Add(this.txtAutor);
            this.grpRegistroLibro.Controls.Add(this.txtTitulo);
            this.grpRegistroLibro.Controls.Add(this.lblISBN);
            this.grpRegistroLibro.Controls.Add(this.label2);
            this.grpRegistroLibro.Controls.Add(this.label1);
            this.grpRegistroLibro.Location = new System.Drawing.Point(12, 12);
            this.grpRegistroLibro.Name = "grpRegistroLibro";
            this.grpRegistroLibro.Size = new System.Drawing.Size(183, 158);
            this.grpRegistroLibro.TabIndex = 0;
            this.grpRegistroLibro.TabStop = false;
            this.grpRegistroLibro.Text = "Registro de libro";
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(36, 118);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarLibro.TabIndex = 6;
            this.btnAgregarLibro.Text = "Agregar libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(57, 82);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(57, 54);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(57, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(16, 85);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // grpRegistroUsuario
            // 
            this.grpRegistroUsuario.Controls.Add(this.btnAgregarUsuario);
            this.grpRegistroUsuario.Controls.Add(this.txtIDUsuario);
            this.grpRegistroUsuario.Controls.Add(this.txtNombreUsuario);
            this.grpRegistroUsuario.Controls.Add(this.label4);
            this.grpRegistroUsuario.Controls.Add(this.label3);
            this.grpRegistroUsuario.Location = new System.Drawing.Point(211, 19);
            this.grpRegistroUsuario.Name = "grpRegistroUsuario";
            this.grpRegistroUsuario.Size = new System.Drawing.Size(204, 150);
            this.grpRegistroUsuario.TabIndex = 1;
            this.grpRegistroUsuario.TabStop = false;
            this.grpRegistroUsuario.Text = "Registro de usuario";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(37, 111);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(37, 51);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(73, 20);
            this.txtIDUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(63, 21);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(125, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.txtISBNDevolver);
            this.grpOperaciones.Controls.Add(this.txtIDPrestar);
            this.grpOperaciones.Controls.Add(this.txtISBNPrestar);
            this.grpOperaciones.Controls.Add(this.btnDevolver);
            this.grpOperaciones.Controls.Add(this.label7);
            this.grpOperaciones.Controls.Add(this.btnPrestar);
            this.grpOperaciones.Controls.Add(this.label6);
            this.grpOperaciones.Controls.Add(this.label5);
            this.grpOperaciones.Location = new System.Drawing.Point(430, 19);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(204, 162);
            this.grpOperaciones.TabIndex = 2;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Prestamos/devoluciones";
            // 
            // txtISBNDevolver
            // 
            this.txtISBNDevolver.Location = new System.Drawing.Point(103, 107);
            this.txtISBNDevolver.Name = "txtISBNDevolver";
            this.txtISBNDevolver.Size = new System.Drawing.Size(79, 20);
            this.txtISBNDevolver.TabIndex = 7;
            // 
            // txtIDPrestar
            // 
            this.txtIDPrestar.Location = new System.Drawing.Point(71, 47);
            this.txtIDPrestar.Name = "txtIDPrestar";
            this.txtIDPrestar.Size = new System.Drawing.Size(100, 20);
            this.txtIDPrestar.TabIndex = 6;
            // 
            // txtISBNPrestar
            // 
            this.txtISBNPrestar.Location = new System.Drawing.Point(48, 21);
            this.txtISBNPrestar.Name = "txtISBNPrestar";
            this.txtISBNPrestar.Size = new System.Drawing.Size(123, 20);
            this.txtISBNPrestar.TabIndex = 5;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(58, 130);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ISBN devolucion:";
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(58, 75);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(78, 23);
            this.btnPrestar.TabIndex = 2;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN:";
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(12, 186);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(164, 134);
            this.lstLibros.TabIndex = 3;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(201, 186);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(155, 134);
            this.lstUsuarios.TabIndex = 4;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(375, 186);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(171, 134);
            this.lstPrestamos.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(559, 195);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 364);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpRegistroUsuario);
            this.Controls.Add(this.grpRegistroLibro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRegistroLibro.ResumeLayout(false);
            this.grpRegistroLibro.PerformLayout();
            this.grpRegistroUsuario.ResumeLayout(false);
            this.grpRegistroUsuario.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistroLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.GroupBox grpRegistroUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBNDevolver;
        private System.Windows.Forms.TextBox txtIDPrestar;
        private System.Windows.Forms.TextBox txtISBNPrestar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label lblStatus;
    }
}

