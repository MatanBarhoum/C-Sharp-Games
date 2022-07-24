using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Racing__Car_Game.Databasee
{
    public class Authenticator
    {
        public bool Authenticate(string username, string password)
        {
            var database = new Engine();

            using (var con = new SqlConnection(database.connectionString))
            {
                try
                {
                    database.SQLOpen(con);
                    using (var cmd = new SqlCommand("SELECT * FROM Accounts WHERE username=@username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if (reader["username"].ToString().ToLower() == username.ToLower() && reader["password"].ToString().ToLower() == password.ToLower())
                            {
                                return true;
                            }
                        }
                        
                    }
                } 
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { database.SQLClose(con); }
                return false;
            }
        }
    }
}
