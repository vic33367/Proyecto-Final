using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Proyecto_Final.UWP
{
    public sealed partial class MainPage : IAuthenticate
    {
        private MobileServiceUser user;

        public async Task<bool> Authenticate()
        {
            string message = string.Empty;
            var success = false;

            try
            {
                if (user == null)
                {
                    user = await Proyecto_Final.MainPage.cliente.LoginAsync(MobileServiceAuthenticationProvider.Facebook, "tesh2.azurewebsites.net");
                    
                    if (user != null)
                    {
                        success = true;
                        message = string.Format("Bienvenido {0}", user.UserId);
                    }
                }

            }
            catch (Exception ex)
            {
                message = string.Format("Authentication Failed: {0}", ex.Message);
            }
            await new MessageDialog(message, "Sign-in result").ShowAsync();
            return success;
        }
        public MainPage()
        {
            this.InitializeComponent();
            Proyecto_Final.App.Init(this);
            LoadApplication(new Proyecto_Final.App());
        }

       
    }
}
