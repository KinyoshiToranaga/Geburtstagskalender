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

        public uc_namelist(IOC ioc)
        {
            InitializeComponent();
            this.ioc = ioc;
            LstB_MemberList.ItemsSource = ioc.CollOfBDays;
        }

        public void Change(bool bdays)
        {
            LstB_MemberList.ItemsSource = bdays ? ioc.CollOfBDays : ioc.CollOfPeople;
        }
    }
}
