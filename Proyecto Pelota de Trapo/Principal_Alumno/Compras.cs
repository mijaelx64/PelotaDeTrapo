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
    public partial class Compras : Form
    {
        MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
        DataSet dts = new DataSet();
        public Compras()
        {
            InitializeComponent();
            txtCod.Enabled = false;
            txtPro.Enabled = false;
            txtPre.Enabled = false;
            dtp1.Enabled = false;
            txtPTO.Enabled = false;
            txtNoM.Enabled = false;
            txtCant.Enabled = false;
            txtP.Enabled = false;
            dgmostar.Enabled = false;

            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnComprar.Enabled = false;
            btnGuardar.Enabled = false;
            btnAceptar.Enabled=false;
           
        }
        int coco=10;
        int coma=5;
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCod.Enabled = true;
            try
            {
                MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql = new MySqlCommand("Select Cod_Com,Nombre_Pro,precio,camtidad from compramaterial where (Cod_Com='" + txtCod.Text + "')", ConexionMySql);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql);

                mda.Fill(dts);
                dgmostar.DataSource = dts.Tables[0];
                ConexionMySql.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void dgmostar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtPro.Enabled = true;
            dtp1.Enabled = true;
            txtPre.Enabled = true;
            btnGuardar.Enabled = true;
            btnnuevo.Enabled = false;

            txtNoM.Enabled = true;
            txtCant.Enabled = true;
            txtP.Enabled = true;
            btnComprar.Enabled = true;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rpt = MessageBox.Show("Está seguro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpt == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dgmostar.CurrentRow;
                    string consulta = "delete from compramaterial where co_M=?cod ";
                    MySqlCommand comando = new MySqlCommand(consulta);
                    comando.Parameters.Add("?cod", MySqlDbType.String, 20).Value = Convert.ToString(row.Cells[0].Value);
                    comando.Connection = ConexionMySql;
                    ConexionMySql.Open();
                    comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    MessageBox.Show("Borrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgmostar.Rows.Clear();
                }
            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show( "Hubo errores al eliminar, intente nuevamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            float p = int.Parse(txtP.Text);
            int c= int.Parse(txtCant.Text);
            float pre = 0;
            float aux = 0;
            txtPTO.Enabled = false;
            try
            {
                string consulta = "INSERT INTO compramaterial (Nombre_Pro,Precio,Camtidad) VALUES(?nom,?pre,?can)";
                DataGridViewRow row = this.dgmostar.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
               // comando.Parameters.Add("?cod", MySqlDbType.VarChar, 30).Value = 2;
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 70).Value = txtNoM.Text;
                comando.Parameters.Add("?pre", MySqlDbType.VarChar, 50).Value = txtP.Text;
                comando.Parameters.Add("?can", MySqlDbType.VarChar, 50).Value = txtCant.Text;
                txtPTO.Text = Convert.ToString(c*p);
                aux = c * p;
                pre = pre + aux;
                txtPre.Text = Convert.ToString(pre);
                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Guardado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela!;Uid=root");
                consulta = "Select * from compramaterial where co_M=?cod";
                MySqlConnection ConexionMySql2 = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql2 = new MySqlCommand("Select * from compramaterial where (Cod_Com='" + coco + "')", ConexionMySql2);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql2);
                mda.Fill(dts);
                dgmostar.DataSource = dts.Tables[0];
                ConexionMySql.Close();

                txtNoM.Text = "";
                txtCant.Text = "";
                txtP.Text = "";

            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNoM.Text = "";
            txtP.Text = "";
            txtCant.Text = "";
            txtPTO.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgmostar.Enabled = true;
            btnAceptar.Enabled = true;
            btnBuscar.Enabled = false;
            btnnuevo.Enabled = false;
        }

        private void txtNoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
          /*  try
            {
                MySqlConnection ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                DataSet dts = new DataSet();
                MySqlCommand CommandMySql = new MySqlCommand("Select Cod_M from materiales where (Cod_M='" + txtCod.Text + "')", ConexionMySql);
                MySqlDataAdapter mda = new MySqlDataAdapter(CommandMySql);

                mda.Fill(dts);
                dgmostar.DataSource = dts.Tables[0];
                ConexionMySql.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }*/
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO compras (Fecha_Com,Proveedor) VALUES (?fe,?pro)";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Parameters.Add("?fe", MySqlDbType.Date).Value = dtp1.Text;

                comando.Parameters.Add("?pro", MySqlDbType.VarChar, 70).Value = txtPro.Text;

                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Guardado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConexionMySql = new MySqlConnection("Server=localhost;Database=escuela1;Uid=root");
                coco=coco+1;
            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGuardar.Enabled = false;

            txtPro.Enabled = false;
            dtp1.Enabled = false;
            txtPre.Enabled = false;
            btnGuardar.Enabled = false;
            btnnuevo.Enabled = true;
            btnBuscar.Enabled = false;

            txtNoM.Enabled = true;
            txtCant.Enabled = true;
            txtP.Enabled = true;

            btnComprar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "Update compramaterial set Nombre=?nom,Cantidad=?cant,precioM=?pre,precioTO=?to where cod_M=?cod";
                DataGridViewRow row = this.dgmostar.CurrentRow;
                MySqlCommand comando = new MySqlCommand(consulta, ConexionMySql);
                comando.Parameters.Add("?cod", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[0].Value);
                comando.Parameters.Add("?nom", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[1].Value);
                comando.Parameters.Add("?cant", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[2].Value);
                comando.Parameters.Add("?pre", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[3].Value);
                comando.Parameters.Add("?to", MySqlDbType.VarChar, 25).Value = Convert.ToString(row.Cells[4].Value);


                comando.Connection = ConexionMySql;
                ConexionMySql.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgmostar.Rows.Clear();


            }
            catch (SystemException error)
            {
                string er = Convert.ToString(error);
                MessageBox.Show(er, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAceptar.Enabled = false;
        }

        private void btnMa_Click(object sender, EventArgs e)
        {
            Material ini = new Material();
            ini.Show();
            this.Close();
        }

    }
}
