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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Geburtstagskalender
{
    public partial class Uc_Kalender : UserControl
    {
        private List<Person> BDayKids;
        IOC ioc;

        public Uc_Kalender()
        {
            InitializeComponent();
            LsV_BDayKids.ItemsSource = BDayKids;
        }

        public void ChangeVis(List<Person> persons)
        {
            if (persons.Count != 0 ? true : false)
            {
                BDayKids = null;
                BDayKids = persons;
                LsV_BDayKids.Visibility = Visibility.Visible;
                img_BDayToday.Visibility = Visibility.Visible;
            }
            else
            {
                LsV_BDayKids.Visibility = Visibility.Hidden;
                img_BDayToday.Visibility = Visibility.Hidden;
            }
        }
    }
}
