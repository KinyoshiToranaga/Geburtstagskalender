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

/*
Member bearbeiten
SuFu
Kalender hinzufügen
Email prüfen
GUI anpassen für Datum
*/
namespace Geburtstagskalender
{
    public partial class MainWindow : Window
    {
        IOC ioc = new IOC();
        uc_namelist namelist;

        public MainWindow()
        {
            InitializeComponent();
            namelist = new uc_namelist(ioc);
            uc_Left.Content = namelist;
            ioc.GetPeople();
            ioc.GetBDays();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_ShowGebList_Click(object sender, RoutedEventArgs e)
        {
            //Kalender hinzufügen
            namelist.Change(true);
        }

        private void btn_DelUser_Click(object sender, RoutedEventArgs e)
        {
            if (!namelist.Bdays && namelist.LsV_MemberList.SelectedItems != null)
            {
                List<int> indexes = new List<int>();
                System.Collections.IList tmp = namelist.LsV_MemberList.SelectedItems;
                foreach (Person person in tmp)
                {
                    indexes.Add(ioc.CollOfPeople.IndexOf(person));
                }
                indexes.Sort();
                for (int i = indexes.Count - 1; i >= 0; i--)
                {
                    ioc.CollOfPeople.RemoveAt(indexes[i]);
                }
            }
            ioc.GetBDays();
        }

        private void btn_ShowUser_Click(object sender, RoutedEventArgs e)
        {
            Uc_AddUser uc_addUser = new Uc_AddUser(ioc, false);
            uc_Right.Content = uc_addUser;
            namelist.Change(false);
        }

        private void btn_AddUser_Click(object sender, RoutedEventArgs e)
        {
            Uc_AddUser uc_addUser = new Uc_AddUser(ioc, true);
            uc_Right.Content = uc_addUser;
            namelist.Change(false);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ioc.SafePeople();
        }
    }
}
