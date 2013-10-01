using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Categorias
{
    public partial class Categorias : Form
    {

        public Categorias()
        {
            InitializeComponent();
        }
        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
        DataSet dts = new DataSet();

        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionMySql.Open();
                MySqlCommand CommandMySql = new MySqlCommand("SELECT * FROM categorias", ConexionMySql);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql);
                dts = new DataSet();
                mda.Fill(dts);
                dataGridView1.DataSource = dts.Tables[0];
                ConexionMySql.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionMySql.Open();
                MySqlCommand CommandMySql = new MySqlCommand("INSERT INTO categorias VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", ConexionMySql);
                CommandMySql.ExecuteNonQuery();
                MessageBox.Show("Insertado con exito");
                ConexionMySql.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.." + error.Message);
                ConexionMySql.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionMySql.Open();
                MySqlCommand CommandMySql = new MySqlCommand("UPDATE categorias SET categorias='" + textBox1.Text + "',cod_C='" + textBox3.Text + "'WHERE cod_c =" + textBox1.Text + "", ConexionMySql);
                CommandMySql.ExecuteNonQuery();
                MessageBox.Show("Actualizacion correcta");
                ConexionMySql.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.." + error.Message);
                ConexionMySql.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionMySql.Open();
                MySqlCommand CommandMySql = new MySqlCommand("DELETE FROM categorias WHERE cod_c ='" + textBox1.Text + "'", ConexionMySql);
                CommandMySql.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado su registro");
                ConexionMySql.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error.." + error.Message);
                ConexionMySql.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql = new MySqlCommand("Select cod_c,nombre_c,edad_mini,edad_max from categorias where (cod_c='" + textBox1.Text + "')", ConexionMySql);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql);

                mda.Fill(dts);
                dataGridView1.DataSource = dts.Tables[0];
                ConexionMySql.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

    }
}