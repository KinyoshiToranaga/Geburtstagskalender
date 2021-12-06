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
        //List<Person> ListOfPeople = new List<Person>();
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

        public void AddPeople(string Kennung, string Vorname, string Nachname, DateTime Geburtstag, string PLZ, string Ort, string TelNr, string Email)
        {
            CollOfPeople.Add(new Person(Kennung, Vorname, Nachname, Geburtstag, PLZ, Ort, TelNr, Email));
            this.SafePeople();
        }
    }
}
