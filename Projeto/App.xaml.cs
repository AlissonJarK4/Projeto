using Projeto.Services;
using Projeto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.Pages;

namespace Projeto
{
    public partial class App : Application
    {
        private NavigationPage Quiz1Page;
        private NavigationPage RegisterPage;
        private NavigationPage BasePage;

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
            Quiz1Page = new NavigationPage(new QuizPage());
            RegisterPage = new NavigationPage(new RegisterPage());
            BasePage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
