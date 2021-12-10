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
        //uc_namelist namelist;
        private int mode;

        public Uc_AddUser(IOC ioc, int mode)
        {
            InitializeComponent();
            this.ioc = ioc;
            //this.namelist = namelist;
            SwitchMode(1);
        }

        public void LoadUser(Person person)
        {
            txt_Kennung.Text = person.Kennung;
            txt_Vorname.Text = person.Kennung;
            txt_Nachname.Text = person.Nachname;
            txt_Geb.Text = person.Geburtstag.ToString();
            txt_Strasse.Text = person.Strasse;
            txt_PLZ.Text = person.PLZ;
            txt_Ort.Text = person.Ort;
            txt_Tel.Text = person.TelNr;
            txt_Email.Text = person.Email;
        }

        public void SwitchMode(int mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case 0: //hinzufügen
                    txt_Email.IsEnabled = true;
                    txt_Geb.IsEnabled = true;
                    txt_Kennung.IsEnabled = true;
                    txt_Nachname.IsEnabled = true;
                    txt_Ort.IsEnabled = true;
                    txt_PLZ.IsEnabled = true;
                    txt_Strasse.IsEnabled = true;
                    txt_Tel.IsEnabled = true;
                    txt_Vorname.IsEnabled = true;
                    btn_cancel.Visibility = Visibility.Visible;
                    btn_confirm.Visibility = Visibility.Visible;
                    btn_edit.Visibility = Visibility.Hidden; break;
                case 1: //anzeigen
                    txt_Email.IsEnabled = false;
                    txt_Geb.IsEnabled = false;
                    txt_Kennung.IsEnabled = false;
                    txt_Nachname.IsEnabled = false;
                    txt_Ort.IsEnabled = false;
                    txt_PLZ.IsEnabled = false;
                    txt_Strasse.IsEnabled = false;
                    txt_Tel.IsEnabled = false;
                    txt_Vorname.IsEnabled = false;
                    btn_cancel.Visibility = Visibility.Hidden;
                    btn_confirm.Visibility = Visibility.Hidden;
                    btn_edit.Visibility = Visibility.Visible; break;
                case 2: //bearbeiten
                    txt_Email.IsEnabled = true;
                    txt_Geb.IsEnabled = true;
                    txt_Kennung.IsEnabled = true;
                    txt_Nachname.IsEnabled = true;
                    txt_Ort.IsEnabled = true;
                    txt_PLZ.IsEnabled = true;
                    txt_Strasse.IsEnabled = true;
                    txt_Tel.IsEnabled = true;
                    txt_Vorname.IsEnabled = true;
                    btn_cancel.Visibility = Visibility.Visible;
                    btn_confirm.Visibility = Visibility.Visible;
                    btn_edit.Visibility = Visibility.Hidden; break;
            }
        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (ioc.CheckEmail(txt_Email.Text))
            {
                ioc.AddPeople(txt_Kennung.Text, txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
            }
            SwitchMode(1);
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.SwitchMode(1);
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            SwitchMode(2);
        }
    }
}
