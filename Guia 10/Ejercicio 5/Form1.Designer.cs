namespace Ejercicio_5
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
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbInsuficiente = new System.Windows.Forms.RadioButton();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbExcelentes = new System.Windows.Forms.Label();
            this.lbBuenos = new System.Windows.Forms.Label();
            this.lbInsuficiente = new System.Windows.Forms.Label();
            this.lbCantidadTotal = new System.Windows.Forms.Label();
            this.lbExcelente = new System.Windows.Forms.Label();
            this.lbBuenoss = new System.Windows.Forms.Label();
            this.lbInsuficientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Location = new System.Drawing.Point(12, 61);
            this.rbExcelente.Name = "rbExcelente";
            this.rbExcelente.Size = new System.Drawing.Size(72, 17);
            this.rbExcelente.TabIndex = 0;
            this.rbExcelente.TabStop = true;
            this.rbExcelente.Text = "Excelente";
            this.rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            this.rbBueno.AutoSize = true;
            this.rbBueno.Location = new System.Drawing.Point(12, 84);
            this.rbBueno.Name = "rbBueno";
            this.rbBueno.Size = new System.Drawing.Size(56, 17);
            this.rbBueno.TabIndex = 1;
            this.rbBueno.TabStop = true;
            this.rbBueno.Text = "Bueno";
            this.rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            this.rbInsuficiente.AutoSize = true;
            this.rbInsuficiente.Location = new System.Drawing.Point(12, 107);
            this.rbInsuficiente.Name = "rbInsuficiente";
            this.rbInsuficiente.Size = new System.Drawing.Size(79, 17);
            this.rbInsuficiente.TabIndex = 2;
            this.rbInsuficiente.TabStop = true;
            this.rbInsuficiente.Text = "Insuficiente";
            this.rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(139, 81);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de votaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Excelentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buenos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insuficientes";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(154, 172);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 8;
            // 
            // lbExcelentes
            // 
            this.lbExcelentes.AutoSize = true;
            this.lbExcelentes.Location = new System.Drawing.Point(157, 197);
            this.lbExcelentes.Name = "lbExcelentes";
            this.lbExcelentes.Size = new System.Drawing.Size(0, 13);
            this.lbExcelentes.TabIndex = 9;
            // 
            // lbBuenos
            // 
            this.lbBuenos.AutoSize = true;
            this.lbBuenos.Location = new System.Drawing.Point(157, 228);
            this.lbBuenos.Name = "lbBuenos";
            this.lbBuenos.Size = new System.Drawing.Size(0, 13);
            this.lbBuenos.TabIndex = 10;
            // 
            // lbInsuficiente
            // 
            this.lbInsuficiente.AutoSize = true;
            this.lbInsuficiente.Location = new System.Drawing.Point(157, 259);
            this.lbInsuficiente.Name = "lbInsuficiente";
            this.lbInsuficiente.Size = new System.Drawing.Size(0, 13);
            this.lbInsuficiente.TabIndex = 11;
            // 
            // lbCantidadTotal
            // 
            this.lbCantidadTotal.AutoSize = true;
            this.lbCantidadTotal.Location = new System.Drawing.Point(161, 172);
            this.lbCantidadTotal.Name = "lbCantidadTotal";
            this.lbCantidadTotal.Size = new System.Drawing.Size(35, 13);
            this.lbCantidadTotal.TabIndex = 12;
            this.lbCantidadTotal.Text = "label5";
            // 
            // lbExcelente
            // 
            this.lbExcelente.AutoSize = true;
            this.lbExcelente.Location = new System.Drawing.Point(161, 198);
            this.lbExcelente.Name = "lbExcelente";
            this.lbExcelente.Size = new System.Drawing.Size(35, 13);
            this.lbExcelente.TabIndex = 13;
            this.lbExcelente.Text = "label5";
            // 
            // lbBuenoss
            // 
            this.lbBuenoss.AutoSize = true;
            this.lbBuenoss.Location = new System.Drawing.Point(161, 228);
            this.lbBuenoss.Name = "lbBuenoss";
            this.lbBuenoss.Size = new System.Drawing.Size(35, 13);
            this.lbBuenoss.TabIndex = 14;
            this.lbBuenoss.Text = "label5";
            // 
            // lbInsuficientes
            // 
            this.lbInsuficientes.AutoSize = true;
            this.lbInsuficientes.Location = new System.Drawing.Point(161, 259);
            this.lbInsuficientes.Name = "lbInsuficientes";
            this.lbInsuficientes.Size = new System.Drawing.Size(35, 13);
            this.lbInsuficientes.TabIndex = 15;
            this.lbInsuficientes.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 352);
            this.Controls.Add(this.lbInsuficientes);
            this.Controls.Add(this.lbBuenoss);
            this.Controls.Add(this.lbExcelente);
            this.Controls.Add(this.lbCantidadTotal);
            this.Controls.Add(this.lbInsuficiente);
            this.Controls.Add(this.lbBuenos);
            this.Controls.Add(this.lbExcelentes);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.rbInsuficiente);
            this.Controls.Add(this.rbBueno);
            this.Controls.Add(this.rbExcelente);
            this.Name = "Form1";
            this.Text = "Encuesta de servicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExcelente;
        private System.Windows.Forms.RadioButton rbBueno;
        private System.Windows.Forms.RadioButton rbInsuficiente;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbExcelentes;
        private System.Windows.Forms.Label lbBuenos;
        private System.Windows.Forms.Label lbInsuficiente;
        private System.Windows.Forms.Label lbCantidadTotal;
        private System.Windows.Forms.Label lbExcelente;
        private System.Windows.Forms.Label lbBuenoss;
        private System.Windows.Forms.Label lbInsuficientes;
    }
}

