using System;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;
using Xamarin.Forms;
using HealthPrototype.Model;
using System.Diagnostics;

namespace HealthPrototype
{
    public partial class MainPage : ContentPage
    {

        private OAuth2Authenticator authenticator;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Entered!");

            OAuth2Authenticator authenticator = new OAuth2Authenticator(
                clientId: Constants.CLIENT_ID,
                clientSecret: Constants.CLIENT_SECRET,
                scope: Constants.FITNESS_ACTIVITY_READ,
                authorizeUrl: new Uri(Constants.AUTHORIZE_URL),
                redirectUrl: new Uri(Constants.REDIRECT_TOKEN_URL),
                accessTokenUrl: new Uri(Constants.ACCESS_TOKEN_URL),
                getUsernameAsync: Constants.GET_USERNAME_ASYNC,
                isUsingNativeUI: Constants.IS_USING_NATIVE_UI
            );

            authenticator.Completed += OnAuthenticationCompleted;
            authenticator.Error += OnAuthenticationError;

            Console.WriteLine("Exited!");

            var presenter = new OAuthLoginPresenter();
            presenter.Login(authenticator);
        }

        private async void OnAuthenticationCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {

            if (e.IsAuthenticated)
            {
                string accessToken = e.Account.Properties["access_token"];
                await DisplayAlert("Success", accessToken, "OK");
               
            }
            else
            {
                await DisplayAlert("Error", "Authentication failed", "OK");
            }
        }

        private async void OnAuthenticationError(object sender, AuthenticatorErrorEventArgs e)
        {
            await DisplayAlert("Error", "Authentication error: " + e.Message, "OK");
        }
    }
}

