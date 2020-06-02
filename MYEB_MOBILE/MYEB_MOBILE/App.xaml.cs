using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MYEB_MOBILE
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set; } //navegar a partir de master

        public async static Task NavigateMasterDetail(Page page) // Metodo de passagem das paginas
        {
            App.MasterDetail.IsPresented = false; // fechar masterpage durante a navegacao
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
