using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PrototipoOT.Properties;
using System.Windows.Forms;
using System.Data;

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


        ///ABC

        public int insertData(String tabla, String[] valores)
        {

            List<String> columnas = QueryColumns(tabla);
            using (SqlConnection connection = new SqlConnection(obtenerString()))
            {
                String stringColumns = "INSERT INTO @Tabla (";
                String stringValues =  "VALUES (";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                for (int x = 1; x < columnas.Count; x++)
                {
                    //Construyendo cadena de consulta;
                    stringColumns += columnas[x] + ((x < columnas.Count - 1) ? "," : ") ");
                    stringValues += "@" + columnas[x] + ((x < columnas.Count - 1) ? "," : ")");

                    //Parametrizando la inserción
                    cmd.Parameters.AddWithValue("@" + columnas[x], valores[x - 1]);
                }

                cmd.CommandText = stringColumns + stringValues;

     




            }
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
            //cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            conn.Open();
            cmd.ExecuteNonQuery();

            return 0;
        }

        public int updateData()
        {
            return 0;
        }

        public int deleteData()
        {
            return 0;
        }

        private List<String> QueryColumns(String tabla)
        {
            List<String> returnArray = new List<String>();

            using (SqlConnection connection = new SqlConnection(obtenerString()))
            {
                String queryString = "SELECT COLUMN_NAME,* FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tabla AND TABLE_SCHEMA='dbo'";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@tabla", tabla);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        returnArray.Add(String.Format("{0}",reader["descripcion"]));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return returnArray;
        }






        


    }
}
