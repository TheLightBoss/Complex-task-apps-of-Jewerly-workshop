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

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Rabota : ContentPage
    {
        public Page_Rabota()
        {
            InitializeComponent();
            //Title = Page1.selected_zakaz.Name_izd;
            //image.Source = Page1.selected_zakaz.Url_pic;
            //label1.Text = Page1.selected_zakaz.Spisok_rabot[0];
            //label2.Text = Page1.selected_zakaz.Spisok_rabot[1];
            //label3.Text = Page1.selected_zakaz.Spisok_rabot[2];
            //if (Page1.selected_zakaz.Spisok_rabot.Length == 4) label4.Text = Page1.selected_zakaz.Spisok_rabot[3];
            //else chbox4.IsEnabled = false;
        }

        private async void chbox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (chbox1.IsChecked) 
            {

                await DisplayActionSheet("", "Выполнено!", "OK");
            }
            else
            {

            }
            

        }

        private async void chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (chbox2.IsChecked)
            {

                await DisplayActionSheet("", "Выполнено!", "OK");
            }
            else
            {

            }

        }

        private async void chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (chbox3.IsChecked)
            {

                await DisplayActionSheet("", "Выполнено!", "OK");
            }
            else
            {

            }

        }

        private async void chbox4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (chbox4.IsChecked)
            {

                await DisplayActionSheet("", "Выполнено!", "OK");
            }
            else
            {

            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "178.44.100.46:5001/Master/GetMater";
            // изделие когда будет выполнено отправить по api что выполнено
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"s","ky" }// название переменной в контроллере сервера и второе то что посылаем туда
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(dict);
            HttpResponseMessage responseMessage = await client.PostAsync(url, form);

            string result = await responseMessage.Content.ReadAsStringAsync();
            List<string> re = JsonConvert.DeserializeObject<List<string>>(result);

            label1.Text = re[0];
            label2.Text = re[1];
            label3.Text = re[2];
            label4.Text = re[3];
        }
    }
}