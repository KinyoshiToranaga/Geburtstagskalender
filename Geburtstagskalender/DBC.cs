using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Für StreamReader und StreamWriter
using System.Collections.ObjectModel;

namespace Geburtstagskalender
{
    class DBC
    {
        //DBC steht für DataBaseConnection für später wenn wir die Datenbank in das Projekt einbinden
        //Leute BITTE denkt euch einen eigenen Dateipfad aus! Das Ding ist zu kompliziert falls ihr gefragt werdet was ihr da gemacht habt!
        //Das doppelte Backslash ist übrigens um keine Escape-Sequenz zu machen wie z.B. "\n" was einen Zeilenumbruch darstellt
        private static string directorypath = "C:\\" + System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        private static string filepath = directorypath + "\\kalender.csv"; //Projektnamen in Dateipfad packen um Ordner mit Projektnamen zu erhalten(spart Zeit falls der Projektname geändert wird)
        //private static string filepath = @".\kalender.csv";
        private StreamReader reader;
        private StreamWriter writer;

        //Methoden
        public ObservableCollection<Person> GetPeople()
        {
            ObservableCollection<Person> ListOfPeople = new ObservableCollection<Person>();
            //ListOfPeople.Clear();
            //reader = new StreamReader(filepath);
            if (File.Exists(filepath))
            {
                reader = new StreamReader(filepath);
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string[] tmp = reader.ReadLine().Split(';');
                        ListOfPeople.Add(new Person(tmp[0], tmp[1], tmp[2], Convert.ToDateTime(tmp[3]), tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                    }
                    catch (Exception e)
                    {
                        var test = "";
                    }
                }
            }
            reader.Close();
            return ListOfPeople;
        }

        public void SafePeople(ObservableCollection<Person> people)
        {
            using (writer = new StreamWriter(filepath))
            {
                foreach (Person p in people)
                {
                    writer.WriteLine(p.Kennung + ";" + p.Vorname + ";" + p.Nachname + ";" + p.Geburtstag + ";" + p.Strasse + ";" + p.PLZ + ";" + p.Ort + ";" + p.TelNr + ";" + p.Email);
                }
            }
        }
    }
}
