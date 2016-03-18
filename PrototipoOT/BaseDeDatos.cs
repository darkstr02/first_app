using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PrototipoOT.Properties;
using System.Windows.Forms;

namespace PrototipoOT
{
    public class BaseDeDatos
    {
        private SqlConnection conn;

        public static string obtenerString()
        {
            return Settings.Default.SistemaOTConnectionString;
        }

        public BaseDeDatos()
        {
            conn = new SqlConnection();
            conn.ConnectionString = obtenerString();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source: "+ex.ToString());
            }
        }

        public int cerrarBD()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to close data source: " + ex.ToString());
                return 1;
            }

            return 0;

        }

        


    }
}
