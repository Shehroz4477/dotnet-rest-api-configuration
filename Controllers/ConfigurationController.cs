using dotnet_rest_api_configuration.Models;
using Microsoft.AspNetCore.Mvc;

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
    public ActionResult GetConfigurationBinder()
    {
        var databaseOption = new DatabaseOption();
        //configuration.GetSection(DatabaseOption.SectionName).Bind(databaseOption);
        configuration.Bind(DatabaseOption.SectionName,databaseOption);
        return Ok(new {databaseOption});
    }
}