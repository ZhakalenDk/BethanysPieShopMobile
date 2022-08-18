using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsTableView : ContentPage
    {
        public SettingsTableView()
        {
            InitializeComponent();

            languagePickerInCode.ItemsSource = Languages;
            languagePickerInCode.SelectedIndex = 0;
            pieStepper.BindingContext = this;
        }

        List<string> Languages { get; set; } = new List<string>
        {
            "English",
            "Dutch",
            "French",
            "German"
        };

        public int MaxPies
        {
            get
            {
                return maxPies;
            }
            set
            {
                maxPies = value;
                maxPies = ((maxPies < 0) ? (0) : (maxPies));
                maxPies = ((maxPies > 10) ? (10) : (maxPies));
                OnPropertyChanged(nameof(MaxPies));
            }
        }
        private int maxPies = 0;

        private void MaxPieStepper(object sender, EventArgs e)
        {
            var control = sender as Button;

            MaxPies = ((control.Text == "+") ? (++maxPies) : (--maxPies));
        }

        private void Save(object sender, EventArgs e)
        {
            activityIndicator.IsRunning = true;
            Timer timer = new Timer((s) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("Confirmation", "Your settings have been saved!", "OK");
                });

                (( ActivityIndicator )s).IsRunning = false;
            }, activityIndicator, 2000, Timeout.Infinite);
        }
    }
}