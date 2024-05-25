# Routing
#### 1. ASP.NET Core provides a way to configure the route value into lowercase globally

# Mapping HTTP methods to action methods
####  ASP.NET Core, we can use the following HTTP verb attributes to map HTTP methods to action methods

# Route constraints
#### 1. [HttpGet("{id:int}")]
#### 2. Without route constraint server return 400 bad request to client if route parameter does not match.
#### 3. If route constraint add in route paramters then response 404 not found.

# Binding Source Attribute
#### 1. [FromBody]: The parameter is from the request body
#### 2. [FromForm]: The parameter is from the form data in the request body
#### 3. [FromHeader]: The parameter is from the request header
#### 4. [FromQuery]: The parameter is from the query strings in the request
#### 5. [FromRoute]: The parameter is from the route path
#### 6. [FromServices]: The parameter is from the DI container

# Configuration
#### 1. The file configuration provider, such as, appsettings.json
#### 2. The User secrets
#### 3. The environment variables configuration provider
#### 4. The command-line configuration provider
#### 5. The Azure App Configuration provider
#### 6. The Azure Key Vault configuration provider

# IConfiguration Interface
#### 1.Using the IConfiguration interface, we can access the configuration settings with the configuration[key] format.

# Using the options pattern
#### 1. use the options pattern, we need to create a class that represents the configuration settings.
#### 2. Multiple ways to use the options pattern
##### - Using the ConfigurationBinder.Bind() method
###### a. GetSection(DatabaseOption.SectionName).Bind(databaseOption)
###### b. Bind(DatabaseOption.SectionName, databaseOption) 
##### - Using the ConfigurationBinder.Get<TOption>() method
###### a. GetSection(DatabaseOption.SectionName).Get<DatabaseOption>()
##### - Using the IOptions<TOption> interface
###### a. ASP.NET Core provides built-in DI support for the options pattern
###### b. We need to register the <TOption> class in the Services.Configure() method of the Program.cs file
###### c. W can use DI to inject the IOptions<TOption> interface into desire controller
