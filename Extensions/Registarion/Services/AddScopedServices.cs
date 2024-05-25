using dotnet_rest_api_configuration.Interfaces;
using dotnet_rest_api_configuration.Services;

namespace dotnet_rest_api_configuration.Extension.Registration.Services;
public static class AddScopedServicesRegistrations
{
    public static IServiceCollection AddScopedServices(this IServiceCollection services)
    {
        services.AddScoped<IPostService,PostService>();
        return services;
    }
}