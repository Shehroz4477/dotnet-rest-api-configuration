namespace dotnet_rest_api_configuration.Extension.Configuration.AddRouting;
public static class AddRoutingConfigurationsExtension
{
    public static IServiceCollection AddRoutingConfigurations(this IServiceCollection services)
    {
        services.AddRouting(routeOptions => routeOptions.LowercaseUrls = true);
        return services;
    }
}