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
                userlist.Last().user_name = user.UserName;
                foreach (FsDbContext.UserRole role_c in context.UserRoles)
                {
                    if (userlist.Last().id == role_c.UserId)
                    {
                        foreach (FsDbContext.Role role_n in context.Roles)
                        {
                            if (role_c.RoleId == role_n.RoleId)
                            {
                                userlist.Last().user_role_name = role_n.Role1;
                            }
                        }
                    }
                }
            }
            table_grid.ItemsSource = userlist;

            var query = from it in context.Films
                        select it;
        }

        private void change_role_Click(object sender, RoutedEventArgs e)
        {
            FsDbContext.UserRole newRow = new FsDbContext.UserRole();
            if (!Regex.IsMatch(id_box.Text, @"^[0-9_]{1,10}$") || (!String.Equals(role_box.Text, "ADMIN") && !String.Equals(role_box.Text, "USER") && !String.Equals(role_box.Text, "BANNED")))
            {
                System.Windows.MessageBox.Show("Incorrect index or role name!");
            }
            else
            {
                foreach (FsDbContext.Role role in context.Roles)
                {
                    if (role.Role1.Equals(role_box.Text))
                    {
                        newRow.RoleId = role.RoleId;
                    }
                }
                foreach (FsDbContext.UserRole userrole in context.UserRoles)
                {
                    if (userrole.UserId == Convert.ToInt32(id_box.Text))
                    {
                        newRow.UserId = userrole.UserId;
                        context.UserRoles.DeleteOnSubmit(userrole);
                    }
                         
                }
                context.UserRoles.InsertOnSubmit(newRow);
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
    }
}
