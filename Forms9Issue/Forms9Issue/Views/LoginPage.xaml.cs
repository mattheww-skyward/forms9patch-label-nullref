using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms9Issue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static readonly BindableProperty LabelVisibleProperty = BindableProperty.Create(nameof(LabelVisible), typeof(bool), typeof(LoginPage), false);

        public bool LabelVisible
        {
            get => (bool)GetValue(LabelVisibleProperty);
            set => SetValue(LabelVisibleProperty, value);
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            LabelVisible = true;
            await Task.Delay(1000);
            LabelVisible = false;
            await Task.Delay(500);
            await AppShell.Current.GoToMain();
        }
    }
}