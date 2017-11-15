using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DBLayer
{
    public class UserDB
    {
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.User(UserName, FirstName, LastName, Gender, Birthday, Password, Email, Phone ) values(@UserName, @FirstName, @LastName, @Gender, @Birthday, @Password, @Email, @Phone)";
                    //cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.Parameters.AddWithValue("UserName", user.UserName);
                    cmd.Parameters.AddWithValue("FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("LastName", user.LastName);
                    cmd.Parameters.AddWithValue("Gender", user.Gender);
                    cmd.Parameters.AddWithValue("Birthday", user.Birthday);
                    cmd.Parameters.AddWithValue("Password", user.Password);
                    cmd.Parameters.AddWithValue("Email", user.Email);
                    cmd.Parameters.AddWithValue("Phone", user.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetUser(string UserName)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From User Where UserName = @UserName";
                    cmd.Parameters.AddWithValue("UserName", UserName);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        user = new User
                        {
                            //Id = (int)Reader["id"],
                            UserName = (string)Reader["UserName"],
                            FirstName = (string)Reader["FirstName"],
                            LastName = (string)Reader["LastName"],
                            Gender = (string)Reader["Gender"],
                            Birthday = (DateTime)Reader["Birthday"],
                            Password = (string)Reader["Password"],
                            Email = (string)Reader["Email"],
                            Phone = (string)Reader["Phone"]

                        };
                    }
                }
            }
            return user;
        }
        public IEnumerable<User> getAllUsers()
        {
            List<User> UserList = new List<User>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM User";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        User u = new User
                        {
                            UserName = (string)Reader["UserName"],
                            FirstName = (string)Reader["FirstName"],
                            LastName = (string)Reader["LastName"],
                            Gender = (string)Reader["Gender"],
                            Birthday = (DateTime)Reader["Birthday"],
                            Password = (string)Reader["Password"],
                            Email = (string)Reader["Email"],
                            Phone = (string)Reader["Phone"]

                        };
                        UserList.Add(u);
                    }
                }

            }
            return UserList;
        }
    }
}
    


