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
    public partial class Form_Masters : Form
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;
        DataRow[] dataRows_masters;
        int selected_Index_Master = -1; 
        List<int> index_masters;
        string cmd;

        //создадим переменную в которую получим заказ, который присвоим выбранному мастеру

        public Form_Masters(/* получаем заказ */)
        {
            InitializeComponent();
        }

        private void Form_Masters_Load(object sender, EventArgs e)
        {
            FillMasters();
        }

        void FillMasters()
        {
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    cmd = "SELECT * FROM sotrudnik";
                    NpgsqlDataAdapter adapter_masters = new NpgsqlDataAdapter(cmd, connection);
                    DataTable table_masters = new DataTable("sotrudnik");
                    adapter_masters.Fill(table_masters);
                    dataRows_masters = table_masters.Select();
                    List<string> vs = new List<string>();
                    index_masters = new List<int>();
                    foreach (DataRow i in dataRows_masters) 
                    {
                        index_masters.Add((int)i["id_sotr"]);
                        vs.Add(i["FIO"].ToString());
                    }
                    
                    radioButton_Mast1.Text = vs[0];
                    radioButton_Mast2.Text = vs[1];
                    radioButton_Mast3.Text = vs[2];

                    cmd = $"CALL zakazs_all();"; //вызов процедуры
                    NpgsqlDataAdapter adapter_izgotovlenie = new NpgsqlDataAdapter(cmd, connection);
                    DataTable table_izgotovlenie = new DataTable();
                    adapter_izgotovlenie.Fill(table_izgotovlenie);
                    DataRow[] rows_izg = table_izgotovlenie.Select($"id_sotr = {index_masters[0]}");
                    //добавляем в datagrid
                    foreach (DataRow i in rows_izg)
                    {
                       // dgv_mast2.Items.
                    }
                    rows_izg = table_izgotovlenie.Select($"id_sotr = {index_masters[1]}");
                    foreach (DataRow i in rows_izg)
                    {

                    }
                    rows_izg = table_izgotovlenie.Select($"id_sotr = {index_masters[2]}");
                    foreach (DataRow i in rows_izg)
                    {

                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message, ex.Message, MessageBoxButtons.OK);
                }
            }

        } //подгрузка мастеров и их загруженности (список изделий над которыми они работают)

        private void btn_Choice_Click(object sender, EventArgs e)
        {
            if (selected_Index_Master == -1)
            {
                MessageBox.Show("Ошибка", "Не выбран мастер", MessageBoxButtons.OK);
            }
            else
            {
                using (connection = new NpgsqlConnection(connectionStr))
                {
                    try
                    {
                        connection.Open();
                        // добавление 
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка" + ex.Message, ex.Message, MessageBoxButtons.OK);
                    }
                }
            }
            
        } //выбран сотрудник для нового заказа 

        private void radioButton_Mast1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast1.Checked)
            {
                selected_Index_Master = 0;
            }
        }

        private void radioButton_Mast2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast1.Checked)
            {
                selected_Index_Master = 1;
            }
        }

        private void radioButton_Mast3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast1.Checked)
            {
                selected_Index_Master = 2;
            }
        }
    }
}
