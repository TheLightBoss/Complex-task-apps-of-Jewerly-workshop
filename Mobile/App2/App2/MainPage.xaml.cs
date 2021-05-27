using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;
using App2.Models;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static List<Zakazs_Master> zakazs_s;
        public static Masters master = new Masters();
        public static readonly HttpClient client = new HttpClient();
        public static String url = "";
        bool check;

        public MainPage()
        {
            InitializeComponent();
            this.Title = "Авторизация";
        }

        void CreateDB()
        {
            Directory.CreateDirectory("DB"); //создание папки для базы данных

            SQLiteConnection.CreateFile("DB\\TestDB.db"); // создать базу данных, по указанному пути содаётся пустой файл базы данных
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=DB\\TestDB.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                SQLiteCommand Command1 = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [MasterStr] ([master] STRING, [zakaz] STRING);", Connect);
                SQLiteCommand Command2 = new SQLiteCommand("INSERT INTO MasterStr(master, zakaz)" +
                    " VALUES('"+JsonConvert.SerializeObject(master)+"','"+JsonConvert.SerializeObject(zakazs_s)+"');", Connect);
                Connect.Open(); // открыть соединение
                Command1.ExecuteNonQuery(); // выполнить запрос
                Command2.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
            }
        }
        void SelectDB()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=DB\\TestDB.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                
                SQLiteCommand Command1 = new SQLiteCommand("SELECT * FROM MasterStr;", Connect);
                
                Connect.Open(); // открыть соединение
                SQLiteDataReader dataReader = Command1.ExecuteReader(); // выполнить запрос
                Connect.Close(); // закрыть соединение
                while (dataReader.Read())
                {
                    master = JsonConvert.DeserializeObject<Masters>((string)dataReader["master"]);
                    zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>((string)dataReader["zakaz"]);
                }
            }
        }
        async void Load_Masters()
        {
            url = "https://d6ed45d394a5.ngrok.io/Home/GetMaster";
            string ss = JsonConvert.SerializeObject(master);
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"s", ss }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url, form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            EntryLogin.Text = result;
            try
            {
                master = JsonConvert.DeserializeObject<Masters>(result);
                check = true;
            }
            catch
            {
                await DisplayAlert("Неверно введён логин или пароль!", "Ошибка", "OK");
                check = false;
            }
        } //подгрузка данных через api, если нет бд GetMasters(string s)

        async void Load_Data()
        {
            url = "https://737b5fff7b2c.ngrok.io/Home/GetZakazs";
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"id_mast" , master.IdMaster.ToString() }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url, form);

            string result = await responseMessage.Content.ReadAsStringAsync();

            try
            {
                zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>(result);
            }
            catch
            {
                await DisplayAlert("На данный аккаунт нет заказов!", "Заказов нет", "OK");
            }


        } //подгрузка данных через api, если нет бд GetZakazs(string id_mast)

        private async void Button_Click(object sender, EventArgs e)
        {
            /*
            url = "https://deb26e421be3.ngrok.io/Home/Ky";
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"", "" }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url, form);

            string result = await responseMessage.Content.ReadAsStringAsync();

            Masters masters = JsonConvert.DeserializeObject<Masters>(result);
            EntryLogin.Text = masters.Fio + masters.Address + masters.Login + masters.Password;
            */
            
            if (!File.Exists("DB\\TestDB.db")) // если базы данных нету, то подгружаем мастеров, потом проверяем и загружаем их заказы, создаём бд
            {
                master.Login = EntryLogin.Text;
                master.Password = EntryPassword.Text;
                Load_Masters();
                if (check)
                {
                    Load_Data();
                    CreateDB();
                    await Navigation.PushAsync(new Page1());
                }
            }
            else //если есть бд, то запрос селект 
            {
                SelectDB();
                await Navigation.PushAsync(new Page1());
            }


        }
    }
}
