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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }
        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=material;Uid=root");
        DataSet dts = new DataSet();

        private void button5_Click(object sender, EventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                ConexionMySql.Close();
                string consulta = "INSERT INTO Material (cod_M,Nombre,stock,estado) VALUES (?cod,?nom,?sto,?sta)";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = textBox1.Text;
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 70).Value = textBox2.Text;
                comando.Parameters.Add("?sto", MySqlDbType.VarChar, 50).Value = textBox3.Text;   
                comando.Parameters.Add("?sta", MySqlDbType.VarChar, 50).Value = comboBox1.Text;
                //comando.Parameters.Add("?sta", MySqlDbType.VarChar, 50).Value = malo.Text;
                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Guardado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConexionMySql = new MySqlConnection("Server=localhost;Database=material;Uid=root");
            }  
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=material;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql = new MySqlCommand("Select cod_M,nombre,stock,estado from material where (cod_M='" + textBox1.Text + "')", ConexionMySql);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "Update Material set Nombre=?nom,stock=?sto,estado=?sta where cod_M=?cod";
                DataGridViewRow row = this.dataGridView1.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[0].Value);
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[1].Value);
                comando.Parameters.Add("?sto", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[2].Value);
                comando.Parameters.Add("?sta", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[3].Value);
                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                DialogResult rpt = MessageBox.Show("Está seguro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpt == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.CurrentRow;
                    string consulta = "delete from Material where cod_M=?cod ";
                    MySqlCommand comando = new MySqlCommand(consulta);
                    comando.Parameters.Add("?cod", MySqlDbType.String, 20).Value = Convert.ToString(row.Cells[0].Value);
                    comando.Connection = ConexionMySql;
                    ConexionMySql.Open();
                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Borrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
             catch (SystemException)
             {
                 MessageBox.Show("Hubo errores al eliminar, intente nuevamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
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
            Validar.solonumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
