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

namespace Geburtstagskalender
{
    public partial class Uc_AddUser : UserControl
    {
        IOC ioc;
        uc_namelist namelist;
        private int mode;

        public Uc_AddUser(IOC ioc, uc_namelist namelist, int mode)
        {
            InitializeComponent();
            this.ioc = ioc;
            this.namelist = namelist;
            SwitchMode(1);
        }

        public void LoadUser(Person person)
        {
            if (mode != 0)
            {
                if (person.ImgFilePath!=null)
                {
                    img_profile.Source = new BitmapImage(new Uri(person.ImgFilePath));
                }
                else
                {
                    img_profile.Source = null;
                }
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
            if (txt_Kennung.Text == "")
            {
                txt_Kennung.Background = Brushes.Red;
            }
            else
            {
                txt_Kennung.Background = Brushes.White;
                if (txt_Vorname.Text == "")
                {
                    txt_Vorname.Background = Brushes.Red;
                }
                else
                {
                    txt_Vorname.Background = Brushes.White;
                    if (txt_Nachname.Text == "")
                    {
                        txt_Nachname.Background = Brushes.Red;
                    }
                    else
                    {
                        txt_Nachname.Background = Brushes.White;
                        if (txt_Geb.Text == "")
                        {
                            txt_Geb.Background = Brushes.Red;
                        }
                        else
                        {
                            txt_Geb.Background = Brushes.White;
                            if (txt_Strasse.Text == "")
                            {
                                txt_Strasse.Background = Brushes.Red;
                            }
                            else
                            {
                                txt_Strasse.Background = Brushes.White;
                                if (txt_PLZ.Text == "")
                                {
                                    txt_PLZ.Background = Brushes.Red;
                                }
                                else
                                {
                                    txt_PLZ.Background = Brushes.White;
                                    if (txt_Ort.Text == "")
                                    {
                                        txt_Ort.Background = Brushes.Red;
                                    }
                                    else
                                    {
                                        txt_Ort.Background = Brushes.White;
                                        if (txt_Tel.Text == "")
                                        {
                                            txt_Tel.Background = Brushes.Red;
                                        }
                                        else
                                        {
                                            txt_Tel.Background = Brushes.White;
                                            if (ioc.CheckEmail(txt_Email.Text))
                                            {
                                                try
                                                {
                                                    switch (mode)
                                                    {
                                                        case 0:
                                                            if (((BitmapImage)img_profile.Source).UriSource == null)
                                                            {
                                                                ioc.AddPeople(txt_Kennung.Text, txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
                                                            }
                                                            else
                                                            {
                                                                ioc.AddPeople(txt_Kennung.Text, ((BitmapImage)img_profile.Source).UriSource.ToString(), txt_Vorname.Text, txt_Nachname.Text, Convert.ToDateTime(txt_Geb.Text), txt_Strasse.Text, txt_PLZ.Text, txt_Ort.Text, txt_Tel.Text, txt_Email.Text);
                                                            }
                                                            break;
                                                        case 2: if(((BitmapImage)img_profile.Source).UriSource == null)
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
                                                catch
                                                {
                                                }
                                                txt_Email.Background = Brushes.White;
                                            }
                                            else
                                            {
                                                txt_Email.Background = Brushes.Red;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            SwitchMode(1);
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
