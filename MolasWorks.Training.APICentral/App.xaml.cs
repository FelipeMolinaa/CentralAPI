﻿using FreshMvvm;
using MolasWorks.Training.APICentral.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MenuPage();
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