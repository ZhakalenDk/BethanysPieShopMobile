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
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();

            dob.Date = DateTime.Now;
        }

        private void EnableRegistering(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userName.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                registerButton.IsEnabled = true;

                return;
            }

            registerButton.IsEnabled = false;
        }

        private async void Register(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmation", "You've registered successfully", "OK");
        }


        private async void DateValidator(object sender, DateChangedEventArgs e)
        {
            var control = sender as DatePicker;

            if (control.Date == DateTime.Now.Date)
            {
                await DisplayAlert("Joker Says", "You weren't born today I guess!", "OK");
            }
        }
    }
}