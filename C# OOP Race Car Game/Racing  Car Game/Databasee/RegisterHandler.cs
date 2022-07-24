using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing__Car_Game.Databasee
{
    public class RegisterHandler
    {
        private Engine _engine;

        public RegisterHandler()
        {
            _engine = new Engine();
        }

        public void Register(string username, string password, TextBox txtUsername, TextBox txtPassword)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Missing username or password.");
            }
            else
            {
                var UserExist = false;
                using (var con = new SqlConnection(_engine.connectionString))
                {
                    try
                    {
                        _engine.SQLOpen(con);

                        using (var cmd = new SqlCommand("SELECT * FROM Accounts WHERE username=@username", con))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                if (reader["username"].ToString().ToLower() == username.ToLower())
                                {
                                    MessageBox.Show("Username already Exists.");
                                    UserExist = true;
                                }
                            }
                        }

                        if (!UserExist)
                        {
                            using (var cmd = new SqlCommand("INSERT INTO Accounts VALUES(@username, @password, @score, @coins)", con))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@score", 0);
                                cmd.Parameters.AddWithValue("@coins", 0);

                                using (var sda = new SqlDataAdapter(cmd))
                                {
                                    var dataset = new DataSet();
                                    sda.Fill(dataset);
                                    MessageBox.Show("Successfully Registered");
                                }
                            }
                        }
                    }

                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { _engine.SQLClose(con); }
                }
            }
        }
    }
}
