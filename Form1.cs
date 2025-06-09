
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjektPracownicy
{
    public partial class Form1 : Form
    {
        private DataTable tabelaPracownikow = new DataTable();
        private int nastepneId = 1;

        public Form1()
        {
            InitializeComponent();

            tabelaPracownikow.Columns.Add("ID", typeof(int));
            tabelaPracownikow.Columns.Add("Imię", typeof(string));
            tabelaPracownikow.Columns.Add("Nazwisko", typeof(string));
            tabelaPracownikow.Columns.Add("Wiek", typeof(int));
            tabelaPracownikow.Columns.Add("Stanowisko", typeof(string));

            dataGridView1.DataSource = tabelaPracownikow;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var oknoDodaj = new FormDodaj();
            if (oknoDodaj.ShowDialog() == DialogResult.OK)
            {
                tabelaPracownikow.Rows.Add(nastepneId++, oknoDodaj.Imie, oknoDodaj.Nazwisko, oknoDodaj.Wiek, oknoDodaj.Stanowisko);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow wiersz in dataGridView1.SelectedRows)
                {
                    if (!wiersz.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(wiersz);
                    }
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Pliki CSV (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    sw.WriteLine("ID,Imię,Nazwisko,Wiek,Stanowisko");
                    foreach (DataRow row in tabelaPracownikow.Rows)
                    {
                        sw.WriteLine(string.Join(",", row.ItemArray.Select(x => $""{x}"")));
                    }
                }
            }
        }

        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki CSV (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tabelaPracownikow.Clear();
                var linie = File.ReadAllLines(dialog.FileName).Skip(1);
                foreach (var linia in linie)
                {
                    var pola = linia.Split(',').Select(p => p.Trim('"')).ToArray();
                    tabelaPracownikow.Rows.Add(int.Parse(pola[0]), pola[1], pola[2], int.Parse(pola[3]), pola[4]);
                    nastepneId = Math.Max(nastepneId, int.Parse(pola[0]) + 1);
                }
            }
        }
    }
}
