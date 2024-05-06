using System;
using Opdracht_dotnet_frameworks;

namespace Opdracht_dotnet_frameworks
{
    public class ServiceB : IServiceB
    {
        private readonly IServiceA _serviceA;
        private readonly ILogger<ServiceB> _logger;

        public ServiceB(IServiceA serviceA, ILogger<ServiceB> logger)
        {
            _serviceA = serviceA;
            _logger = logger;
            Console.WriteLine("Service B : Constructor called.");
        }

        public void DoeIets()
        {
            _serviceA.DoeIets(); // Service A kan hier ook gebruikt worden.
            Console.WriteLine("Service B doet Iets.");
        }
    }
}



