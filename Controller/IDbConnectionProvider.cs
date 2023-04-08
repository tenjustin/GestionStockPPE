using System.Data.SqlClient;

namespace GestionStock.Controller
{
    public interface IDbConnectionProvider
    {
        SqlConnection GetConnection();
    }
}