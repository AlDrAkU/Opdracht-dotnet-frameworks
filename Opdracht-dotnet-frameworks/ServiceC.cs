using System;
namespace Opdracht_dotnet_frameworks
{
	public class ServiceC : IServiceC
	{
        private readonly ILogger<ServiceC> _logger;
        public ServiceC(ILogger<ServiceC> logger)
        {
            Console.WriteLine("Service C : Constructor called.");
            _logger = logger;
        }

        public void DoeIets()
        {
            Console.WriteLine("Service C doet Iets.");
        }
    }
}

