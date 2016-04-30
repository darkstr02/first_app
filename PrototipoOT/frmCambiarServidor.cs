using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PrototipoOT
{
    public partial class frmCambiarServidor : Form
    {
        public frmCambiarServidor()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCambiarServidor_Load(object sender, EventArgs e)
        {
            DataTable dt = FetchServers();
            foreach(DataRow dr in dt.Rows)
                cbServidor.Items.Add(dr["ServerName"]);
        }

        private DataTable FetchServers()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            return instance.GetDataSources();
        }

        private void SaveData(DataTable tabla)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString = textBox1.Text;
            //config.Save(ConfigurationSaveMode.Modified, true);
            //ConfigurationManager.RefreshSection("connectionStrings");
        }

        private List<DBName> FetchDatabases(string SelectedServer, string user, string passwd)
        {
            List<DBName> databases = new List<DBName>();

            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

            connection.DataSource = SelectedServer;
            // enter credentials if you want
            connection.UserID = user; //get username;
            connection.Password = passwd; //get password;
            connection.IntegratedSecurity = false;

            String strConn = connection.ToString();

            //create connection
            SqlConnection sqlConn = new SqlConnection(strConn);

            //open connection
            sqlConn.Open();

            //get databases
            DataTable tblDatabases = sqlConn.GetSchema("Databases");

            //close connection
            sqlConn.Close();

            //add to list
            foreach (DataRow row in tblDatabases.Rows)
            {
                String strDatabaseName = row["database_name"].ToString();
                databases.Add(new DBName(strDatabaseName));
            }
            return databases;
        }

        private void cbBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DBName> dt = FetchDatabases(cbServidor.SelectedItem.ToString(), txtUsuario.Text.Trim(), txtContrasena.Text);
            cbBaseDatos.DataSource = dt;
            cbBaseDatos.DisplayMember = "Name";
            cbBaseDatos.ValueMember = "Name";
        }



        public class DBName
        {
            public string Name { get; set; }
            public DBName(string _name)
            {
                Name = _name;
            }
        }
    }
}
