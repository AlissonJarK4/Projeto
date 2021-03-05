using Projeto.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Projeto.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}