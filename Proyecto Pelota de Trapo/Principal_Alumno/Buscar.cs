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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }
        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela;Uid=root;Password=Control123");
        DataSet dts = new DataSet();
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            
            try
            {
                ConexionMySql.Open();
                MySqlCommand CommandMySql = new MySqlCommand("SELECT * FROM alumnos where ( cod_A='" + textBox1.Text + "' )", ConexionMySql);
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

        private void button2_Click_2(object sender, EventArgs e)
        {

            try
            {
                string consulta = "Update alumnos set Nombre_A=?nom,AP_A=?ape,AM_A=?mate,EDAD=?ede,ESTATURA=?esta,PESO=?pe,TELEFONO=?tel,DIRECCION=?dir where cod_A=?cod";
                DataGridViewRow row = this.dataGridView1.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[0].Value);
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[2].Value);
                comando.Parameters.Add("?ape", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[3].Value);
                comando.Parameters.Add("?mate", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[4].Value);
                comando.Parameters.Add("?ede", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[5].Value);
                comando.Parameters.Add("?esta", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[6].Value);
                comando.Parameters.Add("?pe", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[7].Value);
                comando.Parameters.Add("?tel", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[8].Value);
                comando.Parameters.Add("?dir", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[9].Value);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rpt = MessageBox.Show("Está seguro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpt == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.CurrentRow;
                    string consulta = "delete from alumnos where cod_A=?cod ";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
