using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Geburtstagskalender
{
    public class IOC
    {
        private DBC dbc = new DBC();
        public ObservableCollection<Person> CollOfPeople = new ObservableCollection<Person>();
        public ObservableCollection<Person> CollOfBDays = new ObservableCollection<Person>();

        public ObservableCollection<Person> GetBDayToday()
        {
            ObservableCollection<Person> persons = new ObservableCollection<Person>();
            foreach (Person person in CollOfPeople)
            {
                if (person.Geburtstag.DayOfYear == DateTime.Today.DayOfYear)
                {
                    persons.Add(person);
                }
            }
            return persons;
        }

        public List<Person> SearchPeople(string searchTxt)
        {
            List<Person> people = new List<Person>();
            foreach (Person person in CollOfPeople)
            {
                if (person.Vorname.ToLower().Contains(searchTxt.ToLower()) ||
                    person.Nachname.ToLower().Contains(searchTxt.ToLower()) ||
                    person.Kennung.ToLower().Contains(searchTxt.ToLower()) ||
                    person.Strasse.ToLower().Contains(searchTxt.ToLower()) ||
                    person.PLZ.ToLower().Contains(searchTxt.ToLower()) ||
                    person.Ort.ToLower().Contains(searchTxt.ToLower()) ||
                    person.TelNr.ToLower().Contains(searchTxt.ToLower()) ||
                    person.Email.ToLower().Contains(searchTxt.ToLower()))
                {
                    people.Add(person);
                }
            }
            return people;
        }

        public void GetPeople()
        {
            CollOfPeople = dbc.GetPeople();
        }

        public void SafePeople()
        {
            dbc.SafePeople(CollOfPeople);
        }

        public void AddPeople(string Kennung, string ImgFilePath, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            CollOfPeople.Add(new Person(Kennung, ImgFilePath, Vorname, Nachname, Geburtstag, Strasse, PLZ, Ort, TelNr, Email));
            this.SafePeople();
            this.GetBDays();
        }
        public void AddPeople(string Kennung, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            CollOfPeople.Add(new Person(Kennung, Vorname, Nachname, Geburtstag, Strasse, PLZ, Ort, TelNr, Email));
            this.SafePeople();
            this.GetBDays();
        }

        public void ChangePeople(string Kennung, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            foreach (Person person in CollOfPeople)
            {
                if (person.Kennung == Kennung)
                {
                    person.Kennung = Kennung;
                    person.Vorname = Vorname;
                    person.Nachname = Nachname;
                    person.Geburtstag = Geburtstag;

                    person.Strasse = Strasse;
                    person.PLZ = PLZ;
                    person.Ort = Ort;
                    person.TelNr = TelNr;
                    person.Email = Email;
                    break;
                }
            }
            this.SafePeople();
            this.GetBDays();
        }
        public void ChangePeople(string Kennung, string ImgFilePath, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            foreach (Person person in CollOfPeople)
            {
                if (person.Kennung == Kennung)
                {
                    person.Kennung = Kennung;
                    person.ImgFilePath = ImgFilePath;
                    person.Vorname = Vorname;
                    person.Nachname = Nachname;
                    person.Geburtstag = Geburtstag;

                    person.Strasse = Strasse;
                    person.PLZ = PLZ;
                    person.Ort = Ort;
                    person.TelNr = TelNr;
                    person.Email = Email;
                    break;
                }
            }
            this.SafePeople();
            this.GetBDays();
        }

        public void GetBDays()
        {
            Person[] tmp = new Person[CollOfPeople.Count()];
            CollOfPeople.CopyTo(tmp, 0);
            List<Person> tmp2 = tmp.ToList();
            List<Person> tmp3 = tmp2.OrderBy(a => a.Geburtstag.DayOfYear).ToList();
            CollOfBDays.Clear();
            try
            {
                for (int i = 0; i < tmp3.Count(); i++)
                {
                    if (tmp3[i].Geburtstag.DayOfYear > DateTime.Today.DayOfYear)
                    {
                        CollOfBDays.Add(tmp3[i]);
                        tmp3.RemoveAt(i);
                    }
                }
                if (CollOfBDays.Count() < 5)
                {
                    for (int i = 0; CollOfBDays.Count() < 5; i++)
                    {
                        CollOfBDays.Add(tmp[i]);
                        tmp3.RemoveAt(i);
                    }
                }
            }
            catch { }
        }

        public bool CheckEmail(string a)
        {
            string[] b, c;
            try
            {
                b = a.Split('@');
                c = b[1].Split('.');
            }
            catch
            {
                return false;
            }
            if (b.Length == 2 && c.Length == 2)
            {
                if (b[0] != "" && b[1] != "" && c[1] != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
