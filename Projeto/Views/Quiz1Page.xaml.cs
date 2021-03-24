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
    public partial class Quiz1Page : ContentPage
    {
        public Quiz1Page()
        {
            InitializeComponent();
        }

        private async void Give_Feedback_Correct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackPage());
        }

        private async void Give_Feedback_Wrong(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackWrongPage());
        }
    }
}