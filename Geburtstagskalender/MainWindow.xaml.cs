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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IOC ioc = new IOC();
        uc_namelist namelist;

        public MainWindow()
        {
            InitializeComponent();
            namelist = new uc_namelist(ioc);
            uc_Left.Content = namelist;
            this.ioc.GetPeople();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_ShowGebList_Click(object sender, RoutedEventArgs e)
        {

            namelist.Change(true);
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
