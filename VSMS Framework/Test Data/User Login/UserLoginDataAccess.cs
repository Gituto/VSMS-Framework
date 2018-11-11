using Dapper;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

namespace VSMS_Framework.Test_Data.User_Login
{
    public class UserLoginDataAccess
    {
        public static string TestDataFileConnection()
        {
            var filename = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", filename);
            return con;
        }

        public static UserLoginData GetLoginTestData(string keyname)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", keyname);
                var value = connection.Query<UserLoginData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
