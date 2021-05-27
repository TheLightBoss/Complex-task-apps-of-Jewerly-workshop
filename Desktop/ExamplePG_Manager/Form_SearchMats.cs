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
using ExamplePG_Manager.View;
using ExamplePG_Manager.Models;

namespace ExamplePG_Manager
{
    public partial class Form_SearchMats : Form
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;
        List<Mats_Bank> mats_Banks = new List<Mats_Bank>();
        List<Bank> banks = new List<Bank>();
        public Form_SearchMats()
        {
            InitializeComponent();
        }

        private void Form_SearchMats_Load(object sender, EventArgs e)
        {
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

        private void btn_Find_Click(object sender, EventArgs e)
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
                    string cmd = "SELECT * FROM materials INNER JOIN bank on materials.id_bank = bank.id_bank WHERE materials.id_bank = "
                        + bank_id + "and materials.name_mater like '" + textBox_name.Text + "%'";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    dvg_Mats.Rows.Clear();
                    while(dataReader.Read())
                    {
                        mats_Banks.Add(new Mats_Bank((string)dataReader["name_mater"], 
                            Convert.ToDouble(dataReader["price_mater"]), (string)dataReader["name_bank"], (string)dataReader["url_mater"]));
                        int i = dvg_Mats.Rows.Add();
                        dvg_Mats.Rows[i].Cells[0].Value = (string)dataReader["name_mater"];
                        dvg_Mats.Rows[i].Cells[1].Value = (string)dataReader["url_mater"];
                        dvg_Mats.Rows[i].Cells[2].Value = dataReader["price_mater"];
                        dvg_Mats.Rows[i].Cells[3].Value = (string)dataReader["name_bank"];
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK);
                }
            }
        }
    }
}
