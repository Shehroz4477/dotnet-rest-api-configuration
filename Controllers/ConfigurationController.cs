using dotnet_rest_api_configuration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace dotnet_rest_api_configuration.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConfigurationController(IConfiguration configuration) : ControllerBase
{
    [HttpGet]
    public ActionResult GetConfiguration()
    {
        var type = configuration["Database:Type"];
        var connectionString = configuration["Database:ConnectionString"];
        return Ok(new {ConnectionString = connectionString,Type = type});
    }
    [HttpGet("configuration/binder")]
    public ActionResult ConfigurationBinder()
    {
        var databaseOption = new DatabaseOption();
        //configuration.GetSection(DatabaseOption.SectionName).Bind(databaseOption);
        configuration.Bind(DatabaseOption.SectionName,databaseOption);
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/get")]
    public ActionResult ConfigurationGet()
    {
        var databaseOption = configuration.GetSection(DatabaseOption.SectionName).Get<DatabaseOption>();
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/IOptions/TOption")]
    public ActionResult ConfigurationITOption([FromServices] IOptions<DatabaseOption> options)
    {
        var databaseOption = options.Value;
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/IOptionsSnapshot/TOption")]
    public ActionResult ConfigurationITOptionSanpShot([FromServices] IOptionsSnapshot<DatabaseOption> options)
    {
        var databaseOption = options.Value;
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/IOptionsMonitor/TOption")]
    public ActionResult ConfigurationITOptionMonitor([FromServices] IOptionsMonitor<DatabaseOption> options)
    {
        var databaseOption = options.CurrentValue;
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/Named/Option/IOptionsMonitor/TOption/SqlDatabase")]
    public ActionResult ConfigurationNamedOptionITOptionMonitorSqlDatabase([FromServices] IOptionsMonitor<DatabaseOption> options)
    {
        var databaseOption = options.Get(DatabaseOption.SqlDatabaseSectionName);
        return Ok(new {databaseOption});
    }
    [HttpGet("configuration/Named/Option/IOptionsMonitor/TOption/MySqlDatabase")]
    public ActionResult ConfigurationNamedOptionITOptionMonitorMySqlDatabase([FromServices] IOptionsMonitor<DatabaseOption> options)
    {
        var databaseOption = options.Get(DatabaseOption.MySqlDatabaseSectionName);
        return Ok(new {databaseOption});
    }
}