using Opdracht_dotnet_frameworks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Opdracht_dotnet_frameworks.Configuration;


var services = new ServiceCollection();
services.AddLogging();
services.AddSingleton<IServiceA, ServiceA>();
services.AddScoped<IServiceB, ServiceB>();
services.AddTransient<IServiceC, ServiceC>();

var provider = services.BuildServiceProvider(validateScopes: true);

var configuration = new ConfigurationBuilder()
    .AddCommandLine(args)
    .AddEnvironmentVariables()
    .AddJsonFile("appsettings.json")
    .Build();


var config = new LogLevelConfiguration();
configuration.Bind(config);

Console.WriteLine($"ServiceA LogLevel: {config.ServiceA.LogLevel}");
Console.WriteLine($"ServiceB LogLevel: {config.ServiceB.LogLevel}");
Console.WriteLine($"ServiceC LogLevel: {config.ServiceC.LogLevel}");


using (var scope = provider.CreateScope())
{
    var serviceA = scope.ServiceProvider.GetRequiredService<IServiceA>();
    serviceA.DoeIets();
}
using (var scope = provider.CreateScope())
{
    var serviceA = scope.ServiceProvider.GetRequiredService<IServiceA>();
    serviceA.DoeIets();
}


using (var scope = provider.CreateScope())
{
    var serviceB = scope.ServiceProvider.GetRequiredService<IServiceB>();
    serviceB.DoeIets();
}
using (var scope = provider.CreateScope())
{
    var serviceB = scope.ServiceProvider.GetRequiredService<IServiceB>();
    serviceB.DoeIets();
}

using (var scope = provider.CreateScope())
{
    var serviceC = scope.ServiceProvider.GetRequiredService<IServiceC>();
    serviceC.DoeIets();
}
using (var scope = provider.CreateScope())
{
    var serviceC = scope.ServiceProvider.GetRequiredService<IServiceC>();
    serviceC.DoeIets();
}

