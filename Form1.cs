using Microsoft.Data.SqlClient;
using System.Data;

namespace PAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTables();
        }

        public async void LoadTables()
        {
            string connectionString = "Data Source =.; Initial Catalog = PAB; Integrated Security = True; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM Kody_Pocztowe";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        await Task.Run(() => adapter.Fill(dataSet));
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }
    }
}