using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication3.DAL
{
    internal class Connection
    {
        public DataTable GetDb(string sql)
        {
            DataTable table2;
            SqlConnection selectConnection = new SqlConnection();
            try
            {
                string str = @"Data Source=.; Initial Catalog=okul; Integrated Security=true";
                selectConnection.ConnectionString = str;
                selectConnection.Open();
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(sql, selectConnection).Fill(dataTable);
                table2 = dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                selectConnection.Close();
            }
            return table2;
        }

        
    }
}
