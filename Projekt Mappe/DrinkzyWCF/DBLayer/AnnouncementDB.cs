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
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateAnnouncement(Announcement announcement)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Announcement(Title, Text, Date, Img) values(@Title, @Text, @Date, @Img)";
                    //cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.Parameters.AddWithValue("Title", announcement.Title);
                    cmd.Parameters.AddWithValue("Text", announcement.Text);
                    cmd.Parameters.AddWithValue("Date", announcement.Date);
                    cmd.Parameters.AddWithValue("Img", announcement.Img);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Announcement GetAnnouncement(string Title)
        {
            Announcement announcement = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Announcement Where Title = @Title";
                    cmd.Parameters.AddWithValue("Title", Title);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        announcement = new Announcement
                        {
                            //Id = (int)Reader["id"],
                            Title = (string)Reader["Title"],
                            Text = (string)Reader["Text"],
                            Date = (DateTime)Reader["Date"],
                            Img = (string)Reader["Img"]

                        };
                    }
                }
            }
            return announcement;
        }
    }
}

