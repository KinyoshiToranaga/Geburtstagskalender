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
    /// Interaktionslogik für uc_AddUser.xaml
    /// </summary>
    public partial class Uc_AddUser : UserControl
    {
        IOC ioc;

        public Uc_AddUser(IOC ioc, bool bearbeiten)
        {
            InitializeComponent();
            this.ioc = ioc;
            if (!bearbeiten)
            {
                txt_Email.IsEnabled = false;
                txt_Geb.IsEnabled = false;
                txt_Kennung.IsEnabled = false;
                txt_Nachname.IsEnabled = false;
                txt_Ort.IsEnabled = false;
                txt_PLZ.IsEnabled = false;
                txt_Strasse.IsEnabled = false;
                txt_Tel.IsEnabled = false;
                txt_Vorname.IsEnabled = false;
            }
        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (ioc.CheckEmail(txt_Email.Text))
            {
                ioc.AddPeople(txt_Kennung.Text, txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
            }
            cc_AddUser.Content = null;
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
