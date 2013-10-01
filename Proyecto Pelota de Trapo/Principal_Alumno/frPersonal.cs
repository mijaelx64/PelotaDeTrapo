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
    public partial class Empleados : Form
    {
       
      
        public Empleados()
        {
            
            InitializeComponent();
        }


        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
        DataSet dts = new DataSet();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql = new MySqlCommand("Select cod_p,nombre_p,ap_p,am_p,cargo,salario,fi from personal where (cod_p='" + txtCod.Text + "')", ConexionMySql);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql);
                
                mda.Fill(dts);
                mostrarP.DataSource = dts.Tables[0];
                ConexionMySql.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO personal (cod_p,Nombre_p,AP_p,AM_p,cargo,salario,fi) VALUES (?cod,?nom,?ape,?mate,?car,?sal,?fi)";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = txtCod.Text;
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 70).Value = txtNombre.Text;
                comando.Parameters.Add("?ape", MySqlDbType.VarChar, 50).Value = txtAP.Text;
                comando.Parameters.Add("?mate", MySqlDbType.VarChar, 50).Value = txtAM.Text;
                comando.Parameters.Add("?car", MySqlDbType.VarChar, 25).Value = txtCargo.Text;
                comando.Parameters.Add("?sal", MySqlDbType.VarChar, 25).Value = txtSalario.Text;
                comando.Parameters.Add("?fi", MySqlDbType.VarChar, 25).Value = txtFI.Text;
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                string consulta = "Update personal set Nombre_p=?nom,AP_p=?ape,AM_p=?mate,cargo=?ede,salario=?esta,fi=?pe where cod_p=?cod";
                DataGridViewRow row = this.mostrarP.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[0].Value);
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[1].Value);
                comando.Parameters.Add("?ape", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[2].Value);
                comando.Parameters.Add("?mate", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[3].Value);
                comando.Parameters.Add("?ede", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[4].Value);
                comando.Parameters.Add("?esta", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[5].Value);
                comando.Parameters.Add("?pe", MySqlDbType.Date).Value = Convert.ToString(row.Cells[6].Value);
                
                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarP.Rows.Clear();


            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
         
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult rpt = MessageBox.Show("Está seguro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpt == DialogResult.Yes)
                {
                    DataGridViewRow row = this.mostrarP.CurrentRow;
                    string consulta = "delete from personal where cod_p=?cod ";
                    MySqlCommand comando = new MySqlCommand(consulta);
                    comando.Parameters.Add("?cod", MySqlDbType.String, 20).Value = Convert.ToString(row.Cells[0].Value);
                    comando.Connection = ConexionMySql;
                    ConexionMySql.Open();
                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Borrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarP.Rows.Clear();
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Hubo errores al eliminar, intente nuevamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void mostrarP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoPaterno_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

    }
}
