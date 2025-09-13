using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add ocelot configuration
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Register ocelot service
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

// Enable octelot middleware
await app.UseOcelot();

app.Run();
