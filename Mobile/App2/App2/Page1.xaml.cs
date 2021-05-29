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
        public static Zakazs_Master selected_zakaz = null;
        public Page1()
        {
            InitializeComponent();
            if (MainPage.zakazs_s.Count > 0)
                foreach (Zakazs_Master i in MainPage.zakazs_s) picker_zak.Items.Add(i.Id_izd.ToString());
        }
        protected async override void OnAppearing()
        {
            Title = MainPage.master.Fio;
            if (MainPage.zakazs_s.Count == 0) // если заказов больше нет, то очищаем приложение от сохранённых строк json и отправляем пользователя в MainPage для авторизации
            {   await DisplayAlert("Заказов нет", "На данный аккаунт нет заказов!", "OK"); MainPage.DeleteAppCurrProp(); await Navigation.PopAsync(); }
            
        }
        private async void ButtonHello_Click(object sender, EventArgs e)
        {
            if(selected_zakaz != null) await Navigation.PushAsync(new Page_Rabota());
            else await DisplayAlert("Ошибка", "Не выбран заказ!", "OK");
            
        }
        private void ButtonLoad_Image(object sender, EventArgs e)
        {
            foreach (Zakazs_Master i in MainPage.zakazs_s)
                if (i.Id_izd.ToString() == picker_zak.SelectedItem.ToString())
                    selected_zakaz = i;
            image.Source = selected_zakaz.Url_pic;
            label.Text = selected_zakaz.Name_izd + "\nДата:" + selected_zakaz.date_start;
            
        }
        private async void ButtonExit_Click(object sender, EventArgs e)
        {
            //Directory.Delete("Data Source= " + Path.Combine(MainPage.folder, "Master.db"));//удаляем дб
            MainPage.DeleteAppCurrProp();
            await Navigation.PopAsync(); 
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Master_Page());
        }
    }
}