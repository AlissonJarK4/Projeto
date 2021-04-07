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
    public partial class QuizFluor2Page : ContentPage
    {
        public QuizFluor2Page()
        {
            InitializeComponent();
        }

        private async void Give_Feedback(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedbackFluorPage());
        }
    }
}