using Dapper;
using HSFuncBuddy.Application.Config;
using HSFuncBuddy.Application.Models;
using System.Data;
using System.Data.SqlClient;

namespace HSFuncBuddy.Application.DataAccess
{
    public class FuncBuddyDAO
    {
        public string connectionString { get; } = DBConnection.GetConnectionString();

        public List<FuncBuddy> RetrieveAll()
        {

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM func_buddy";

                return connection.Query<FuncBuddy>(sqlQuery).ToList();

            }
        }

        public void Create(FuncBuddy funcBuddy)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "" +
                "INSERT INTO func_buddy " +
                "(title, content, language_id) " +
                "VALUES " +
                "(@Title, @Content, 1) ";

                connection.Execute(sqlQuery, new
                {
                    Title = funcBuddy.title,
                    Content = funcBuddy.content
                });
            }
        }

    }

}
