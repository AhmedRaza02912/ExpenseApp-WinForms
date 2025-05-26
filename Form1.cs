using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ExpenseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = "server=localhost; database=ExpenseApp; user=root; password=ahmed.austin;";



        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to MySQL successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AmountTbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtDate.Text) ||
                cmbPaymentVia.SelectedIndex == -1 || cmbCategory.SelectedIndex == -1 ||
                cmbYear.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int amount;
            int date;

            // Ensure amount and date are valid integers
            if (!int.TryParse(txtAmount.Text, out amount) || !int.TryParse(txtDate.Text, out date))
            {
                MessageBox.Show("Amount and Date must be valid numbers.You entered at least one of them wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get values from comboBoxes
            string paymentVia = cmbPaymentVia.SelectedItem.ToString();
            string category = cmbCategory.SelectedItem.ToString();
            string year = cmbYear.SelectedItem.ToString();
            string month = cmbMonth.SelectedItem.ToString();

            // Insert data into MySQL database
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Expenses (Amount, Category, Date, Month, Year, Payment_Via) VALUES (@amount, @category, @date, @month, @year, @paymentVia)";

                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@paymentVia", paymentVia);
                        MessageBox.Show("INSERT INTO Expenses VALUES (" + amount + ", '" + category + "', " + date + ", '" + month + "', '" + year + "', '" + paymentVia + "')");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after successful insertion
                txtAmount.Clear();
                txtDate.Clear();
                cmbPaymentVia.SelectedIndex = -1;
                cmbCategory.SelectedIndex = -1;
                cmbYear.SelectedIndex = -1;
                cmbMonth.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

