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

namespace Geburtstagskalender
{
    public partial class Uc_Kalender : UserControl
    {
        public Uc_Kalender()
        {
            InitializeComponent();
        }

        public void ChangeVis(Person person)
        {
            if (person != null ? true : false)
            {
                txt_BDayKid.Text = person.Vorname + " " + person.Nachname;
                txt_BDayKid.Visibility = Visibility.Visible;
                img_BDayToday.Visibility = Visibility.Visible;
            }
            else
            {
                txt_BDayKid.Visibility = Visibility.Hidden;
                img_BDayToday.Visibility = Visibility.Hidden;
            }
        }
    }
}
