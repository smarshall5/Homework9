using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Homework9.Services;
using Homework9.Views;

namespace Homework9
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
