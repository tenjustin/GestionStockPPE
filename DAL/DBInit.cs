using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.DAL
{
    internal class DBInit
    {

        private string connString;
        private SqlConnection conn;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;

        public DBInit()
        {
            connString = "Data Source=(localdb)\\mssqllocaldb;AttachDbFilename=C:\\Users\\Justin\\BDD\\GestionStockPPE.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(connString);
            Cmd = new SqlCommand();
            Cmd.Connection = conn;
        }

        public DataTable readData(string Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, conn);
            sda.Fill(dt);
            return dt;
        }

        public int pushData(string Req)
        {
            int cnt = 0;
            if(conn.State == ConnectionState.Open)
            {
                conn.Open();
            }
            Cmd.CommandText = Req;
            return cnt;
        }
    }
}
