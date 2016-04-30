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
        bool serversFetched = false;

        public frmCambiarServidor()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            SaveData(new string[] { cbServidor.Text, txtUsuario.Text,txtContrasena.Text,cbBaseDatos.Text });

            this.Close();
        }

        private void frmCambiarServidor_Load(object sender, EventArgs e)
        {
            string connStringApp = System.Configuration.ConfigurationManager.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString;
            string[] lista = connStringApp.Split(';');
            List<string> param = new List<string>();

            foreach(string str in lista)
            {
                string[] partes = str.Split('=');
                param.Add(partes[1]);
            }

            cbServidor.Text = param[0];
            txtUsuario.Text = param[2];
            txtContrasena.Text = param[3];
            cbBaseDatos.Text = param[1];

        }

        private DataTable FetchServers()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            return instance.GetDataSources();
        }

        private void SaveData(string[] parametros)
        {
            string connString = "Data Source="+parametros[0];
            connString += ";Initial Catalog=" + parametros[3];
            connString += ";User ID=" + parametros[1];
            connString += ";Password=" + parametros[2];

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString = connString;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
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
            try { sqlConn.Open(); }
            catch (Exception e) { MessageBox.Show(e.Message); return null; }

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
            List<DBName> dt = FetchDatabases(cbServidor.Text, txtUsuario.Text.Trim(), txtContrasena.Text);
            if (dt == null)
                return;
            else
            {
                cbBaseDatos.DataSource = dt;
                cbBaseDatos.DisplayMember = "Name";
                cbBaseDatos.ValueMember = "Name";
            }
        }

        public class DBName
        {
            public string Name { get; set; }
            public DBName(string _name)
            {
                Name = _name;
            }
        }

        private void cbServidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serversFetched)
            {
                DataTable dt = FetchServers();
                foreach (DataRow dr in dt.Rows)
                    cbServidor.Items.Add(dr["ServerName"]);
            }
            serversFetched = true;

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
