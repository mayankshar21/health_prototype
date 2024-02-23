using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Auth;

namespace HealthPrototype.Model
{
    public class Constants
    {

        public static string AppName = "HealthPrototype";

        // Google Fit REST API parameters for Xamarin Auth
        public static string CLIENT_ID = "1093429039004-kal5om4tip1v1svbi259j60kr2crfn0p.apps.googleusercontent.com";
        public static string CLIENT_SECRET = null;
        public static string AUTHORIZE_URL = "https://accounts.google.com/o/oauth2/auth";
        public static string REDIRECT_TOKEN_URL = "com.bytesensei.healthprototype://auth";
        public static string ACCESS_TOKEN_URL = "https://oauth2.googleapis.com/token";
        public static GetUsernameAsyncFunc GET_USERNAME_ASYNC = null;
        public static bool IS_USING_NATIVE_UI = true;

        // Scopes for Google Fit REST API
        public static string FITNESS_ACTIVITY_READ = "https://www.googleapis.com/auth/fitness.activity.read";

    }
}
