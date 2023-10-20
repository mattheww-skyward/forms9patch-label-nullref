using System;
using Xamarin.Forms;

namespace Forms9Issue.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToLogin();
        }
    }
}