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

/*                                                                                IN ARBEIT IN UC_ADDUSER.XAML.CS
Kalender hinzufügen
SuFu
*/
namespace Geburtstagskalender
{
    public partial class MainWindow : Window
    {
        IOC ioc = new IOC();
        uc_namelist namelist;
        Uc_AddUser addUser;

        public MainWindow()
        {
            InitializeComponent();
            addUser = new Uc_AddUser(ioc, namelist, 1);
            namelist = new uc_namelist(ioc, addUser);
            uc_Left.Content = namelist;
            uc_Right.Content = addUser;
            ioc.GetPeople();
            ioc.GetBDays();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            ioc.Search(txt_search.Text);
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
            ioc.CollOfBDays.Clear();
            ioc.GetBDays();
        }

        private void btn_ShowUser_Click(object sender, RoutedEventArgs e)
        {
            addUser.SwitchMode(1);
            namelist.Change(false);
        }

        private void btn_AddUser_Click(object sender, RoutedEventArgs e)
        {
            addUser.SwitchMode(0);
            namelist.Change(false);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ioc.SafePeople();
        }
    }
}
