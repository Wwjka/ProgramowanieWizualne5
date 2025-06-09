
namespace ProjektPracownicy
{
    partial class FormDodaj
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.NumericUpDown nudWiek;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Button btnOk;

        private void InitializeComponent()
        {
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.nudWiek = new System.Windows.Forms.NumericUpDown();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWiek)).BeginInit();
            this.SuspendLayout();

            this.txtImie.Location = new System.Drawing.Point(12, 12);
            this.txtImie.PlaceholderText = "Imię";

            this.txtNazwisko.Location = new System.Drawing.Point(12, 42);
            this.txtNazwisko.PlaceholderText = "Nazwisko";

            this.nudWiek.Location = new System.Drawing.Point(12, 72);
            this.nudWiek.Minimum = 18;
            this.nudWiek.Maximum = 100;

            this.cbStanowisko.Location = new System.Drawing.Point(12, 102);
            this.cbStanowisko.Items.AddRange(new object[] { "Programista", "Księgowy", "Manager" });
            this.cbStanowisko.SelectedIndex = 0;

            this.btnOk.Location = new System.Drawing.Point(12, 132);
            this.btnOk.Text = "OK";
            this.btnOk.Click += (s, e) => this.DialogResult = DialogResult.OK;

            this.ClientSize = new System.Drawing.Size(200, 170);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.nudWiek);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.btnOk);
            this.Text = "Dodaj Pracownika";

            ((System.ComponentModel.ISupportInitialize)(this.nudWiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
