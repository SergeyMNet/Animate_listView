using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App3.Pages;
using Xamarin.Forms;

namespace App3
{
    public partial class App : Application
    {
        public static int ScreenWidth;
        public static int ScreenHeight;

        public App()
        {
            InitializeComponent();

            if (ScreenHeight == 0)
            {
                ScreenHeight = 1000;
            }
            if (ScreenWidth == 0)
            {
                ScreenWidth = 600;
            }

            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
