using BethanysPieShopMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new SettingsTableView());

            var alreadyRegistered = false;

            if (alreadyRegistered)
                MainPage = new AppShell();
            else
                MainPage = new NavigationPage(new LoginView());
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
