var builder = WebApplication.CreateBuilder(args);

#region Services

var services = builder.Services;
var configuration = builder.Configuration;

services.AddUIComponents();

services.AddCmsServices(configuration);

// Use LiteDB as database
services.AddLiteDbRepositories("LiteDb");

// Use MongoDB as database
//services.AddMongoDbRepositories("MongoDb");

services.AddApiServices();

#endregion

#region App

var app = builder.Build();

app.UseDeveloperExceptionPage();

#if DEBUG

// this section is only for development purposes
// this will delete all data and re-create the database
using var scope = app.Services.CreateScope();
var setup = scope.ServiceProvider.GetRequiredService<FluentCMS.Web.Api.Setup.ISetupManager>();
setup.Reset().ConfigureAwait(false).GetAwaiter().GetResult();

#endif

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseApiService();

app.UseCmsServices();

#endregion

app.Run();
