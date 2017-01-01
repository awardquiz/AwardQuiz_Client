using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    class esqlbaglantisi
    {
        public SqlConnection baglan()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=okul; Integrated Security=true");
                baglanti.Open();
                SqlConnection.ClearPool(baglanti);
                SqlConnection.ClearAllPools();
                return (baglanti);
            }
            catch (Exception)
            {
                throw;
            } 
        }
    }
}
