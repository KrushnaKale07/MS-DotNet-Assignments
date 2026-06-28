using Microsoft.Data.SqlClient;
using WebApplDay9.Models;

namespace WebApplDay9.DAO
{
    public class UserDAO : IUserDAO
    {
        private readonly string conn;

        public UserDAO(IConfiguration configuration) {
            conn = configuration.GetConnectionString("MySQLConn");

        }

        public void Register(User user)
        {

            SqlConnection connection = new(conn);
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@Username, @Password, @Email, @Role)", connection);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Role", user.Role);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public User? ValidateUser(string username, string password)
       {

            SqlConnection connection = new(conn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username=@u AND Password=@p", connection);

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            connection.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    Id = (int)reader["Id"],
                    Username = reader["Username"].ToString(),
                    Role = reader["Role"].ToString()
                };
            }
            connection.Close();
            return null;



            //    SqlConnection connection = new(conn);
            //    SqlCommand cmd = new SqlCommand("Select * from users where Username=@u AND Passwerd=@p", connection);
            //    cmd.Parameters.AddWithValue("@u", userName);
            //    cmd.Parameters.AddWithValue("@p", password);

            //    connection.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        return new User
            //        {
            //            Id = (int)reader["Name"],
            //            Username = (string)reader["Name"],
            //            Role = (string)reader["Role"]
            //        };
            //    }

            //    return null;

        }
    }
}
