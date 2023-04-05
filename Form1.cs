using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace PAB3
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source =.; Initial Catalog = PAB; Integrated Security = True; TrustServerCertificate = True";
        string kod, adres, miejscowosc, wojewodztwo, powiat;

        public Form1()
        {
            InitializeComponent();
            LoadTables();
        }

        public async void LoadTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var dane = await connection.QueryAsync("SELECT * FROM Kody_Pocztowe");
                dataGridView1.DataSource = dane;
            }
        }

        public void ReadText()
        {
            kod = textbox_kod.Text;
            adres = textbox_adres.Text;
            miejscowosc = textbox_miejscowosc.Text;
            wojewodztwo = textbox_wojewodztwo.Text;
            powiat = textbox_powiat.Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ReadText();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var dane = await connection.QueryAsync
                    ($"SELECT * FROM Kody_Pocztowe WHERE Kod_Pocztowy LIKE '%{kod}%' AND Adres LIKE '%{adres}%' AND Miejscowosc LIKE '%{miejscowosc}%' AND Wojewodztwo LIKE '%{wojewodztwo}%' AND Powiat LIKE '%{powiat}%'");
                dataGridView1.DataSource = dane;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ReadText();

            using (var kontekst = new Kontekst(connectionString))
            {
                var dane = await kontekst.KodyPocztowe.Where(kod => kod.Kod_Pocztowy.Contains(this.kod) && kod.Adres.Contains(adres) && kod.Miejscowosc.Contains(miejscowosc) && kod.Wojewodztwo.Contains(wojewodztwo) && kod.Powiat.Contains(powiat)).ToListAsync();
                dataGridView1.DataSource = dane;
            }
        }
    }
}