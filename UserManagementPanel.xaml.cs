using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Linq;

namespace KURS_SERGEEV
{
    /// <summary>
    /// Логика взаимодействия для UserManagementPanel.xaml
    /// </summary>
    public partial class UserManagementPanel : Window
    {
        static FsDbContext.FsDbDataContext context = new FsDbContext.FsDbDataContext();
        public UserManagementPanel()
        {
            InitializeComponent();
            update_list();
        }

        void update_list()
        {
            req_user user_local = new req_user();
            BindingList<req_user> userlist = new BindingList<req_user>();
            foreach (FsDbContext.User user in context.Users)
            {
                userlist.AddNew();
                userlist.Last().id = user.UserId;
                userlist.Last().username = user.Username;
                userlist.Last().password = user.Password;
                if (user.BanStatus == 1)
                {
                    userlist.Last().ban_status = true;
                }
                else
                {
                    userlist.Last().ban_status = false;
                }
                if (user.IsAdmin == 1)
                {
                    userlist.Last().is_admin = true;
                }
                else
                {
                    userlist.Last().is_admin = false;
                }
            }
            table_grid.ItemsSource = userlist;

            var query = from it in context.Films
                        select it;
        }

        private void ban_unban_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(id_box.Text, @"^[0-9_]{1,10}$"))
            {
                System.Windows.MessageBox.Show("Incorrect index!");
            }
            else
            {
                foreach (FsDbContext.User user in context.Users)
                {
                    if (user.UserId == Convert.ToInt32(id_box.Text))
                    {
                        if(user.BanStatus == 1)
                        {
                            user.BanStatus = 0;
                        }
                        else
                        {
                            user.BanStatus = 1;
                        }
                        break;
                    }
                }
                context.SubmitChanges();
                update_list();
            }
        }

        private void film_list_Click(object sender, RoutedEventArgs e)
        {
            ControlPanel controlPanel = new ControlPanel();
            controlPanel.Show();
            this.Close();
        }

        private void set_admin_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(id_box.Text, @"^[0-9_]{1,10}$"))
            {
                System.Windows.MessageBox.Show("Incorrect index!");
            }
            else
            {
                foreach (FsDbContext.User user in context.Users)
                {
                    if (user.UserId == Convert.ToInt32(id_box.Text))
                    {
                        if (user.IsAdmin == 1)
                        {
                            user.IsAdmin = 0;
                        }
                        else
                        {
                            user.IsAdmin = 1;
                        }
                        break;
                    }
                }
                context.SubmitChanges();
                update_list();
            }
        }
    }
}
