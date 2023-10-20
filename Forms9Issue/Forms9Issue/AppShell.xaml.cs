using Forms9Issue.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms9Issue
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public new static AppShell Current => Shell.Current as AppShell;
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        internal async Task GoToLogin()
        {
            Login.IsVisible = true;
            await GoToAsync("//LoginPage");
        }

        internal async Task GoToMain()
        {
            await GoToAsync("//MainPage");
            Login.IsVisible = false;
        }
    }
}
