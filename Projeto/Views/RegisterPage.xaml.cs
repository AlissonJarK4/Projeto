using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Register_Done(object sender, EventArgs e)
        {
            MySQLCon db = new MySQLCon();
            db.SaveUser(EntryUserName.Text, EntryUserEmail.Text, EntryUserPassword.Text);

            await Navigation.PushAsync(new MainPage());
        }
    }
}