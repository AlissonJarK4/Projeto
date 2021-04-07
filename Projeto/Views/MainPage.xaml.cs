using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ClickFluor1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizFluor1Page());
        }

        private async void ClickFluor2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizFluor2Page());
        }

        private async void ClickEscova1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizEscova1Page());
        }
    }
}