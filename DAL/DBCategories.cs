using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.DAL
{
    internal class DBCategories
    {
        private DataTable dt;
        private SqlDataAdapter sda;
        DBInit Con;

        public DataTable SelectAllCategories()
        {
            Con = new DBInit();
            dt = new DataTable();
            String Req = "Select * from categories";
            dt = Con.readData(Req);
            return dt;

        }
    }
}
