using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola3
{
    public partial class Cotizador : Form
    {
        public Cotizador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana= new Form1();
            ventana.Show();
            this.Hide();    
        }
    }
}
