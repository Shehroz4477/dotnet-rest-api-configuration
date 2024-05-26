using dotnet_rest_api_configuration.Models;

namespace dotnet_rest_api_configuration.Extension.Options;
public static class OptionsConfigurationCollection
{
    public static IServiceCollection AddOptionsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DatabaseOption>(configuration.GetSection(DatabaseOption.SectionName));
        services.Configure<DatabaseOption>(DatabaseOption.SqlDatabaseSectionName, configuration.GetSection($"{DatabaseOption.NamedSectionName}:{DatabaseOption.SqlDatabaseSectionName}"));
        services.Configure<DatabaseOption>(DatabaseOption.MySqlDatabaseSectionName, configuration.GetSection($"{DatabaseOption.NamedSectionName}:{DatabaseOption.MySqlDatabaseSectionName}"));
        return services;
    }
}