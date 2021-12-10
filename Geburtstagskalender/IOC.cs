using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Geburtstagskalender
{
    public class IOC
    {
        private DBC dbc = new DBC();
        public ObservableCollection<Person> CollOfPeople = new ObservableCollection<Person>();
        public ObservableCollection<Person> CollOfBDays = new ObservableCollection<Person>();

        public void GetPeople()
        {
            CollOfPeople = dbc.GetPeople();
        }

        public void SafePeople()
        {
            dbc.SafePeople(CollOfPeople);
        }

        public void AddPeople(string Kennung, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            CollOfPeople.Add(new Person(Kennung, Vorname, Nachname, Geburtstag, Strasse, PLZ, Ort, TelNr, Email));
            this.SafePeople();
            this.GetBDays();
        }

        public void GetBDays()
        {
            Person[] tmp = new Person[CollOfPeople.Count()];
            CollOfPeople.CopyTo(tmp, 0);
            List<Person> tmp2 = tmp.ToList();
            for (int i = 0; i < 5; i++)
            {
                if (tmp2.Count == 0)
                {
                    break;
                }
                CollOfBDays.Add(tmp2[0]);
                for (int j = 0; j < tmp2.Count; j++)
                {
                    if (CollOfBDays[i].Geburtstag > tmp2[j].Geburtstag)
                    {
                        CollOfBDays[i] = tmp2[j];
                    }
                }
                tmp2.Remove(CollOfBDays[i]);
            }
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

        public void Search(string searchTxt)
        {

        }
    }
}
