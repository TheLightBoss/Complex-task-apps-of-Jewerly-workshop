using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Npgsql;
using ExamplePG_Manager.Models;
using ExamplePG_Manager.View;
using Newtonsoft.Json;

namespace ExamplePG_Manager
{
    public partial class Form_Masters : Form
    {
        
        int selected_Index_Master = -1;
        List<Zakazs_Master> zakazs_s = new List<Zakazs_Master>();
        String url = "https://c9192a0a689d.ngrok.io/Home/";
        string id_izd;

        //создадим переменную в которую получим заказ, который присвоим выбранному мастеру

        public Form_Masters(string id)
        {
            InitializeComponent();
            this.id_izd = id;
        }

        private void Form_Masters_Load(object sender, EventArgs e)
        {
            FillZakazs();
            selected_Index_Master = 0;
            radioButton_Mast1.Text = Form1.masters1[0].Fio;
            radioButton_Mast2.Text = Form1.masters1[1].Fio;
            radioButton_Mast3.Text = Form1.masters1[2].Fio;
            radioButton_Mast1.Checked = true;
        }

        async void FillZakazs()
        {
            HttpClient client = new HttpClient();

            Dictionary<string, string> dict = new Dictionary<string, string>()
                    {
                        {"", "" }// название переменной в контроллере сервера и второе то что посылаем туда
                    };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url + "GetZakazsAll", form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            try
            {
                zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>(result);
                //внести изменения 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } //подгрузка мастеров и их загруженности (список изделий над которыми они работают)

        void Load_dataGrid()
        {
            if(selected_Index_Master == 0)
            {
                List<Zakazs_Master> zz = new List<Zakazs_Master>();
                foreach(var i in zakazs_s) if(i.Id_sotr == Form1.masters1[selected_Index_Master].IdMaster) zz.Add(i);
                dgv_mast3.Rows.Clear();
                dgv_mast2.Rows.Clear();
                dgv_mast1.Rows.Clear();
                foreach (var j in zz)
                {
                    int i = dgv_mast1.Rows.Add();
                    dgv_mast1.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast1.Rows[i].Cells[1].Value = j.Name_izd;
                    if (!j.Polu_status) { dgv_mast1.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast1.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                    else { dgv_mast1.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast1.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                }
            }
            if (selected_Index_Master == 1)
            {
                List<Zakazs_Master> zz = new List<Zakazs_Master>();
                foreach (var i in zakazs_s) if (i.Id_sotr == Form1.masters1[selected_Index_Master].IdMaster) zz.Add(i);
                dgv_mast3.Rows.Clear();
                dgv_mast2.Rows.Clear();
                dgv_mast1.Rows.Clear(); foreach (var j in zz)
                {
                    int i = dgv_mast2.Rows.Add();
                    dgv_mast2.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast2.Rows[i].Cells[1].Value = j.Name_izd;
                    if (!j.Polu_status) { dgv_mast2.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast2.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                    else { dgv_mast2.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast2.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                }
            }
            if (selected_Index_Master == 2)
            {
                List<Zakazs_Master> zz = new List<Zakazs_Master>();
                foreach (var i in zakazs_s) if (i.Id_sotr == Form1.masters1[selected_Index_Master].IdMaster) zz.Add(i);
                dgv_mast3.Rows.Clear();
                dgv_mast2.Rows.Clear();
                dgv_mast1.Rows.Clear();
                foreach (var j in zz)
                {
                    int i = dgv_mast3.Rows.Add();
                    dgv_mast3.Rows[i].Cells[0].Value = j.date_start;
                    dgv_mast3.Rows[i].Cells[1].Value = j.Name_izd;
                    if (!j.Polu_status) { dgv_mast3.Rows[i].Cells[2].Value = "Работа не начата"; dgv_mast3.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed; }
                    else { dgv_mast3.Rows[i].Cells[2].Value = "Выполняется"; dgv_mast3.Rows[i].Cells[2].Style.BackColor = Color.Yellow; }
                }
            }
        }


        private async void btn_Choice_Click(object sender, EventArgs e)
        {
            if (selected_Index_Master == -1)
            {
                MessageBox.Show("Не выбран мастер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HttpClient client = new HttpClient();

                ID_Master_Izd iD = new ID_Master_Izd() { Id_izd = Convert.ToInt32(id_izd), Id_sotr = Form1.masters1[selected_Index_Master].IdMaster };
                string s = JsonConvert.SerializeObject(iD);
                Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"s", s }// название переменной в контроллере сервера и второе то что посылаем туда
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
                HttpResponseMessage responseMessage = await client.PostAsync(url + "AddIzgot", form);

                string result = await responseMessage.Content.ReadAsStringAsync();
                try
                {
                    int i = JsonConvert.DeserializeObject<int>(result);
                    if (i==-1) throw new Exception("Операция не выполнена!");
                    MessageBox.Show("Заказ успешно отправлен сотруднику.", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillZakazs();
                    radioButton_Mast1_CheckedChanged(sender, e);
                    radioButton_Mast2_CheckedChanged(sender, e);
                    radioButton_Mast3_CheckedChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //http запрос на добавление сотруднику нового заказа (создание строки в изготовлении и отправка её)
            }
            
        } //выбран сотрудник для нового заказа 

        private void radioButton_Mast1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast1.Checked)
            {
    
                selected_Index_Master = 0;
                Load_dataGrid();
            }
        }

        private void radioButton_Mast2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast2.Checked)
            {
  
                selected_Index_Master = 1;
                Load_dataGrid();
            }
        }

        private void radioButton_Mast3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mast3.Checked)
            {
             
                selected_Index_Master = 2;
                Load_dataGrid();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
