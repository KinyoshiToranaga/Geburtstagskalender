using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace Geburtstagskalender
{
    class DBC
    {
        //private static string directorypath = "C:\\" + System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        //private static string filepath = directorypath + "\\kalender.csv";
        private static string filepath = AppDomain.CurrentDomain.BaseDirectory + "kalender.csv";
        private StreamReader reader;
        private StreamWriter writer;

        //Methoden
        public ObservableCollection<Person> GetPeople()
        {
            ObservableCollection<Person> ListOfPeople = new ObservableCollection<Person>();
            if (File.Exists(filepath))
            {
                reader = new StreamReader(filepath);
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string[] tmp = reader.ReadLine().Split(';');
                        if (tmp.Length < 10)
                        {
                            ListOfPeople.Add(new Person(tmp[0], tmp[1], tmp[2], Convert.ToDateTime(tmp[3]), tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        }
                        else
                        {
                            ListOfPeople.Add(new Person(tmp[0], tmp[1], tmp[2], tmp[3], Convert.ToDateTime(tmp[4]), tmp[5], tmp[6], tmp[7], tmp[8], tmp[9]));
                        }
                    }
                    catch
                    {
                    }
                }
                reader.Close();
            }
            return ListOfPeople;
        }

        public void SafePeople(ObservableCollection<Person> people)
        {
            if (File.Exists(filepath))
            {
                using (writer = new StreamWriter(filepath))
                {
                    foreach (Person p in people)
                    {
                        if (p.ImgFilePath == null)
                        {
                            writer.WriteLine(p.Kennung + ";" +
                                p.Vorname + ";" +
                                p.Nachname + ";" +
                                p.Geburtstag + ";" +
                                p.Strasse + ";" +
                                p.PLZ + ";" +
                                p.Ort + ";" +
                                p.TelNr + ";" +
                                p.Email,
                                Encoding.Default);
                        }
                        else
                        {
                            writer.WriteLine(p.Kennung + ";" +
                                p.ImgFilePath + ";" +
                                p.Vorname + ";" +
                                p.Nachname + ";" +
                                p.Geburtstag + ";" +
                                p.Strasse + ";" +
                                p.PLZ + ";" +
                                p.Ort + ";" +
                                p.TelNr + ";" +
                                p.Email,
                                Encoding.Default);
                        }
                    }
                }
            }
        }
    }
}
