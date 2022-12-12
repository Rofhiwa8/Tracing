using System;
using TracingXapp.Services;
using TracingXapp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TracingXapp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage()) { BarBackgroundColor = Color.FromHex("#D95900") };
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
