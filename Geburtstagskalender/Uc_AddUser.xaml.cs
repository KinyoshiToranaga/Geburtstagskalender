using Microsoft.Win32;
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
using System.Drawing;

namespace Geburtstagskalender
{
    public partial class Uc_AddUser : UserControl
    {
        private IOC ioc;
        private int mode;
        //Color colore = (Color)ColorConverter.ConvertFromString("#FFABADB3");
        SolidColorBrush brushRed = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));
        SolidColorBrush brushWhite = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        SolidColorBrush brushDefault = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFABADB3"));

        private SolidColorBrush _brush;
        public SolidColorBrush brush
        {
            get { return _brush; }
            set
            {
                _brush = value;
            }
        }

        public string Test = "Testwert";

        public Uc_AddUser(IOC ioc, int mode)
        {
            InitializeComponent();
            this.ioc = ioc;
            SwitchMode(1);
            /*txt_Kennung.BorderBrush = brush;
            txt_Vorname.BorderBrush = brush;
            txt_Nachname.BorderBrush = brush;
            txt_Geb.BorderBrush = brush;
            txt_Strasse.BorderBrush = brush;
            txt_PLZ.BorderBrush = brush;
            txt_Ort.BorderBrush = brush;
            txt_Tel.BorderBrush = brush;
            txt_Email.BorderBrush = brush;*/
            brush = brushDefault;
        }

        public void LoadUser(Person person)
        {
            if (mode != 0)
            {
                try
                {
                    if (person.ImgFilePath != null)
                    {
                        img_profile.Source = new BitmapImage(new Uri(person.ImgFilePath));
                    }
                    else
                    {
                        img_profile.Source = null;
                    }
                }
                catch { }
                txt_Kennung.Text = person.Kennung;
                txt_Vorname.Text = person.Vorname;
                txt_Nachname.Text = person.Nachname;
                txt_Geb.Text = person.Geburtstag.ToString();
                txt_Strasse.Text = person.Strasse;
                txt_PLZ.Text = person.PLZ;
                txt_Ort.Text = person.Ort;
                txt_Tel.Text = person.TelNr;
                txt_Email.Text = person.Email;
            }
        }

        public void ClearUser()
        {
            img_profile.Source = null;
            txt_Kennung.Text = "";
            txt_Vorname.Text = "";
            txt_Nachname.Text = "";
            txt_Geb.SelectedDate = DateTime.Today;
            txt_Strasse.Text = "";
            txt_PLZ.Text = "";
            txt_Ort.Text = "";
            txt_Tel.Text = "";
            txt_Email.Text = "";
        }

        public void SwitchMode(int mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case 0: //hinzufügen
                    brush = brushDefault;
                    btn_Image.IsEnabled = true;
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
                    btn_edit.Visibility = Visibility.Hidden;
                    ClearUser(); break;
                case 1: //anzeigen
                    brush = brushWhite;
                    btn_Image.IsEnabled = false;
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
                    brush = brushDefault;
                    btn_Image.IsEnabled = true;
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
            bool fail = false;
            if (txt_Kennung.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Vorname.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Nachname.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Geb.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Strasse.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_PLZ.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Ort.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (txt_Tel.Text == "")
            {
                brush = brushRed;
                fail = true;
            }
            else
            {
                brush = brushDefault;
            }
            if (ioc.CheckEmail(txt_Email.Text))
            {
                brush = brushDefault;
            }
            else
            {
                brush = brushRed;
                fail = true;
            }
            if (!fail)
            {
                try
                {
                    switch (mode)
                    {
                        case 0:
                            if ((BitmapImage)img_profile.Source == null)
                            {
                                ioc.AddPeople(txt_Kennung.Text, txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
                            }
                            else
                            {
                                ioc.AddPeople(txt_Kennung.Text, ((BitmapImage)img_profile.Source).UriSource.ToString(), txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
                            }
                            break;
                        case 2:
                            if ((BitmapImage)img_profile.Source == null)
                            {
                                ioc.ChangePeople(txt_Kennung.Text, txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text); break;
                            }
                            else
                            {
                                ioc.ChangePeople(txt_Kennung.Text, ((BitmapImage)img_profile.Source).UriSource.ToString(), txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text); break;
                            }
                    }
                    SwitchMode(1);
                }
                catch { }
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            SwitchMode(1);
            txt_Kennung.BorderBrush = brushWhite;
            txt_Vorname.BorderBrush = brushWhite;
            txt_Nachname.BorderBrush = brushWhite;
            txt_Strasse.BorderBrush = brushWhite;
            txt_PLZ.BorderBrush = brushWhite;
            txt_Ort.BorderBrush = brushWhite;
            txt_Tel.BorderBrush = brushWhite;
            txt_Email.BorderBrush = brushWhite;
            txt_Geb.BorderBrush = brushWhite;
            img_profile.Source = null;
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            SwitchMode(2);
        }

        private void btn_Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog picDialog = new OpenFileDialog();
            picDialog.Title = "Wählen Sie ein Profilbild aus";
            picDialog.Filter = "Grafiken|*.jpg;*.jpeg;*.png;*.bmp";
            if (picDialog.ShowDialog() == true)
            {
                img_profile.Source = new BitmapImage(new Uri(picDialog.FileName));
            }
        }
    }
}
