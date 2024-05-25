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
}