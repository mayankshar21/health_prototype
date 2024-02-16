using HealthPrototype.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using HealthPrototype;
using Xamarin.Forms;
using System.Net.Http;

namespace HealthPrototype.ViewModel
{
    public class MainPage : ContentPage
    {

        private const string FITNESS_API_BASE_URL = "https://www.googleapis.com/fitness/v1/users/me/DataSources";
        private const string ACCESS_TOKEN = "";

        public MainPage()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ACCESS_TOKEN}");

                    string endpoint = FITNESS_API_BASE_URL + "dataSources/raw:com.google.step_count.delta:AndroidPhone/datasets/0-30";

                    HttpResponseMessage response = client.GetAsync(endpoint).Result.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = response.Content.ReadAsStringAsync().Result.ToString();
                        Console.WriteLine(jsonContent);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
