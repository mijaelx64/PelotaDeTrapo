using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace principal.MySqlConnector
{
    class Connection
    {
        MySqlConnection Connector;
       
        public Connection()
        {
            try
            {
                Connector = new MySqlConnection("Server=localhost;Database=escuela;Uid=root;Password=Control123");
                
                IsConnected = true;
            }
            catch (Exception ex)
            {
                IsConnected = false;
                throw new Exception("Coneccion a MySQL fallo. Error: " + ex.Message); 
            }
            
        }

        #region Properties

        public bool IsConnected { get; set; }

        #endregion

        public void ConectionDispose() 
        {
            try
            {
                Connector.Close();
                IsConnected = false;
            }
            catch (Exception ex)
            {
                IsConnected = false;
                throw new Exception("Desconeccion a MySQL fallo. Error: " + ex.Message);
            }        
        }
    }
}
