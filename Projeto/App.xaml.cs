﻿using Projeto.Services;
using Projeto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new GreetPage();
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
