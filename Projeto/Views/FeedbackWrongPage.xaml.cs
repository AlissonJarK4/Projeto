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
    public partial class FeedbackWrongPage : ContentPage
    {
        public FeedbackWrongPage()
        {
            InitializeComponent();
        }
        private async void Return_To_StartPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BottomNavPage());
        }
    }
}