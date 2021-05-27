using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ExamplePG_Manager.Models;

namespace ExamplePG_Manager
{
    public partial class Form_AddMats : Form
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;
        List<Bank> banks = new List<Bank>(); 
        public Form_AddMats()
        {
            InitializeComponent();
            Fill_ComboBox();

        }
        void Fill_ComboBox()
        {
            using (connection = new NpgsqlConnection(connectionStr))
            {
                
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM bank";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        banks.Add(new Bank((int)reader["id_bank"], (string)reader["name_bank"]));
                        comboBox_Banks.Items.Add((string)reader["name_bank"]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string bank_id = "";
                    foreach (var i in banks)
                    {
                        if (i.Name == comboBox_Banks.Text)
                        {
                            bank_id = i.ID.ToString();
                            break;
                        }
                    }
                    string cmd = "INSERT INTO materials (name_mater, url_mater, price_mater, id_bank) VALUES('" +
                        textBox_Name.Text + "','" + textBox_url.Text + "'," + textBox_Price.Text + ", " + bank_id + ");";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Материал успешно добавлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK);
                }
            }
        }
    }
}
