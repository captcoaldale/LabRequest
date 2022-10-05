using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PointOfSale.DataObjects
{
    class MySQL_Connection
    {
        public MySql.Data.MySqlClient.MySqlConnection conn;
        private string strConnection = "";
        private string fallback = "Server=localhost;Database=fwa-scrape;Uid=root;Pwd=br3nda;";
        private string caller = "";

        public string ConnectionString
        {
            get { return strConnection; }
            set { strConnection = value; }
        }

        public MySQL_Connection(string strConnection = "", string caller = "")
        {
            if (string.IsNullOrEmpty(strConnection))
                this.strConnection = fallback;
            else
                this.strConnection = strConnection;
            this.caller = caller;
        }

        public void OpenConnection()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(strConnection);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CloseConnection()
        {
            conn.Close();
        }
        // call this method to perform insert, delete and update functions ...
        public void ExecuteQueries(string query, string caller = "")
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(caller + ": " + ex.Message);
            }
        }
        // Call this method to show data in a textbox or label ...
        public MySqlDataReader DataReader(string query, string caller = "")
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (MySqlException x)
            {
                MessageBox.Show(caller + ": " + x.Message);
                return null;
            }

        }

        // Call this method to show data in a table (DataGridView) ...
        // Example - dataGridView1.datasource = ClassObject.ShowDataInGridView("Select * From Student");
        public DataSet DataSetGet(string query, string caller = "")
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (MySqlException x)
            {
                MessageBox.Show(caller + ": " + x.Message);
                return null;
            }
        }
        // Call this method to show data in a table (DataGridView) ...
        // Example - dataGridView1.datasource = ClassObject.ShowDataInGridView("Select * From Student");
        public DataTable DataTableGet(string query, string caller = "")
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable tbl = new DataTable();
                da.Fill(tbl);
                return tbl;
            }
            catch (MySqlException x)
            {
                MessageBox.Show(caller + ": " + x.Message);
                return null;
            }
        }

        // Call this method to retrieve a pk ...
        public int DataGet(string query, string caller = "")
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(caller + ": " + ex.Message);
                return 0;
            }

        }
    }
}
