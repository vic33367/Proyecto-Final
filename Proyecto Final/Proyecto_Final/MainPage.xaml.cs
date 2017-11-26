using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;

namespace Proyecto_Final
{
    public partial class MainPage : ContentPage
    {
        bool authenticated = false;
        public static MobileServiceClient cliente;
        public MainPage()
        {
            InitializeComponent();
            cliente = new MobileServiceClient(AzureConnection.AzureURL);
        }
        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();
        }
    }
}
