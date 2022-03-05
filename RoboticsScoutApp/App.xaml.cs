using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoboticsScoutApp.Services;
using RoboticsScoutApp.Views;

namespace RoboticsScoutApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new StartPage();
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
