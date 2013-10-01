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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            txtCod.Enabled = false;
            txtNombre.Enabled = false;
            txtAP.Enabled = false;
            txtAM.Enabled = false;
            txtCargo.Enabled = false;
            txtSalario.Enabled = false;
            dateTimePicker1.Enabled = false;
            mostrarP.Enabled = false;
            btngu.Visible = false;

            btnAceptar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;

        }
        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela;Uid=root;Password=Control123");
        DataSet dts = new DataSet();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCod.Enabled = true;
            mostrarP.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
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

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mostrarP.Enabled = true;
            btnAceptar.Enabled = true;
            btnBorrar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "Update personal set Nombre_p=?nom,AP_p=?ape,AM_p=?mate,cargo=?car,salario=?sa,fi=?fi where cod_p=?cod";
                DataGridViewRow row = this.mostrarP.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[0].Value);
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[1].Value);
                comando.Parameters.Add("?ape", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[2].Value);
                comando.Parameters.Add("?mate", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[3].Value);
                comando.Parameters.Add("?car", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[4].Value);
                comando.Parameters.Add("?sa", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[5].Value);
                comando.Parameters.Add("?fi", MySqlDbType.Date).Value = Convert.ToString(row.Cells[6].Value);

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
            mostrarP.Enabled = false;
            btnAceptar.Enabled = false;
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
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Hubo errores al eliminar, intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
            this.Visible = false;
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCod.Enabled = false;
            txtNombre.Enabled = true;
            txtAP.Enabled = true;
            txtAM.Enabled = true;
            txtCargo.Enabled = true;
            txtSalario.Enabled = true;
            dateTimePicker1.Enabled = true;
            mostrarP.Enabled = true;
            btnNuevo.Visible = false;
            btngu.Visible = true;
            btnBuscar.Enabled = false;

            txtCod.Text = "";
            txtNombre.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            mostrarP.ClearSelection();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngu_Click(object sender, EventArgs e)
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
                comando.Parameters.Add("?fi", MySqlDbType.VarChar, 25).Value = dateTimePicker1.Text;
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
            btngu.Visible = false;
            btnNuevo.Visible= true;
            btnBuscar.Enabled = true;
            
            txtCod.Enabled = false;
            txtNombre.Enabled = false;
            txtAP.Enabled = false;
            txtAM.Enabled = false;
            txtCargo.Enabled = false;
            txtSalario.Enabled = false;
            dateTimePicker1.Enabled = false;
            mostrarP.Enabled = false;

            btnAceptar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
        }
    }
}
