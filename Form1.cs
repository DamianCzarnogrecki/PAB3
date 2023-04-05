using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PAB3
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source =.; Initial Catalog = PAB; Integrated Security = True; TrustServerCertificate = True";

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

        private async void button1_Click(object sender, EventArgs e)
        {
            string kod = textbox_kod.Text;
            string adres = textbox_adres.Text;
            string miejscowosc = textbox_miejscowosc.Text;
            string wojewodztwo = textbox_wojewodztwo.Text;
            string powiat = textbox_powiat.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var dane = await connection.QueryAsync
                    ($"SELECT * FROM Kody_Pocztowe WHERE Kod_Pocztowy LIKE '%{kod}%' AND Adres LIKE '%{adres}%' AND Miejscowosc LIKE '%{miejscowosc}%' AND Wojewodztwo LIKE '%{wojewodztwo}%' AND Powiat LIKE '%{powiat}%'");
                dataGridView1.DataSource = dane;
            }
        }
    }
}