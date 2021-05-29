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
        public static List<Zakazs_Master> zakazs_s = new List<Zakazs_Master>();
        //public static List<Zakazs> zakazs = new List<Zakazs>();
        public static Masters master = new Masters();
        public static readonly HttpClient client = new HttpClient();
        public static String url = "https://6e6d055b3164.ngrok.io/Home/";
        //public static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Авторизация";
            
            /*if (File.Exists(Path.Combine(folder, "Master.db")))
            {
                SelectDB();
                Navig();
            }*/
        }
        protected async override void OnAppearing()
        {
            object m = "";
            if (Application.Current.Properties.TryGetValue("master", out m) && Application.Current.Properties.TryGetValue("zakazs", out m))
            {
#pragma warning disable CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                if (Application.Current.Properties["master"] != "" && Application.Current.Properties["zakazs"] != "")
#pragma warning restore CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                {
                    master = JsonConvert.DeserializeObject<Masters>((string)Application.Current.Properties["master"]);//получаем строку мастера и возвращаем к Masters
                    zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>((string)Application.Current.Properties["zakazs"]);
                    await Navigation.PushAsync(new Page1()); // отправляем к заказам 

                }
#pragma warning disable CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                if (Application.Current.Properties["master"] != "" && Application.Current.Properties["zakazs"] == "")
#pragma warning restore CS0252 // Возможно, использовано непреднамеренное сравнение ссылок: для левой стороны требуется приведение
                {
                    master = JsonConvert.DeserializeObject<Masters>((string)Application.Current.Properties["master"]);//получаем строку мастера и возвращаем к Masters
                    await Navigation.PushAsync(new Master_Page()); //отправляем на форму сотрудника (его данные для редактирования)
                }
            }
            
        } //при подзрузке проверяем, если есть данные, берём их и отправляем на Page1 для дальнейшей работы
    
        void CreateDB()
        {
            /*
            Directory.CreateDirectory(Path.Combine(folder, "Master.db"));
            //SQLiteConnection.CreateFile("Master.db"); // создать базу данных, по указанному пути содаётся пустой файл базы данных
            
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source= " + Path.Combine(folder, "Master.db"))) // в строке указывается к какой базе подключаемся
            {
                Connect.Open(); // открыть соединение
                SQLiteCommand Command1 = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [MasterStr] ([master] STRING, [zakaz] STRING);", Connect);
                string zak = "";
                try
                {
                    zak = JsonConvert.SerializeObject(zakazs_s);
                }
                catch
                {
                    zak = "";
                    zakazs_s = null;
                }
                SQLiteCommand Command2 = new SQLiteCommand("INSERT INTO MasterStr(master, zakaz)" +
                    " VALUES('"+JsonConvert.SerializeObject(master)+"','"+zak+"');", Connect);
                SQLiteCommand Command3 = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [Zakazs](Id_izd       INTEGER,rabota_1  STRING, rabota_1stat BOOLEAN,rabota_2     STRING,rabota_2stat BOOLEAN,rabota_3     STRING,rabota_3stat BOOLEAN,rabota_4     STRING,rabota_4stat BOOLEAN); ", Connect);
                Command1.ExecuteNonQuery(); // выполнить запрос
                Command2.ExecuteNonQuery(); // выполнить запрос
                Command3.ExecuteNonQuery();
                if (zakazs_s != null)
                {
                    foreach (Zakazs_Master i in zakazs_s)
                    {
                        if (i.Spisok_rabot.Length == 4)
                        {
                            SQLiteCommand Command4 = new SQLiteCommand("INSERT INTO Zakazs (Id_izd,rabota_1,rabota_1stat,rabota_2,rabota_2stat,rabota_3,rabota_3stat,rabota_4,rabota_4stat)" +
                            $" VALUES({i.Id_izd},'" + i.Spisok_rabot[0] + "'," + false + ",'" + i.Spisok_rabot[1] + "'," + false + ",'" + i.Spisok_rabot[2] + "'," + false + ",'" + i.Spisok_rabot[3] + "'," + false + "); ", Connect);
                            Command4.ExecuteNonQuery();
                        }
                        else
                        {
                            SQLiteCommand Command4 = new SQLiteCommand("INSERT INTO Zakazs (Id_izd,rabota_1,rabota_1stat,rabota_2,rabota_2stat,rabota_3,rabota_3stat,rabota_4,rabota_4stat)" +
                            $" VALUES({i.Id_izd},'" + i.Spisok_rabot[0] + "'," + false + ",'" + i.Spisok_rabot[1] + "'," + false + ",'" + i.Spisok_rabot[2] + "'," + false + ",''," + false + "); ", Connect);
                            Command4.ExecuteNonQuery();
                        }
                    }
                }
                Connect.Close(); // закрыть соединение
            }*/
        } // попытка создать дб
        void SelectDB()
        {
            /*
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source= "+Path.Combine(folder, "Master.db"))) // в строке указывается к какой базе подключаемся
            {
                
                SQLiteCommand Command1 = new SQLiteCommand("SELECT * FROM MasterStr;", Connect);
                SQLiteCommand Command2 = new SQLiteCommand("SELECT * FROM Zakazs;", Connect);
                Connect.Open(); // открыть соединение
                SQLiteDataReader dataReader1 = Command1.ExecuteReader(); // выполнить запрос
                while (dataReader1.Read())
                {
                    master = JsonConvert.DeserializeObject<Masters>((string)dataReader1["master"]);
                    try
                    {
                        zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>((string)dataReader1["zakaz"]);
                    }
                    catch
                    {
                        zakazs_s = null;
                    }
                }

                SQLiteDataReader dataReader2 = Command2.ExecuteReader(); // выполнить запрос

                while (dataReader2.Read())
                {
                    zakazs.Add(new Zakazs()
                    {
                        Id_izd = (int)dataReader2["Id_izd"],
                        rabota_1 = (string)dataReader2["rabota_1"],
                        rabota_1stat = (bool)dataReader2["rabota_1stat"],
                        rabota_2 = (string)dataReader2["rabota_2"],
                        rabota_2stat = (bool)dataReader2["rabota_2stat"],
                        rabota_3 = (string)dataReader2["rabota_3"],
                        rabota_3stat = (bool)dataReader2["rabota_3stat"],
                        rabota_4 = (string)dataReader2["rabota_4"],
                        rabota_4stat = (bool)dataReader2["rabota_4stat"]
                    });
                }
                Connect.Close(); // закрыть соединение
            }*/
        } // попытка использовать дб

        void AddAppCurrProp()
        {
            Application.Current.Properties.Add("master",JsonConvert.SerializeObject(master));// сохраняем строку мастера по ключу master на устройстве
            Application.Current.Properties.Add("zakazs", JsonConvert.SerializeObject(zakazs_s));// сохраняем заказы мастера по ключу zakazs на устройстве
        } // сохраняем строки json

        async void Load_Masters()
        {
            string ss = JsonConvert.SerializeObject(master);
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"s", ss }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url+ "GetMaster", form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            
            try
            {
                master = JsonConvert.DeserializeObject<Masters>(result);
                if (master.IdMaster == 0) throw new Exception(); 
                else Load_Data();//если вернул мастера, то загружаем его заказы 
            }
            catch
            {
                EntryLogin.Text = "";
                EntryPassword.Text = "";
                await DisplayAlert("Ошибка", "Неверно введён логин или пароль!", "OK");
            }
        } //подгрузка данных через http-запрос

        async void Load_Data()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"id_mast" , master.IdMaster.ToString() }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url+ "GetZakazs", form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            //EntryLogin.Text = result;
            try
            {
                zakazs_s = JsonConvert.DeserializeObject<List<Zakazs_Master>>(result);
                if (zakazs_s.Count == 0) throw new Exception(); //если кол-во заказов 0, то ошибка,и далее работа пойдёт в catch
                //CreateDB();
                object m = "";
                if (Application.Current.Properties.TryGetValue("master", out m) && Application.Current.Properties.TryGetValue("zakazs", out m))
                    UpdateAppCurrProp(); //если есть то меняем
                else AddAppCurrProp(); //сохраняем строки json, если у мастера есть заказы на выполнение
                await Navigation.PushAsync(new Page1());
            }
            catch
            {
                zakazs_s = null;
                EntryLogin.Text = "";
                EntryPassword.Text = "";
                await DisplayAlert( "Заказов нет", "На данный аккаунт нет заказов!", "OK");
                await Navigation.PushAsync(new Master_Page()); //отправляем на форму сотрудника (его данные для редактирования)
            }

        } //подгрузка данных через http-запрос

        private async void Button_Click(object sender, EventArgs e)
        {
            if(EntryLogin.Text == null || EntryLogin.Text == "") await DisplayAlert("Ошибка", "Введите логин!", "OK");
            else if (EntryPassword.Text == null || EntryPassword.Text == "") await DisplayAlert("Ошибка", "Введите пароль!", "OK");
            else
            {
                master.Login = EntryLogin.Text;
                master.Password = EntryPassword.Text;
                Load_Masters();
            }
        } //при нажатии на кнопку Войти

        public static void DeleteAppCurrProp()
        {
            Application.Current.Properties["master"] = "";
            Application.Current.Properties["zakazs"] = ""; 
        } // удаляем строки json, так как пользователь вышел (нажал кнопку выйти)
          // то есть возможно он хочет зайти на другой аккаунт (другой сотрудник)

        public static void UpdateAppCurrProp()
        {
            Application.Current.Properties["master"] = JsonConvert.SerializeObject(master);
            Application.Current.Properties["zakazs"] = JsonConvert.SerializeObject(zakazs_s);
        } //при любом изменение данных в master или zakaz_s сохраняем эти изменения в App.Current.Properties
    }
}
