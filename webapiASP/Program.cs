using Microsoft.EntityFrameworkCore;
using webapiASP.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration[
        "ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging();
});
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Hello World!");
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);
app.Run();