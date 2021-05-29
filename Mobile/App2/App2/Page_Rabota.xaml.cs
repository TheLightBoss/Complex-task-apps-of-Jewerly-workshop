using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.SQLite;
using App2.Models;
using System.IO;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Rabota : ContentPage
    {
        readonly HttpClient client = new HttpClient();
        bool lol = false; //при подгрузке данных выскакивает окно, с bool уберём это
        public Page_Rabota()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Title = Page1.selected_zakaz.Name_izd;
            image.Source = Page1.selected_zakaz.Url_pic;
            label_raz.Text = "Размер" + Page1.selected_zakaz.Razmer.ToString();

            label1.Text = Page1.selected_zakaz.Spisok_rabot[0];
            label2.Text = Page1.selected_zakaz.Spisok_rabot[1];
            label3.Text = Page1.selected_zakaz.Spisok_rabot[2];

            if (Page1.selected_zakaz.Spisok_rabot[0] == Page1.selected_zakaz.Vipoln_rabot[0]) chbox1.IsChecked = true;
            else chbox1.IsChecked = false;

            if (Page1.selected_zakaz.Spisok_rabot[1] == Page1.selected_zakaz.Vipoln_rabot[1]) chbox2.IsChecked = true;
            else chbox2.IsChecked = false;

            if (Page1.selected_zakaz.Spisok_rabot[2] == Page1.selected_zakaz.Vipoln_rabot[2]) chbox3.IsChecked = true;
            else chbox3.IsChecked = false;

            if (Page1.selected_zakaz.Spisok_rabot.Length == 4)
            {
                label4.Text = Page1.selected_zakaz.Spisok_rabot[3];
                if (Page1.selected_zakaz.Spisok_rabot[3] == Page1.selected_zakaz.Vipoln_rabot[3]) chbox4.IsChecked = true;
                else chbox4.IsChecked = false;
            }
            else { chbox4.IsEnabled = false; chbox4.IsVisible = false; label4.IsVisible = false; }//скрываем лишний chechbox,
                                                                                                  //так как у некоторых изделий нет 4 пункта   
            lol = true;
        }
        /*
        async void UpdateData()
        {

            using (SQLiteConnection Connect = new SQLiteConnection("Data Source= " + Path.Combine(MainPage.folder, "Master.db"))) // в строке указывается к какой базе подключаемся
            {
                Connect.Open(); // открыть соединение

                if(chech_what_check==1)
                {
                    SQLiteCommand command = new SQLiteCommand("UPDATE Zakazs SET rabota_1stat = " + chbox1.IsChecked + " WHERE Id_izd = " + ZAK.Id_izd + ";", Connect);
                    command.ExecuteNonQuery();
                }
                else if (chech_what_check == 2)
                {
                    SQLiteCommand command = new SQLiteCommand("UPDATE Zakazs SET rabota_2stat = " + chbox2.IsChecked + " WHERE Id_izd = " + ZAK.Id_izd + ";", Connect);
                    command.ExecuteNonQuery();
                }
                else if (chech_what_check == 3)
                {
                    SQLiteCommand command = new SQLiteCommand("UPDATE Zakazs SET rabota_3stat = " + chbox3.IsChecked + " WHERE Id_izd = " + ZAK.Id_izd + ";", Connect);
                    command.ExecuteNonQuery();
                }
                else if (chech_what_check == 4)
                {
                    SQLiteCommand command = new SQLiteCommand("UPDATE Zakazs SET rabota_4stat = " + chbox4.IsChecked + " WHERE Id_izd = " + ZAK.Id_izd + ";", Connect);
                    command.ExecuteNonQuery();
                }
                if(chbox1.IsChecked==true && chbox2.IsChecked == true && Page1.selected_zakaz.Polu_status == false)
                {
                    string id = ZAK.Id_izd.ToString();
                    Dictionary<string, string> dict = new Dictionary<string, string>()
                    {
                        {"s" , id }// название переменной в контроллере сервера и второе то что посылаем туда
                    };

                    FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
                    HttpResponseMessage responseMessage = await client.PostAsync(MainPage.url + "ZakazHalfCompleted", form);

                    string result = await responseMessage.Content.ReadAsStringAsync();
                    if (result == "0")
                    {
                        
                    }
                    else
                    {
                        await DisplayAlert("Ошибка", "Статус готовности не был отправлен!", "OK");
                    }
                } // когда заказ выполнен наполовину Polu_status

                Connect.Close(); // закрыть соединение
            }
        }*/
        void UpdateItem(int i, bool ch)
        {
            if(ch)
            {
                Page1.selected_zakaz.Vipoln_rabot[i] = Page1.selected_zakaz.Spisok_rabot[i];
            }
            else
            {
                Page1.selected_zakaz.Vipoln_rabot[i] = "";
            }
            Zakazs_Master tmp = new Zakazs_Master();
            foreach (Zakazs_Master j in MainPage.zakazs_s)
                if (j.Id_izd == Page1.selected_zakaz.Id_izd)
                   tmp = j; // ищем нужный заказ, сохраняем
            MainPage.zakazs_s.Remove(tmp); //удаляем старый
            MainPage.zakazs_s.Add(Page1.selected_zakaz); //добавляем новый
            MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 
        }
        private async void chbox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                //UpdateData();
                UpdateItem(0, chbox1.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }

        private async void chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                //UpdateData();
                UpdateItem(1, chbox2.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");

            }


        }

        private async void chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(2, chbox3.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }

        private async void chbox4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lol)
            {
                UpdateItem(3, chbox4.IsChecked);
                await DisplayAlert("Выполнено", "", "OK");
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (chbox1.IsChecked && chbox2.IsChecked && chbox3.IsChecked)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"s" , Page1.selected_zakaz.Id_izd.ToString() }// название переменной в контроллере сервера и второе то что посылаем туда
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
                HttpResponseMessage responseMessage = await client.PostAsync(MainPage.url + "ZakazCompleted", form);

                string result = await responseMessage.Content.ReadAsStringAsync();
                if (result == "0")
                {
                    Zakazs_Master tmp = new Zakazs_Master();
                    foreach (Zakazs_Master j in MainPage.zakazs_s)
                        if (j.Id_izd == Page1.selected_zakaz.Id_izd)
                            tmp = j; // ищем нужный заказ, сохраняем
                    MainPage.zakazs_s.Remove(tmp); // удаляем выполненный заказ из списка заказовы
                    MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 

                    await DisplayAlert("Выполнено", "Заказ завершён!", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Ошибка", "", "OK");
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Не все задачи выполнены!", "OK");
            }
        } // заказ выполнен полностью

        private async void Button_ClickedUpdItem(object sender, EventArgs e)
        {
            string s = JsonConvert.SerializeObject(Page1.selected_zakaz);
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"s" , s }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(MainPage.url + "ZakazHalfCompleted", form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            if (result == "0")
            {
                Zakazs_Master tmp = new Zakazs_Master();
                foreach (Zakazs_Master j in MainPage.zakazs_s)
                    if (j.Id_izd == Page1.selected_zakaz.Id_izd)
                        tmp = j; // ищем нужный заказ, сохраняем
                MainPage.zakazs_s.Remove(tmp); // удаляем выполненный заказ из списка заказовы
                MainPage.zakazs_s.Add(Page1.selected_zakaz);
                MainPage.UpdateAppCurrProp(); //сохраняем изменения в строках json 

                await DisplayAlert("Выполнено", "Изменения отправлены!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Ошибка", "", "OK");
            }
        } // отправляем изменения (то что уже выполнил)
    }
}