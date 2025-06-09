
using System;
using System.Xml.Serialization;

namespace ProjektPracownicy
{
    [Serializable]
    public class Osoba
    {
        public int ID { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }

        public Osoba() { }

        public Osoba(int id, string imie, string nazwisko, int wiek, string stanowisko)
        {
            ID = id;
            Imię = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Stanowisko = stanowisko;
        }
    }
}
