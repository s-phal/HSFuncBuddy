namespace HSFuncBuddy.Application.Config
{
    public class DBConnection
    {
        public static string GetConnectionString()
        {

            return "Server=(localdb)\\MSSQLLocalDB;Database=funcbuddy;Trusted_Connection=True;";

        }
    }
}
