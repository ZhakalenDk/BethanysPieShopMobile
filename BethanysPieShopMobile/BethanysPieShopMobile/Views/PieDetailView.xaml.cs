using BethanysPieShopMobile.Models;
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
    public partial class PieDetailView : ContentPage
    {
        public PieDetailView(Pie pie)
        {
            InitializeComponent();

            Pie = pie;

            BindingContext = this;
        }

        public Pie Pie { get; set; }

        ///// <summary>
        ///// Binds the <paramref name="pie"/> data to the corresponding <strong>UI</strong> elements 
        ///// </summary>
        ///// <param name="pie"></param>
        //private void BindData(Pie pie)
        //{
        //    pieName.Text = pie.PieName;
        //    pieImage.Source = pie.ImageUrl;
        //    price.Text = pie.Price.ToString("C");
        //    description.Text = pie.Description;
        //    inStock.Text = ((pie.InStock) ? ("In stock") : ("Not in stock"));
        //}

        private async void AddToBasket(object sender, EventArgs e)
        {
            await DisplayAlert("Success", $"Pie ({Pie.PieName}) was saved!", "OK");
        }
    }
}