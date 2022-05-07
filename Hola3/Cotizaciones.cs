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
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private TreeNode crearArbol(DirectoryInfo directoryinfo)
        {
            TreeNode treenode = new TreeNode(directoryinfo.Name);
            foreach(var item in directoryinfo.GetDirectories())
            {
                treenode.Nodes.Add(crearArbol(item));
            }

            foreach (var item in directoryinfo.GetFiles()) {

                treenode.Nodes.Add(new TreeNode(item.Name));
            
            }
            return treenode;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void TvFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string rutaA = "C:\\Users\\J\\Desktop\\" +TvFile.SelectedNode.FullPath;

            System.Diagnostics.Process.Start(rutaA);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            string RutaB = "C:\\Users\\J\\Desktop\\Ola";
            TvFile.Nodes.Clear();
            DirectoryInfo directoryinfo = new DirectoryInfo(RutaB);

            TvFile.Nodes.Add(crearArbol(directoryinfo));
        }
    }
}
