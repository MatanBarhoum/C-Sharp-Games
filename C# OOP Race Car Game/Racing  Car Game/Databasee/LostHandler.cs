using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Racing__Car_Game.Databasee
{
    public class LostHandler
    {
        private readonly Engine _engine;

        public LostHandler(Engine engine)
        {
            _engine = engine;
        }


        public void UpdateScoreAndCoins(int score, int currentScore, int coins, int currentCoins, string username)
        {
            using(var con = new SqlConnection(_engine.connectionString))
            {
                _engine.SQLOpen(con);
                using(var cmd = new SqlCommand("UPDATE Accounts SET score=@score, coins=@coins WHERE username=@username", con))
                {
                     // will sum the current score (which is passed from the main menu) with the score which been passed from the game itself upon losing.
                    var totalCoins = currentCoins + coins; // "" "" "" "" "" "" "" "" "" "" "" " "" "" "" "";
                    if (currentScore > score)
                    {
                        cmd.Parameters.AddWithValue("@score", currentScore);
                    } else
                    {
                        cmd.Parameters.AddWithValue("@score", score);
                    }
                    
                    cmd.Parameters.AddWithValue("@coins", totalCoins);
                    cmd.Parameters.AddWithValue("@username", username);

                    using(var sda = new SqlDataAdapter(cmd))
                    {
                        var ds = new DataSet();
                        sda.Fill(ds);
                    }
                }
            }
        }
    }
}
