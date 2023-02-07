using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProject2.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void btn_SignIn_Clicked(object sender, EventArgs e)
        {
            if (tb_Login.Text != string.Empty && tb_Password.Text != string.Empty && tb_Login.Text != null && tb_Password.Text != null)
            {
                await Navigation.PushModalAsync(new TabbedPage1());
            }

            else
            {
               await DisplayAlert("Ошибка!", "Введите данные в поля!", "Ок");
            }
            
        }
    }
}