namespace Hola3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void BtnCot_Click(object sender, EventArgs e)
        {
            Cotizador ventana = new Cotizador();
            ventana.Show();
            this.Hide();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            Registro vent =new Registro();  
            vent.Show();
            this.Hide();
        }
    }
}