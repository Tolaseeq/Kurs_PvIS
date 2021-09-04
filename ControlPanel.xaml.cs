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
using System.Linq;
using Devart.Data.MySql.Linq;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace KURS_SERGEEV
{
    public partial class ControlPanel : Window
    {
        static FsDbContext.FsDbDataContext context = new FsDbContext.FsDbDataContext();
        static FsDbContext.Film newFilm = new FsDbContext.Film();
        static bool new_record_click = false;
        static bool change_record_click = false;
        static bool delete_record_click = false;

        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32", SetLastError = true)]
        public static extern void FreeConsole();
        public ControlPanel()
        {
            InitializeComponent();
            //AllocConsole();
            update_list();
        }

        void update_list ()
        {
            req_class Film1 = new req_class();
            FsDbContext.FsDbDataContext context = new FsDbContext.FsDbDataContext();

            BindingList<req_class> filmlist = new BindingList<req_class>();
            foreach (FsDbContext.Film film in context.Films)
            {
                filmlist.AddNew();
                filmlist.Last().id = film.FilmId;
                filmlist.Last().name = film.FilmName;
                filmlist.Last().genre = film.FilmGenre;
                filmlist.Last().description = film.FilmDescription;
                filmlist.Last().critic_rate = (int)film.CriticRate;
            }
            table_grid.ItemsSource = filmlist;

            var query = from it in context.Films
                        select it;
        }
        private void new_record_Click(object sender, RoutedEventArgs e)
        {
            if (new_record_click == false)
            {
                change_rec_panel.Visibility = Visibility.Visible;
                id_panel.Visibility = Visibility.Collapsed;
                new_record_click = true;
            }
            else
            {
                newFilm.FilmName = name_in.Text;
                newFilm.FilmGenre = genre_in.Text;
                newFilm.FilmDescription = desc_in.Text;
                newFilm.CriticRate = Convert.ToInt32(rate_in.Text);
                context.Films.InsertOnSubmit(newFilm);
                context.SubmitChanges();
                update_list();
                new_record_click = false;
                change_rec_panel.Visibility = Visibility.Collapsed;
                id_panel.Visibility = Visibility.Collapsed;
            }
        }

        private void change_record_Click(object sender, RoutedEventArgs e)
        {
            if (delete_record_click == false)
            {
                change_rec_panel.Visibility = Visibility.Visible;
                id_panel.Visibility = Visibility.Visible;
                delete_record_click = true;
            }
            else
            {
                foreach (FsDbContext.Film film in context.Films)
                {
                    if (film.FilmId == Convert.ToInt32(id_in.Text))
                    {
                        film.FilmName = name_in.Text;
                        film.FilmGenre = genre_in.Text;
                        film.FilmDescription = desc_in.Text;
                        film.CriticRate = Convert.ToInt32(rate_in.Text);
                        break;
                    }
                }
                context.SubmitChanges();
                update_list();
                change_rec_panel.Visibility = Visibility.Collapsed;
                id_panel.Visibility = Visibility.Collapsed;
                delete_record_click = false;
            }
        }

        private void delete_record_Click(object sender, RoutedEventArgs e)
        {
            if (delete_record_click == false)
            {
                change_rec_panel.Visibility = Visibility.Collapsed;
                id_panel.Visibility = Visibility.Visible;
                delete_record_click = true;
            }
            else
            {
                foreach (FsDbContext.Film film in context.Films)
                {
                    if (film.FilmId == Convert.ToInt32(id_in.Text))
                    {
                        context.Films.DeleteOnSubmit(film);
                        break;
                    }
                }
                context.SubmitChanges();
                update_list();
                change_rec_panel.Visibility = Visibility.Collapsed;
                id_panel.Visibility = Visibility.Collapsed;
                delete_record_click = false;
            }
        }

        private void user_table_Click(object sender, RoutedEventArgs e)
        {
            UserManagementPanel userPanel = new UserManagementPanel();
            userPanel.Show();
            this.Close();
        }
    }
}
