using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTorresBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas Cambio = new Consultas();
            Cambio.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro Regis = new FrmRegistro();
           Regis.ShowDialog();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametros Par =new FrmParametros();
            Par.ShowDialog();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void llblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=b8PxzPxI8Os");
            this.Close();
        }
    }
}
