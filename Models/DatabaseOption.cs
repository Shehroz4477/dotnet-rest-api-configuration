namespace dotnet_rest_api_configuration.Models;
public class DatabaseOption
{
    public const string SectionName = "Database";
    public const string NamedSectionName = "NamedDatabase";
    public const string SqlDatabaseSectionName = "SqlDatabase";
    public const string MySqlDatabaseSectionName = "MySqlDatabase";
    public string Type { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
}