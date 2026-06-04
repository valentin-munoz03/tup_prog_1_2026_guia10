namespace Clase_10
{
    partial class lbNumero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGenerar = new Button();
            lbNumeroGenerado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 207);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del invitado";
            label1.Click += label1_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(494, 203);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += button1_Click;
            // 
            // lbNumeroGenerado
            // 
            lbNumeroGenerado.Location = new Point(264, 207);
            lbNumeroGenerado.Name = "lbNumeroGenerado";
            lbNumeroGenerado.Size = new Size(176, 23);
            lbNumeroGenerado.TabIndex = 3;
            lbNumeroGenerado.Click += label2_Click;
            // 
            // lbNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNumeroGenerado);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Name = "lbNumero";
            Text = "Generar numero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private Label lbNumeroGenerado;
    }
}
