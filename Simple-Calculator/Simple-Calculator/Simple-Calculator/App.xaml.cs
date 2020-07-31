﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #if DEBUG
                HotReloader.Current.Run(this);
            #endif

            MainPage = new MainPage();
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
