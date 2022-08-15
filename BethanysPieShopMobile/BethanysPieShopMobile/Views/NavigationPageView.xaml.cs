using BethanysPieShopMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void Basket_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketView());
        }

        private async void ContactUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUsView());
        }

        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomepageView());
        }

        private async void Pies_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PieOverviewView());
        }
    }
}