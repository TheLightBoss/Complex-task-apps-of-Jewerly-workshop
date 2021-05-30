using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ExamplePG_Manager.Models;
using ExamplePG_Manager.View;
using Newtonsoft.Json;

namespace ExamplePG_Manager
{
    
    public partial class Form1 : Form
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;
        String url = "https://b3f48d32d3a6.ngrok.io/Home/";

        DataRow[] dataRow; // (работаем через это) 
        DataTable dataTable; // данные таблицы Izdeli_Spr
        DataTable dataTable_rabota; 
        DataTable dataTable_tip_izd;
        DataTable dataTable_mats;
        int numSelectedIzd = 0;
        int numSelectedSotr = 0;
        List<int> id_izd = new List<int>();

        List<ZakazNew> zakazs_sNew = new List<ZakazNew>();// новые, которые нужно распределить
        List<ZakazGotov> zakazs_sGotov = new List<ZakazGotov>();// готовые заказы
        List<ZakazInProc> zakazs_sInProc = new List<ZakazInProc>();//заказы, которые выполняются

        public static List<Masters> masters1 = new List<Masters>();
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
            Fill_Masters();
            Fill_ZakazNew();
            radioButton_newZakaz_CheckedChanged(sender, e);
            Fill_ZakazInProc();
            Fill_ZakazGotov();
        }
        void Fill_ZakazGotov()
        {

            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM zakazsgotov";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        zakazs_sGotov.Add(new ZakazGotov()
                        {
                            Date_zak = (DateTime)dataReader["date_zak"],
                            Id_izd = (int)dataReader["id_izd"],
                            Name_izd = (string)dataReader["name_izd"],
                            Phone = (string)dataReader["PhoneNumber"],
                            Price_izd = Convert.ToDouble(dataReader["price_izd"]),
                            UserName = (string)dataReader["UserName"]
                        });

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }// готовые
        void Fill_ZakazNew()
        {

            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM zakazsnew";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        zakazs_sNew.Add(new ZakazNew()
                        {
                            Date_zak = (DateTime)dataReader["date_zak"],
                            Id_izd = (int)dataReader["id_izd"],
                            Name_izd = (string)dataReader["name_izd"],
                            Phone = (string)dataReader["PhoneNumber"],
                            Price_izd = Convert.ToDouble(dataReader["price_izd"]),
                            UserName = (string)dataReader["UserName"]
                        });

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }// новые, которые нужно распределить
        void Fill_ZakazInProc()
        {

            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM zakazsinproc";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        zakazs_sInProc.Add(new ZakazInProc()
                        {
                            Date_zak = (DateTime)dataReader["date_zak"],
                            Id_izd = (int)dataReader["id_izd"],
                            Name_izd = (string)dataReader["name_izd"],
                            Phone = (string)dataReader["PhoneNumber"],
                            Price_izd = Convert.ToDouble(dataReader["price_izd"]),
                            UserName = (string)dataReader["UserName"],
                            Polu_Status = (bool)dataReader["polu_status"]
                        });

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        } //заказы, которые выполняются
        void Fill_Masters()
        {
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM sotrudnik";
                    masters1 = new List<Masters>();
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        masters1.Add(new Masters()
                        {
                            Address = (string)dataReader["address"],
                            Fio = (string)dataReader["fio"],
                            IdMaster = (int)dataReader["id_sotr"],
                            Login = (string)dataReader["login"],
                            Passport = (string)dataReader["passport"],
                            Password = (string)dataReader["password"],
                            Stag = (short)dataReader["stag"]
                        });

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // подгрузка сотрудников
            }
            Fill_Master();
        } // подгружаем сотрудников
        void Fill_Master()
        {
            textBox_address.Text = masters1[numSelectedSotr].Address;
            textBox_fio.Text = masters1[numSelectedSotr].Fio;
            textBox_login.Text = masters1[numSelectedSotr].Login;
            textBox_password.Text = masters1[numSelectedSotr].Password;
            numericUpDown_Stag.Value = masters1[numSelectedSotr].Stag;
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
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // подгрузка изделий 
            }
        }
        private void radioButton_newZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach (var i in zakazs_sNew)
            {
                int k = dgv_ZakazMain.Rows.Add();
                dgv_ZakazMain.Rows[k].Cells[0].Value = i.Id_izd;
                dgv_ZakazMain.Rows[k].Cells[1].Value = i.Date_zak.ToShortDateString();
                dgv_ZakazMain.Rows[k].Cells[2].Value = i.Name_izd;
                dgv_ZakazMain.Rows[k].Cells[3].Value = i.UserName;
                dgv_ZakazMain.Rows[k].Cells[4].Value = i.Phone;
                dgv_ZakazMain.Rows[k].Cells[5].Value = i.Price_izd;
            }
        } //подгружает новые заказы

        private void radioButton_loadZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach (var i in zakazs_sInProc)
            {
                int k = dgv_ZakazMain.Rows.Add(); 
                dgv_ZakazMain.Rows[k].Cells[0].Value = i.Id_izd;
                dgv_ZakazMain.Rows[k].Cells[1].Value = i.Date_zak.ToShortDateString();
                dgv_ZakazMain.Rows[k].Cells[2].Value = i.Name_izd;
                dgv_ZakazMain.Rows[k].Cells[3].Value = i.UserName;
                dgv_ZakazMain.Rows[k].Cells[4].Value = i.Phone;
                dgv_ZakazMain.Rows[k].Cells[5].Value = i.Price_izd;
            }
        } //подгружает выполняющиеся заказы

        private void radioButton_readyZakaz_CheckedChanged(object sender, EventArgs e)
        {
            dgv_ZakazMain.Rows.Clear();
            foreach(var i in zakazs_sGotov)
            {
                int k = dgv_ZakazMain.Rows.Add();
                dgv_ZakazMain.Rows[k].Cells[0].Value = i.Id_izd;
                dgv_ZakazMain.Rows[k].Cells[1].Value = i.Date_zak.ToShortDateString();
                dgv_ZakazMain.Rows[k].Cells[2].Value = i.Name_izd;
                dgv_ZakazMain.Rows[k].Cells[3].Value = i.UserName;
                dgv_ZakazMain.Rows[k].Cells[4].Value = i.Phone;
                dgv_ZakazMain.Rows[k].Cells[5].Value = i.Price_izd;
            }
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
            if (radioButton_newZakaz.Checked)
            {
                string index = dgv_ZakazMain.SelectedRows[0].Cells[0].Value.ToString();// с помощью этого свойства получаем id_izd в выбранной строке 
                Form_Masters masters = new Form_Masters(index);
                Hide();
                masters.ShowDialog();
                radioButton_newZakaz_CheckedChanged(sender, e);
                Show();
            }

        } // выбираем нужный заказ и переходим на форму выбора мастера

        private void textBox_nameIzd_Click(object sender, EventArgs e)
        {
            FormURL formURL = new FormURL(textBox_nameIzd.Text);
            formURL.ShowDialog();
            textBox_nameIzd.Text = formURL.text;
            formURL.Close();
        } // окно для изменения больших текстов

        private void button_upmaster_Click(object sender, EventArgs e)
        {
            if (numSelectedSotr + 1 < masters1.Count)
            {
                numSelectedSotr++;
                Fill_Master();
            }
            else
            {
                MessageBox.Show("Это последний сотрудник.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button_downmaster_Click(object sender, EventArgs e)
        {
            if (numSelectedSotr - 1 >= 0)
            {
                numSelectedSotr--;
                Fill_Master();
            }
            else
            {
                MessageBox.Show("Это первый сотрудник.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // для прохода по сотрудникам

        private async void button_savemaster_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            Masters m = new Masters()
            {
                Address = textBox_address.Text,
                Fio = textBox_fio.Text,
                IdMaster = masters1[numSelectedSotr].IdMaster,
                Login = textBox_login.Text,
                Passport = textBox_password.Text,
                Password = textBox_password.Text,
                Stag = (short)numericUpDown_Stag.Value
            };

            string ss = JsonConvert.SerializeObject(m);
            Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"s", ss }// название переменной в контроллере сервера и второе то что посылаем туда
                };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url + "UpdateMaster", form);
            
            string result = await responseMessage.Content.ReadAsStringAsync();
            try
            {
                masters1[numSelectedSotr] = JsonConvert.DeserializeObject<Masters>(result);
                Fill_Master();
                MessageBox.Show("Данные успешно изменены.", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //внести изменения 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // сохраняем изменения данных у сотрудника

        private void button_addmaster_Click(object sender, EventArgs e)
        {

        } //добавляем нового сотрудника






        // с помщью методов ниже изменяем размеры окна для удобной работы
        private void tabPage_izdSpr_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1021, 679);
            tabControl1.Size = new System.Drawing.Size(961, 571);
            tabControl_Main.Size = new System.Drawing.Size(981, 616);
            tabPage_izdSpr.Size = new System.Drawing.Size(953, 538);
        }  // страница с изделиями

        private void tabPage_sotrudnik_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(495, 610);
            tabControl_Main.Size = new System.Drawing.Size(462, 549);
        } //страница с сотрудниками

        private void tabPage_Zakazs_Enter(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1021, 679);
            tabControl_Main.Size = new System.Drawing.Size(981, 616);
        }// главная форма для заказов

        private void tabPage2_Enter_1(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(743, 503);
            tabControl1.Size = new System.Drawing.Size(682, 380);
            tabControl_Main.Size = new System.Drawing.Size(706, 441);
        }// страница с материалами

        private void tabPage_DataMain_Enter(object sender, EventArgs e)
        {
            tabPage2_Enter_1(sender, e);
        } // для страницы с материалами

    }
}
