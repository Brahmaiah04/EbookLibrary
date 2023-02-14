using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Dataaccess
    {
            string conn = DataClass.Connection;

            //Method for Login
            public bool CheckLogin(UserInfo user)
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    if (string.IsNullOrWhiteSpace(user.StudentName) || string.IsNullOrWhiteSpace(user.Password))
                    {
                        return false;
                    }
                    SqlCommand cmd = new SqlCommand("loginForm", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Username1", user.StudentName);
                    cmd.Parameters.AddWithValue("@Password1", user.Password);
                    object read = cmd.ExecuteScalar();
                    int Var = Convert.ToInt32(read);
                    connection.Close();
                    return Var == 1;
                }

            }
            // Method for SignUp
            public bool Signup(UserInfo User)
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("Signinform", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Username1", User.StudentName);
                    cmd.Parameters.AddWithValue("@Password1", User.Password);
                    cmd.Parameters.AddWithValue("@Mail", User.Email   );
                    int read = cmd.ExecuteNonQuery();
                    connection.Close();
                    return read == 1;
                }
            }
        
    }
}
