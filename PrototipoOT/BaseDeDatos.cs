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
        //private SqlConnection conn;

        public static string obtenerString()
        {
            return Settings.Default.SistemaOTConnectionString;
        }

        public BaseDeDatos()
        {

        }



        ///ABC

        public int insertData(String tabla, String[] valores)
        {

            List<String> columnas = QueryColumns(tabla);
            using (SqlConnection connection = new SqlConnection(obtenerString()))
            {
                String stringColumns = "INSERT INTO "+ tabla +" (";
                String stringValues =  "VALUES (";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                for (int x = 1; x < columnas.Count; x++)
                {
                    //Construyendo cadena de Inserción;
                    stringColumns += columnas[x] + ((x < columnas.Count - 1) ? "," : ") ");
                    stringValues += "@" + columnas[x] + ((x < columnas.Count - 1) ? "," : ")");

                    //Parametrizando la inserción
                    cmd.Parameters.AddWithValue("@" + columnas[x], valores[x - 1]);
                }

                cmd.CommandText = stringColumns + stringValues;
                

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = conn;
            //cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
            //cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            //conn.Open();
            //cmd.ExecuteNonQuery();

            return 0;
        }

        public int updateData(String tabla, String[] valores, String id)
        {
            List<String> columnas = QueryColumns(tabla);
            using (SqlConnection connection = new SqlConnection(obtenerString()))
            {
                String stringColumns = "UPDATE @Tabla SET ";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                for (int x = 1; x < columnas.Count; x++)
                {
                    //Construyendo cadena de Modificación;
                    stringColumns += columnas[x] + "=" + "@" + columnas[x] + ((x < columnas.Count - 1) ? "," : " ");

                    //Parametrizando la modificación
                    cmd.Parameters.AddWithValue("@" + columnas[x], valores[x - 1]);
                }

                cmd.CommandText = stringColumns + "WHERE " + columnas[0] + "='" + id +"'";

                connection.Open();
                cmd.ExecuteNonQuery();
            }


            return 0;
        }

        public int deleteData()
        {
            return 0;
        }

        //Nombre de la Funcion: QueryColumns
        //Parámetros:
        //  tabla - String.- Una cadena con el nombre de la tabla a consultar.
        //Devuelve:
        //  Un List<String> listando las columnas de la tabla.

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
                        returnArray.Add(String.Format("{0}", reader["COLUMN_NAME"]));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
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
