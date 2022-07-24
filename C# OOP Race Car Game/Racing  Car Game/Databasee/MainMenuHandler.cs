using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Racing__Car_Game.Databasee
{
    public class MainMenuHandler
    {
        Engine _engine;
        
        public void SetMainMenu(Label Score, Label Coins, string username)
        {
            _engine = new Engine();
            using(var con = new SqlConnection(_engine.connectionString))
            {
                _engine.SQLOpen(con);
                try
                {
                    using (var cmd = new SqlCommand("SELECT score,coins FROM Accounts WHERE username=@username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Score.Text = reader["score"].ToString();
                            Coins.Text = reader["coins"].ToString();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { _engine.SQLClose(con); }
            }
        }
    }
}
