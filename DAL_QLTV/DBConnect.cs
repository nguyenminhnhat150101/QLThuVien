using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLTV
{
    public class DBConnect
    {    
        //string dfggfdl,o,kl
       protected SqlConnection _conn = new SqlConnection(@"Data Source=LAPTOP-O7CEPANL\MSSQLSERVER1;Initial Catalog=northwind;Integrated Security=True");
    }
}
