using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TracingXapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private Client client;
        public Register()
        {
            InitializeComponent();
            client= new Client();
        }

        private async void HandleRegister(object sender, EventArgs args)
        {
            OwnerRegistrationDto register = new OwnerRegistrationDto()
            {
                Name = name.Text,
                Surname= surname.Text,
                Email= EntryEmail.Text,
                Password = Password.Text,
                ConfirmPassword = ConfirmPassword.Text,
                
            };

         //   ValidateEmailAddress();

            var getRegistration = await client.ApiAuthenticationRegisterAsync(register);

            if (getRegistration.Success == true) 
            {
             //   var message = new EmailMessage("Registration validation", "Your registeration is complete!", "devplatform01@gmail.com");
                //message.To = EntryEmail.Text;
             //   await Email.ComposeAsync(message);

                await Navigation.PushAsync(new LoginPage());
            } 

        }

        private void ValidateEmailAddress()
        {
            var email = EntryEmail.Text;
            var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (!String.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, emailPattern)))
            {
                LabelError.Text = "EmailVerification Failed";
            } 
            else
            {
                LabelError.Text = "";
            }
        }
    }
}