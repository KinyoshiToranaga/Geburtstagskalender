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
        public ObservableCollection<Person> BDayKids = new ObservableCollection<Person>();

        public Uc_Kalender()
        {
            InitializeComponent();
            DataContext = this;
            LsV_BDayKids.ItemsSource = BDayKids;
        }

        public void ChangeVis(ObservableCollection<Person> persons)
        {
            if (persons.Count != 0 ? true : false)
            {
                BDayKids.Clear();
                foreach(Person person in persons)
                {
                    BDayKids.Add(person);
                }
                LsV_BDayKids.Visibility = Visibility.Visible;
                img_BDayToday.Visibility = Visibility.Visible;
            }
            else
            {
                LsV_BDayKids.Visibility = Visibility.Hidden;
                img_BDayToday.Visibility = Visibility.Hidden;
            }
        }

        private void GridViewColumnHeader_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
