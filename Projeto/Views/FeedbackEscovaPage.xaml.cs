using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedbackEscovaPage : ContentPage
    {
        public FeedbackEscovaPage()
        {
            InitializeComponent();
        }
        private async void Return_To_StartPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BottomNavPage());
        }
    }
}