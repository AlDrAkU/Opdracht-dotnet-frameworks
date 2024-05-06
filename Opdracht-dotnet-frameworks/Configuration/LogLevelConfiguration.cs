using System;
namespace Opdracht_dotnet_frameworks.Configuration
{
    public class ServiceConfiguration
    {
        public string LogLevel { get; set; }
    }

    public class LogLevelConfiguration
    {
        public ServiceConfiguration ServiceA { get; set; }
        public ServiceConfiguration ServiceB { get; set; }
        public ServiceConfiguration ServiceC { get; set; }
    }
}

