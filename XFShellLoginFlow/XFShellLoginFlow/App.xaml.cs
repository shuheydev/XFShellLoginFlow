﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellLoginFlow.Views;

namespace XFShellLoginFlow
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
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
