namespace practica_Area_Circulo
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
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(73, 68);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(91, 23);
            this.btnCalcularArea.TabIndex = 0;
            this.btnCalcularArea.Text = "Calcular area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(40, 33);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(89, 13);
            this.lblRadio.TabIndex = 2;
            this.lblRadio.Text = "Radio del circulo:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(135, 30);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(74, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAreaCirculo.Location = new System.Drawing.Point(76, 115);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(88, 15);
            this.lblAreaCirculo.TabIndex = 4;
            this.lblAreaCirculo.Text = "(Area del circulo)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 162);
            this.Controls.Add(this.lblAreaCirculo);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.btnCalcularArea);
            this.Name = "Form1";
            this.Text = "Calcular area de un circulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblAreaCirculo;
    }
}

