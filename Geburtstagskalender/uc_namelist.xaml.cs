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
    public partial class Uc_namelist : UserControl
    {
        IOC ioc;
        Uc_AddUser AddUser;

        private int mode;

        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public Uc_namelist(IOC ioc, Uc_AddUser addUser)
        {
            InitializeComponent();
            this.ioc = ioc;
            this.AddUser = addUser;
            this.Change(1, "");
        }

        public void Change(int mode, string searchString)
        {
            this.Mode = mode;
            switch (mode)
            {
                case 0: LsV_MemberList.ItemsSource = ioc.CollOfPeople; break;
                case 1: LsV_MemberList.ItemsSource = ioc.CollOfBDays; break;
                case 2: LsV_MemberList.ItemsSource = ioc.SearchPeople(searchString); break;
            }
        }

        private void LsV_MemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LsV_MemberList.SelectedItems.Count != 0)
            {
                Person person = (Person)LsV_MemberList.SelectedItems[0];
                AddUser.LoadUser(person);
            }
            else
            {
                AddUser.ClearUser();
            }
        }
    }
}
