using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing__Car_Game;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Racing__Car_Game.Databasee
{
    public class EndGameHandler
    {
        private Engine _db;
        public void SetValues(string username, EndGameForm _endGameForm)
        {
            _db = new Engine();

            using (var con = new SqlConnection(_db.connectionString))
            {
                try
                {
                    _db.SQLOpen(con);
                    using (var cmd = new SqlCommand("SELECT score,coins FROM Accounts WHERE username=@username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            _endGameForm.currentScore = Convert.ToInt32(reader["score"]);
                            _endGameForm.currentCoins = Convert.ToInt32(reader["coins"]);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { _db.SQLClose(con); }
            }

        }

    }
}

