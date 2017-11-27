using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDrinkzy.UserServiceRef;
namespace WpfDrinkzy
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        UserServiceClient UserClient = new UserServiceClient();
        public UserPage()
        {
            InitializeComponent();
            fillViewList();
        }
        public void CreateUser()
        {
            WpfDrinkzy.UserServiceRef.User u = new WpfDrinkzy.UserServiceRef.User();
            DateTime btext = DateTime.Parse(birthText.Text);

            {
                u.UserName = UserText.Text;
                u.Password = PassText.Text;
                u.FirstName = FirstnText.Text;
                u.LastName = LastnText.Text;
                u.Gender = GenderText.Text;
                u.Birthday = btext;
                u.Email = mailText.Text;
                u.Phone = phoneText.Text;
            }
            UserClient.CreateUser(u);
        }
        public void UpdateUser()
        {
            WpfDrinkzy.UserServiceRef.User u = new WpfDrinkzy.UserServiceRef.User();
            DateTime btext = DateTime.Parse(birthText.Text);
            {
                u.UserName = UserText.Text;
                u.Password = PassText.Text;
                u.FirstName = FirstnText.Text;
                u.LastName = LastnText.Text;
                u.Gender = GenderText.Text;
                u.Birthday = btext;
                u.Email = mailText.Text;
                u.Phone = phoneText.Text;
            }
            UserClient.UpdateUser(u);
        }
        public void DeleteUser()
        {
            WpfDrinkzy.UserServiceRef.User u = (WpfDrinkzy.UserServiceRef.User)UserList.SelectedItem;
            UserClient.DeleteUser(u.ID);
        }

        public void fillViewList()
        {
            UserList.ItemsSource = null;
            UserList.ItemsSource = UserClient.getAllUsers();

        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            CreateUser();
            fillViewList();
        }

        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser();
            fillViewList();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            DeleteUser();
            fillViewList();
        }
        public void Details(User user)
        {
            if (user != null)

            {
                UserList.ItemsSource = UserClient.GetUser(user.ID).UserName;
                UserList.ItemsSource = UserClient.GetUser(user.ID).FirstName;
                UserList.ItemsSource = UserClient.GetUser(user.ID).LastName;
                UserText.Text = user.UserName;
                FirstnText.Text = user.FirstName;
                LastnText.Text = user.LastName;
            }
        }
    
        public void Changer(object sender, SelectionChangedEventArgs e)
        {
            User u = (User)UserList.SelectedItem;
            Details(u);
            

        }
    }
}
        

