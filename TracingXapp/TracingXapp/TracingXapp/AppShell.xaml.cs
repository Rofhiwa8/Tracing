using System;
using System.Collections.Generic;
using TracingXapp.ViewModels;
using TracingXapp.Views;
using Xamarin.Forms;

namespace TracingXapp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
