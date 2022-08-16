using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Views.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");

            (( Button )sender).Text = ((answer) ? ("Answer: Yes") : ("Answer: No"));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");

            (( Button )sender).Text = $"Answer: {action}";
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");

            (( Button )sender).Text = $"Answer: {action}";
        }
    }
}