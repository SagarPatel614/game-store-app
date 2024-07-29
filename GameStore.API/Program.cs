using GameStore.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Root Page
app.MapGet("/", () => "Hello World!");

app.MapGamesEndpoints();

app.Run();
