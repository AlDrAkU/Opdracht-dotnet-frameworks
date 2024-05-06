using System;
namespace Opdracht_dotnet_frameworks
{
	public class ServiceA : IServiceA
	{
        private readonly ILogger<ServiceA> _logger;
        public ServiceA(ILogger<ServiceA> logger)
		{
            Console.WriteLine("Service A : Constructor called.");
            _logger = logger;
		}

        public void DoeIets()
        {
            Console.WriteLine("Service A doet Iets.");

        }
    }
}

