using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MYEB_MOBILE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
            Button1.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new Pagina1()); // passagem para a pagina teste 1
            };


            Button2.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new Pagina2()); // passagem para a pagina teste 2
            };
        }
    }
}