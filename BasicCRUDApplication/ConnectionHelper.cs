using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUDApplication
{
    public class ConnectionHelper
    {

        private static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        private SqlConnection con;
        
        private SqlDataReader dtRd;

        public SqlConnection Con { get=>con; set=> con = value; }
        
        public SqlDataReader DtRd { get => dtRd;set => dtRd = value; }

        public ConnectionHelper()
        {
            this.con= new SqlConnection(connectionString);            
        }

        public bool Connect()
        {
            if (this.con.State == System.Data.ConnectionState.Closed || this.con.State == System.Data.ConnectionState.Broken)
            {
                try { this.con.Open(); }
                catch {}
            }
            return true;
        }

        public void DisConnect()
        {
            if (this.con.State == System.Data.ConnectionState.Open)
            {
                this.con.Close();
                this.con.Dispose();
            }
        } 
        
    }
}
