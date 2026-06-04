namespace Clase_10
{
    public partial class lbNumero : Form
    {
        Servicio servicio = new Servicio();
        public lbNumero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNumeroGenerado.Text = servicio.GenerarNumero().ToString(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
 