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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace KURS_SERGEEV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static FsDbContext.FsDbDataContext context = new FsDbContext.FsDbDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sign_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Regex.IsMatch(login.Text, @"^[0-9a-zA-Z_]{4,20}$") && Regex.IsMatch(password.Password, @"^[0-9a-zA-Z_]{4,20}$"))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(password.Password));
                    string pass = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                    bool match = false;
                    foreach (FsDbContext.User user in context.Users)
                    {
                        if ((pass.Equals(user.Password, StringComparison.InvariantCultureIgnoreCase))&&(login.Text.Equals(user.UserName)) /*&& (user.IsAdmin == 1)*/)
                        {
                            ControlPanel controlPanel = new ControlPanel();
                            match = true;
                            controlPanel.Show();
                            this.Close();
                        }
                    }
                    if (match == false)
                    {
                        System.Windows.MessageBox.Show("Wrong login or password!");
                        login.Text = "";
                        password.Password = "";
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Incorrect data!");
                }
            }
            catch (System.OverflowException exept)
            {
                System.Windows.MessageBox.Show("Incorrect symbols in password!");
            }
            catch (Exception exept)
            {
                System.Windows.MessageBox.Show(exept.Message);
            }
        }
    }
}
