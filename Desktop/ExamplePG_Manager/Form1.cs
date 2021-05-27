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
    
    public partial class Form1 : Form
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;

        DataRow[] dataRow; // (работаем через это) 
        DataTable dataTable; // данные таблицы Izdeli_Spr
        DataTable dataTable_rabota; 
        DataTable dataTable_tip_izd;
        DataTable dataTable_mats;
        int numSelectedIzd = 0;
        List<int> id_izd = new List<int>();

        List<Mats> mats = new List<Mats>();
        List<Bank> banks = new List<Bank>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jewerlyDataSet.izdelie_spr". При необходимости она может быть перемещена или удалена.
            //this.izdelie_sprTableAdapter.Fill(this.jewerlyDataSet.izdelie_spr);
            Fill();
        }

        void Fill()
        {
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM materials INNER JOIN bank on materials.id_bank = bank.id_bank";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    dvg_Mats.Rows.Clear();
                    while (dataReader.Read())
                    {
                        mats.Add(new Mats((int)dataReader["id_mater"], (string)dataReader["name_mater"],
                            Convert.ToDouble(dataReader["price_mater"]),(int)dataReader["id_bank"], (string)dataReader["url_mater"]));
                        banks.Add(new Bank((int)dataReader["id_bank"], (string)dataReader["name_bank"]));
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
                } // подгрузка таблицы с материалами
                try
                {
                    string cmd = "SELECT * FROM materials";
                    NpgsqlDataAdapter adapter_mats = new NpgsqlDataAdapter(cmd, connection);
                    dataTable_mats = new DataTable("materials");
                    adapter_mats.Fill(dataTable_mats);
                    DataRow[] dataRow_mats = dataTable_mats.Select("id_mater <= 21");
                    foreach (DataRow i in dataRow_mats) comboBox_mats.Items.Add(i["name_mater"]);

                    cmd = "SELECT * FROM tip_izd";
                    NpgsqlDataAdapter adapter_tip = new NpgsqlDataAdapter(cmd, connection);
                    dataTable_tip_izd = new DataTable("tip_izd");
                    adapter_tip.Fill(dataTable_tip_izd);
                    DataRow[] dataRow_tip_izd = dataTable_tip_izd.Select("");
                    foreach (DataRow i in dataRow_tip_izd) comboBox_tipIzd.Items.Add(i["name_tip_izd"]);

                    cmd = "SELECT * FROM rabota";
                    NpgsqlDataAdapter adapter_rabota = new NpgsqlDataAdapter(cmd, connection);
                    dataTable_rabota = new DataTable("rabota");
                    adapter_rabota.Fill(dataTable_rabota);
                    DataRow[] dataRow_rabota = dataTable_rabota.Select("");

                    cmd = "SELECT * FROM izdelie_spr";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd, connection);
                    dataTable = new DataTable("izdelie_spr");
                    adapter.Fill(dataTable);
                    dataRow = dataTable.Select("");
                    foreach (DataRow i in dataRow) id_izd.Add((int)i["id_izdspr"]);

                    textBox_nameIzd.Text = dataRow[id_izd[numSelectedIzd]]["name_izd"].ToString();
                    textBox_urlIzd.Text = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                    pictureBox_Izd.ImageLocation = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                    DataRow[] Row = dataTable.Select($"id_izdspr = {id_izd[numSelectedIzd]}");
                    string h = Row[0]["id_material"].ToString();
                    DataRow[] row_mats = dataTable_mats.Select($"id_mater = {h}");
                    h = Row[0]["id_tip_izd"].ToString();
                    DataRow[] row_tip_izd = dataTable_tip_izd.Select($"id_tip_izd = {h}");
                    comboBox_mats.SelectedItem = row_mats[0]["name_mater"];
                    comboBox_tipIzd.SelectedItem = row_tip_izd[0]["name_tip_izd"];
                    h = Row[0]["id_rabota"].ToString();
                    DataRow[] row_rabota = dataTable_rabota.Select($"id_rabota = {h}");
                    textBox_rabota.Clear();
                    String[] spisok = (String[])row_rabota[0]["spisok_rabot"];
                    foreach (string i in spisok) textBox_rabota.Text += i + ", \n";
                    textBox_nameweb.Text = dataRow[id_izd[numSelectedIzd]]["name_itm"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message, ex.Message, MessageBoxButtons.OK);
                } // подгрузка изделий 
            }
        }
        private void radioButton_newZakaz_CheckedChanged(object sender, EventArgs e)
        {
            //Form_Masters form_Masters = new Form_Masters();
            //form_Masters.Show();
        } //подгружает новые заказы

        private void radioButton_loadZakaz_CheckedChanged(object sender, EventArgs e)
        {

        } //подгружает выполняющиеся заказы

        private void radioButton_readyZakaz_CheckedChanged(object sender, EventArgs e)
        {

        } //подгружает выполненные заказы, которые нужно подготовить к доставке

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_AddMats addMats = new Form_AddMats();
            addMats.ShowDialog();
            Fill();
        } //добавление материала

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Form_SearchMats searchMats = new Form_SearchMats();
            searchMats.Show();
        } //поиск материала

        private void btn_down_Click(object sender, EventArgs e)
        {
            numSelectedIzd--;
            if (numSelectedIzd >= 0)
            {
                textBox_urlIzd.Text = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                textBox_nameIzd.Text = dataRow[id_izd[numSelectedIzd]]["name_izd"].ToString();
                pictureBox_Izd.ImageLocation = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                DataRow[] Row = dataTable.Select($"id_izdspr = {id_izd[numSelectedIzd]}");
                string h = Row[0]["id_material"].ToString();
                DataRow[] row_mats = dataTable_mats.Select($"id_mater = {h}");
                h = Row[0]["id_tip_izd"].ToString();
                DataRow[] row_tip_izd = dataTable_tip_izd.Select($"id_tip_izd = {h}");
                comboBox_mats.SelectedItem = row_mats[0]["name_mater"];
                comboBox_tipIzd.SelectedItem = row_tip_izd[0]["name_tip_izd"];
                h = Row[0]["id_rabota"].ToString();
                DataRow[] row_rabota = dataTable_rabota.Select($"id_rabota = {h}");
                textBox_rabota.Clear();
                String[] spisok = (String[])row_rabota[0]["spisok_rabot"];
                foreach (var i in spisok) textBox_rabota.Text += i + ", \n";
                textBox_nameweb.Text = dataRow[id_izd[numSelectedIzd]]["name_itm"].ToString();
            }
            else
            {
                MessageBox.Show("Это первый элемент.");
            }
        }  //переход вниз между изделиями

        private void btn_up_Click(object sender, EventArgs e)
        {
            numSelectedIzd++;
            if(numSelectedIzd < id_izd.Count-1)
            {
                textBox_urlIzd.Text = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                textBox_nameIzd.Text = dataRow[id_izd[numSelectedIzd]]["name_izd"].ToString();
                pictureBox_Izd.ImageLocation = dataRow[id_izd[numSelectedIzd]]["url_pic"].ToString();
                DataRow[] Row = dataTable.Select($"id_izdspr = {id_izd[numSelectedIzd]}");
                string h = Row[0]["id_material"].ToString();
                DataRow[] row_mats = dataTable_mats.Select($"id_mater = {h}");
                h = Row[0]["id_tip_izd"].ToString();
                DataRow[] row_tip_izd = dataTable_tip_izd.Select($"id_tip_izd = {h}");
                comboBox_mats.SelectedItem = row_mats[0]["name_mater"];
                comboBox_tipIzd.SelectedItem = row_tip_izd[0]["name_tip_izd"];
                h = Row[0]["id_rabota"].ToString();
                DataRow[] row_rabota = dataTable_rabota.Select($"id_rabota = {h}");
                textBox_rabota.Clear();
                String[] spisok = (String[])row_rabota[0]["spisok_rabot"];
                foreach (var i in spisok) textBox_rabota.Text += i + ", \n";
                textBox_nameweb.Text = dataRow[id_izd[numSelectedIzd]]["name_itm"].ToString();
            }
            else
            {
                MessageBox.Show("Это последний элемент.");
            }
        }  //переход вверх между изделиями

        private void textBox_urlIzd_Click(object sender, EventArgs e)
        {
            FormURL formURL = new FormURL(textBox_urlIzd.Text);
            formURL.ShowDialog();
            textBox_urlIzd.Text = formURL.text;
            formURL.Close();
        } //работа с url 

        private void dqv_ZakazMain_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form_Masters masters = new Form_Masters();
            string index = dqv_ZakazMain.SelectedRows[0].Cells[0].Value.ToString();// с помощью этого свойства проходимся по всем ячейкам в выбранной строке 
            // в данном случае берём первую ячейку
            for(int i=0; i<5; i++)
            {
                //ну тут крч пройдёмся по всем если надо, либо выберем одну крч придумаем как получить чисто id заказа и отправим его в след форму,
                //или как написал в класс Form_Masters.cs будем передовать ссылку на объект класса,
                //хотя это залупка немного так как проще id передать да и процедуру там вызвать которая вставит всё
                //подумаем крч, главное щас понял как получать данные со строки на которую кликнул 
                //если что этот метод проверил уже на таблице с материалами 
                //удаляй пояснительные комменты такого рода как этот, те которые к определённым строчкам кода оставляй,
                //всё-таки хочу сохранить эти комменты так как потом если надо будет че то юзать то с комментами всё проще вспомнить
            }
            Hide();
            masters.ShowDialog();
            Show();
        } // выбираем нужный заказ и переходим на форму выбора мастера

        private void textBox_nameIzd_Click(object sender, EventArgs e)
        {
            FormURL formURL = new FormURL(textBox_nameIzd.Text);
            formURL.ShowDialog();
            textBox_nameIzd.Text = formURL.text;
            formURL.Close();
        }
    }
}
