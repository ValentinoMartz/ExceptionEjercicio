namespace WindowsExeption
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
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.btnEspacio = new System.Windows.Forms.Button();
            this.btnCaracteres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(131, 38);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(149, 77);
            this.btnCrearMedico.TabIndex = 0;
            this.btnCrearMedico.Text = "Crear Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // btnEspacio
            // 
            this.btnEspacio.Location = new System.Drawing.Point(131, 170);
            this.btnEspacio.Name = "btnEspacio";
            this.btnEspacio.Size = new System.Drawing.Size(149, 77);
            this.btnEspacio.TabIndex = 1;
            this.btnEspacio.Text = "Crear Medico con espacios";
            this.btnEspacio.UseVisualStyleBackColor = true;
            this.btnEspacio.Click += new System.EventHandler(this.btnEspacio_Click);
            // 
            // btnCaracteres
            // 
            this.btnCaracteres.Location = new System.Drawing.Point(131, 307);
            this.btnCaracteres.Name = "btnCaracteres";
            this.btnCaracteres.Size = new System.Drawing.Size(149, 77);
            this.btnCaracteres.TabIndex = 2;
            this.btnCaracteres.Text = "Crear Medico +50 caracteres";
            this.btnCaracteres.UseVisualStyleBackColor = true;
            this.btnCaracteres.Click += new System.EventHandler(this.btnCaracteres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btnCaracteres);
            this.Controls.Add(this.btnEspacio);
            this.Controls.Add(this.btnCrearMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.Button btnEspacio;
        private System.Windows.Forms.Button btnCaracteres;
    }
}

