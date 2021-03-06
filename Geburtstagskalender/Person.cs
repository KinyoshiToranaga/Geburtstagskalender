using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geburtstagskalender
{
    public class Person
    {
        //Methoden

        //Attribute
        #region Personlich
        private string kennung;

        public string Kennung
        {
            get { return kennung; }
            set { kennung = value; }
        }

        private string imgFilePath;

        public string ImgFilePath
        {
            get { return imgFilePath; }
            set { imgFilePath = value; }
        }


        private string vorname;

        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        private string nachname;

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        private DateTime geburtstag;

        public DateTime Geburtstag
        {
            get { return geburtstag; }
            set { geburtstag = value; }
        }
        #endregion Persönlich

        #region Adresse
        private string strasse;

        public string Strasse
        {
            get { return strasse; }
            set { strasse = value; }
        }

        private string plz;

        public string PLZ
        {
            get { return plz; }
            set { plz = value; }
        }

        private string ort;

        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }

        private string telNr;

        public string TelNr
        {
            get { return telNr; }
            set { telNr = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion Adresse

        //Konstruktoren
        public Person(string Kennung, string ImgFilePath, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            this.Kennung = Kennung;
            this.ImgFilePath = ImgFilePath;
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtstag = Geburtstag;

            this.Strasse = Strasse;
            this.PLZ = PLZ;
            this.Ort = Ort;
            this.TelNr = TelNr;
            this.Email = Email;
        }
        public Person(string Kennung, string Vorname, string Nachname, DateTime Geburtstag, string Strasse, string PLZ, string Ort, string TelNr, string Email)
        {
            this.Kennung = Kennung;
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtstag = Geburtstag;

            this.Strasse = Strasse;
            this.PLZ = PLZ;
            this.Ort = Ort;
            this.TelNr = TelNr;
            this.Email = Email;
        }
    }
}
