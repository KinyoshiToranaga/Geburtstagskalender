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

namespace Geburtstagskalender
{
    /// <summary>
    /// Interaktionslogik für uc_namelist.xaml
    /// </summary>
    public partial class uc_namelist : UserControl
    {
        IOC ioc;
        Uc_AddUser AddUser;

        private bool bdays;

        public bool Bdays
        {
            get { return bdays; }
        }

        public uc_namelist(IOC ioc, Uc_AddUser addUser)
        {
            InitializeComponent();
            this.ioc = ioc;
            this.AddUser = addUser;
            this.Change(true);
        }

        public void Change(bool bdays)
        {
            this.bdays = bdays;
            if (bdays)
            {
                LsV_MemberList.ItemsSource = ioc.CollOfBDays;
            }
            else
            {
                LsV_MemberList.ItemsSource = ioc.CollOfPeople;
            }
        }

        private void LsV_MemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = "";
            Person person=(Person)LsV_MemberList.SelectedItems[0];
            AddUser.LoadUser(person);
        }

        private void LsV_MemberList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
