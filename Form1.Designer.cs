
namespace ProjektPracownicy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnOdczyt;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnOdczyt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(560, 300);
            this.dataGridView1.TabIndex = 0;

            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Location = new System.Drawing.Point(12, 320);
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);

            this.btnUsun.Text = "Usuń";
            this.btnUsun.Location = new System.Drawing.Point(100, 320);
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);

            this.btnZapisz.Text = "Zapisz do CSV";
            this.btnZapisz.Location = new System.Drawing.Point(188, 320);
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);

            this.btnOdczyt.Text = "Odczytaj z CSV";
            this.btnOdczyt.Location = new System.Drawing.Point(296, 320);
            this.btnOdczyt.Click += new System.EventHandler(this.btnOdczyt_Click);

            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnOdczyt);
            this.Text = "Arkusz Pracowników";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
