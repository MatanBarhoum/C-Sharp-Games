using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Racing__Car_Game.Databasee
{
    public class Engine
    {
        private static string dbname = "Matan-235";
        public string connectionString = $"Data Source={dbname};Initial Catalog=RaceCarBe;Integrated Security=True;MultipleActiveResultSets=true";

        public void SQLOpen(SqlConnection con)
        {
            con.Open();
        }

        public void SQLClose(SqlConnection con)
        {
            con.Close();
        }
    }
}
