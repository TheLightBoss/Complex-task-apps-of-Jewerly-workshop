using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using App2.Models;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public static Zakazs_Master selected_zakaz;
        public Page1()
        {
            InitializeComponent();
            
            Title = MainPage.master.Fio;
            if (MainPage.zakazs_s != null)
                foreach (Zakazs_Master i in MainPage.zakazs_s) picker_zak.Items.Add(i.Id_izd.ToString()); // заполяем комбобокс
            else picker_zak.Items.Add("заказов нет");

        }
        private async void ButtonHello_Click(object sender, EventArgs e)
        {
            if(selected_zakaz != null) await Navigation.PushAsync(new Page_Rabota());
            else await DisplayAlert("Ошибка", "Не выбран заказ!", "OK");
            
        }
        private void ButtonLoad_Image(object sender, EventArgs e)
        {
            
            if (picker_zak.SelectedItem.ToString() == "")
            {
                foreach (Zakazs_Master i in MainPage.zakazs_s)
                    if (i.Id_izd.ToString() == picker_zak.SelectedItem.ToString())
                        selected_zakaz = i;
                image.Source = selected_zakaz.Url_pic;
                label.Text = selected_zakaz.Name_izd;
            } 
        }
        private async void ButtonExit_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("DB\\TestDB.db");//удаляем дб
            await Navigation.PopAsync(); //кнопка назад должны быть это, пока не испытана
        }
    }
}