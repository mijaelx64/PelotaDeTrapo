using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace principal
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela;Uid=root;Password=Control123");
        DataSet dts = new DataSet();

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frprinci inicio = new frprinci();
            this.Visible = false;
            inicio.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConexionMySql.Close();
                string consulta = "INSERT INTO alumnos (cod_A,Nombre_A,AP_A,AM_A,EDAD,ESTATURA,PESO,TELEFONO,DIRECCION) VALUES (?cod,?nom,?ape,?mate,?ed,?esta,?pe,?tel,?dir)";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = textBox1.Text;
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 70).Value = textBox2.Text;
                comando.Parameters.Add("?ape", MySqlDbType.VarChar, 50).Value = textBox3.Text;
                comando.Parameters.Add("?mate", MySqlDbType.VarChar, 50).Value = textBox4.Text;
                comando.Parameters.Add("?ed", MySqlDbType.VarChar, 25).Value = textBox5.Text;
                comando.Parameters.Add("?esta", MySqlDbType.VarChar, 25).Value = textBox6.Text;
                comando.Parameters.Add("?pe", MySqlDbType.VarChar, 25).Value = textBox7.Text;
                comando.Parameters.Add("?tel", MySqlDbType.VarChar, 25).Value = textBox8.Text;
                comando.Parameters.Add("?dir", MySqlDbType.VarChar, 25).Value = textBox9.Text;
                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Guardado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

    }
}

