using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace principal
{
    public partial class frprinci : Form
    {
        public frprinci()
        {
            InitializeComponent();
        }

        private void frprinci_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo nuevo = new Nuevo();
            nuevo.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
            this.Visible = false;
        }
       
    }
}

