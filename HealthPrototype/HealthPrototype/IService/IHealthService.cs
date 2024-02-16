using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HealthPrototype.IService
{
    public interface IHealthService
    {
        void FetchSteps(Action<double> completionHandler);
        void FetchMetersWalked(Action<double> completionHandler);
        void FetchActiveMinutes(Action<double> completionHandler); 
        void GetHealthPermission(Action<bool> completion);
        void FetchActiveEnergyBurned(Action<double> completionHandler);

    }
}
