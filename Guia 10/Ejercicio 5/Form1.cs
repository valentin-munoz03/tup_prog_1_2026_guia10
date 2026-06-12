using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        int Ce = 0, Cb = 0, Ci = 0, CTotales = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                Ce++;
            }
            if (rbBueno.Checked)
            {
                Cb++;
            }
            if (rbInsuficiente.Checked)
            {
                Ci++;
            }
            CTotales = Ce + Cb + Ci;

            lbCantidadTotal.Text = CTotales.ToString();
            lbExcelente.Text = Ce.ToString();
            lbBuenoss.Text = Cb.ToString();
            lbInsuficientes.Text = Ci.ToString();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
