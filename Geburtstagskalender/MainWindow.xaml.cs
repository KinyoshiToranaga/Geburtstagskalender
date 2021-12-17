﻿using System;
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
Geburtstagsliste nach KOMMENDEN Geburtstagen sortieren statt nach Geburtsdatum
*/
namespace Geburtstagskalender
{
    public partial class MainWindow : Window
    {
        IOC ioc = new IOC();
        Uc_namelist namelist;
        Uc_AddUser addUser;
        Uc_Kalender kalender;

        public MainWindow()
        {
            InitializeComponent();
            addUser = new Uc_AddUser(ioc, 1);
            namelist = new Uc_namelist(ioc, addUser);
            kalender = new Uc_Kalender();
            uc_Left.Content = namelist;
            uc_Right.Content = kalender;
            ioc.GetPeople();
            ioc.GetBDays();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                namelist.Change(2, txt_search.Text);
            }
            else
            {
                namelist.Change(0, "");
            }
        }

        private void btn_ShowGebList_Click(object sender, RoutedEventArgs e)
        {
            uc_Right.Content = kalender;
            kalender.cal_Kalender.SelectedDates.Clear();
            foreach (Person person in ioc.CollOfPeople)
            {
                kalender.cal_Kalender.SelectedDates.Add(person.Geburtstag);
            }
            namelist.Change(1, "");
        }

        private void btn_DelUser_Click(object sender, RoutedEventArgs e)
        {
            if (namelist.Mode == 0 && namelist.LsV_MemberList.SelectedItems != null)
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
            uc_Right.Content = addUser;
            addUser.SwitchMode(1);
            namelist.Change(0, "");
        }

        private void btn_AddUser_Click(object sender, RoutedEventArgs e)
        {
            uc_Right.Content = addUser;
            addUser.SwitchMode(0);
            namelist.Change(0, "");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ioc.SafePeople();
        }
    }
}
