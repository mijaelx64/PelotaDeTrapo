using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using principal.Inscripcion;

namespace principal
{
    
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frprinci pri = new frprinci();
            pri.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personal perso = new Personal();
            perso.Show();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Material mate = new Material();
            mate.Show();
            this.Visible = true;
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            Compras mate = new Compras();
            mate.Show();
            this.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frprinci pri = new frprinci();
            pri.Show();
            this.Visible = false;
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.Show();
            this.Visible = true;
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal perso = new Personal();
            perso.Show();
            this.Visible = true;
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material mate = new Material();
            mate.Show();
            this.Visible = true;
        }

        private void compraDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras mate = new Compras();
            mate.Show();
            this.Visible = false;
        }

        private void inscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Add(new MainInscripcion());
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
