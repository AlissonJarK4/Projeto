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

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
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
