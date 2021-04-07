
using Projeto;
using Projeto.ViewModels;
using Projeto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace XF_Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;

            vm.ShowInvalidLoginMessage += () => DisplayAlert("Falha no login", "Login Inválido, tente novamente", "OK");

            InitializeComponent();
            Email.Completed += (object sender, EventArgs e) =>
            {
                Senha.Focus();
            };
            Senha.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }

        private async void Login_Done(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BottomNavPage());
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}