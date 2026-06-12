namespace Ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnImprmirNombre = new System.Windows.Forms.Button();
            this.tbInvitaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del invitado ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(205, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // btnImprmirNombre
            // 
            this.btnImprmirNombre.Location = new System.Drawing.Point(342, 77);
            this.btnImprmirNombre.Name = "btnImprmirNombre";
            this.btnImprmirNombre.Size = new System.Drawing.Size(75, 23);
            this.btnImprmirNombre.TabIndex = 2;
            this.btnImprmirNombre.Text = "Imprimir Nombre ";
            this.btnImprmirNombre.UseVisualStyleBackColor = true;
            this.btnImprmirNombre.Click += new System.EventHandler(this.btnImprmirNombre_Click);
            // 
            // tbInvitaciones
            // 
            this.tbInvitaciones.Location = new System.Drawing.Point(79, 125);
            this.tbInvitaciones.Multiline = true;
            this.tbInvitaciones.Name = "tbInvitaciones";
            this.tbInvitaciones.Size = new System.Drawing.Size(338, 81);
            this.tbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_2.Properties.Resources.WhatsApp_Image_2026_06_11_at_21_04_37;
            this.ClientSize = new System.Drawing.Size(541, 653);
            this.Controls.Add(this.tbInvitaciones);
            this.Controls.Add(this.btnImprmirNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnImprmirNombre;
        private System.Windows.Forms.TextBox tbInvitaciones;
    }
}

