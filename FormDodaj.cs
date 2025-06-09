
using System;
using System.Windows.Forms;

namespace ProjektPracownicy
{
    public partial class FormDodaj : Form
    {
        public string Imie => txtImie.Text;
        public string Nazwisko => txtNazwisko.Text;
        public int Wiek => (int)nudWiek.Value;
        public string Stanowisko => cbStanowisko.SelectedItem.ToString();

        public FormDodaj()
        {
            InitializeComponent();
        }
    }
}
