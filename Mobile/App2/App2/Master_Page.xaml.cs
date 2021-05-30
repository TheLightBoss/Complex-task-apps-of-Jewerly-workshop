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
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master_Page : ContentPage
    {
        public Master_Page()
        {
            InitializeComponent();
            Title = "Ваши данные";
            EntryFio.Text = MainPage.master.Fio;
            EntryPassport.Text = MainPage.master.Passport;
            EntryPassword.Text = MainPage.master.Password;
            EntryLogin.Text = MainPage.master.Login;
            EntryAddress.Text = MainPage.master.Address;
        }
        private async void Button_ClickUpdate(object sender, EventArgs e)
        {
            if (EntryLogin.Text == null || EntryLogin.Text == "" ) await DisplayAlert("Ошибка", "Введите логин!", "OK");
            else if (EntryPassword.Text == null || EntryPassword.Text == "") await DisplayAlert("Ошибка", "Введите пароль!", "OK");
            else if (EntryPassport.Text == null || EntryPassport.Text == "") await DisplayAlert("Ошибка", "Введите номер и серию паспорта!", "OK");
            else if (EntryAddress.Text == null || EntryAddress.Text == "") await DisplayAlert("Ошибка", "Введите адрес!", "OK");
            else if (EntryFio.Text == null || EntryFio.Text == "") await DisplayAlert("Ошибка", "Введите ФИО!", "OK");
            else
            {
                HttpClient client = new HttpClient();
                Masters master = MainPage.master;
                master.Address = EntryAddress.Text;
                master.Fio = EntryFio.Text;
                master.Login = EntryLogin.Text;
                master.Passport = EntryPassport.Text;
                master.Password = EntryPassword.Text;
                string ss = JsonConvert.SerializeObject(master);
                Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"s", ss }// название переменной в контроллере сервера и второе то что посылаем туда
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
                HttpResponseMessage responseMessage = await client.PostAsync(MainPage.url+"UpdateMaster", form);

                string result = await responseMessage.Content.ReadAsStringAsync();
                try
                {
                    MainPage.master = JsonConvert.DeserializeObject<Masters>(result);
                    await DisplayAlert("Выполнено", "Данные успешно обновлены!", "OK");
                    await Navigation.PopAsync();
                    //внести изменения в локал дб
                }
                catch
                {
                    await DisplayAlert("Ошибка", "", "OK");
                }
            }
        }
    }
}