using Android.Views;
using HealthPrototype.IService;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HealthPrototype.Droid.Service
{
    public class HealthService : IHealthService
    {

        public void FetchActiveEnergyBurned(Action<double> completionHandler)
        {
            throw new NotImplementedException();
        }

        public void FetchActiveMinutes(Action<double> completionHandler)
        {
            throw new NotImplementedException();
        }

        public void FetchMetersWalked(Action<double> completionHandler)
        {
            throw new NotImplementedException();
        }

        public void FetchSteps(Action<double> completionHandler)
        {
            throw new NotImplementedException();
        }

        public void GetHealthPermission(Action<bool> completion)
        {

        }
    }
}
