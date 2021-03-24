using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }
        private async void OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Quiz1Page());
        }
    }
}