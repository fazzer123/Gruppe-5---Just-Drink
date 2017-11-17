using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using ModelLayer;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class AnnouncementDB
    {
        CustomerDB cusDB = new CustomerDB();
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateAnnouncement(Announcement announcement)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Announcements(Title, anText, anDate, Img, customerId) values(@Title, @anText, @anDate, @Img, @customerId)";
                    //cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.Parameters.AddWithValue("Title", announcement.Title);
                    cmd.Parameters.AddWithValue("anText", announcement.Text);
                    cmd.Parameters.AddWithValue("anDate", announcement.Date);
                    cmd.Parameters.AddWithValue("Img", announcement.Img);
                    cmd.Parameters.AddWithValue("customerId", announcement.Customer.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Announcement GetAnnouncement(int id)
        {
            Announcement announcement = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Announcements Where id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        announcement = new Announcement
                        {
                            ID = (int)Reader["id"],
                            Title = (string)Reader["Title"],
                            Text = (string)Reader["anText"],
                            Date = (DateTime)Reader["anDate"],
                            Img = (string)Reader["Img"],
                            Customer = cusDB.GetCustomer((int)Reader["customerId"])
                        };
                    }
                }
            }
            return announcement;
        }
        public IEnumerable<Announcement> GetAllAnnouncements()
        {
            List<Announcement> AnnouncementList = new List<Announcement>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Announcements";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        Announcement a = new Announcement
                        {
                            ID = (int)Reader["id"],
                            Title = (string)Reader["Title"],
                            Text = (string)Reader["anText"],
                            Date = (DateTime)Reader["anDate"],
                            Img = (string)Reader["Img"],
                            Customer = cusDB.GetCustomer((int)Reader["customerId"])
                        };
                        AnnouncementList.Add(a);
                    }
                }

            }
            return AnnouncementList;
        }
    }
}

