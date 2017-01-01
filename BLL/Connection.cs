using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WindowsFormsApplication3.DAL;

namespace WindowsFormsApplication3.BLL
{
    internal class Connection
    {
       

        public DataTable GetDb(string sql)
        {
            WindowsFormsApplication3.DAL.Connection connection = new WindowsFormsApplication3.DAL.Connection();
            return connection.GetDb(sql);
        }

        
    }
}
