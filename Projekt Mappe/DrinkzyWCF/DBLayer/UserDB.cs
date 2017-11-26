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
                    cmd.CommandText = "Insert Into dbo.DrinkzyUser(UserName, FirstName, LastName, Gender, Birthday, Password, Email, Phone ) values(@UserName, @FirstName, @LastName, @Gender, @Birthday, @Password, @Email, @Phone)";
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

        public User GetUser(int id)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From DrinkzyUser Where id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        user = new User
                        {
                            ID = (int)Reader["id"],
                            UserName = (string)Reader["userName"],
                            FirstName = (string)Reader["firstName"],
                            LastName = (string)Reader["lastName"],
                            Gender = (string)Reader["gender"],
                            Birthday = (DateTime)Reader["birthday"],
                            Password = (string)Reader["userPassword"],
                            Email = (string)Reader["email"],
                            Phone = (string)Reader["phone"]

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
                    cmd.CommandText = "SELECT * FROM DrinkzyUser";
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
                            Password = (string)Reader["userPassword"],
                            Email = (string)Reader["Email"],
                            Phone = (string)Reader["Phone"]

                        };
                        UserList.Add(u);
                    }
                }

            }
            return UserList;
        }
        public void UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Update DrinkzyUser SET UserName = @UserName, FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Birthday = @Birthday, Email = @Email, Phone = @Phone WHERE id = @id";
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
                public void DeleteUser(int UserID)
                {
                    using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        using (SqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "Delete From dbo.DrinkzyUser Where id = @id";
                            cmd.Parameters.AddWithValue("id", UserID);
                            cmd.ExecuteNonQuery();
                        }
                    }
            }

        }
    }

    


