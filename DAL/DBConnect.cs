﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        //ijii
        protected SqlConnection _conn = new SqlConnection(@"Data Source=LAPTOP-O7CEPANL\MSSQLSERVER1;Initial Catalog=QLThuVien;Integrated Security=True");
    }
}
