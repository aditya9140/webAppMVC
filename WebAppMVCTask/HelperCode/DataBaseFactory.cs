using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace WebAppMVCTask.HelperCode
{
    public class DataBaseFactory
    {
        public static int QuerySP(string storedProcedure, dynamic param = null, string module = null, string dbCon = null)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2HJ4PO\SQLEXPRESS;Initial Catalog=DBOrder;Integrated Security=True;");
            con.Open();
            int output = con.Execute(storedProcedure, param: (object)param, commandType: CommandType.StoredProcedure);
            return output;
        }

        public static IEnumerable<T> QuerySP<T>(string storedProcedure, dynamic param = null, string module = null, string dbCon = null) where T : class
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2HJ4PO\SQLEXPRESS;Initial Catalog=DBOrder;Integrated Security=True;");
            con.Open();
            var output = con.Query<T>(storedProcedure, param: (object)param, commandType: CommandType.StoredProcedure);
            return output;
        }
    }
}
