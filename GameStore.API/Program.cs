using GameStore.API.Data;
using GameStore.API.Endpoints;
using GameStore.API.Entities;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);  //Scoped_lifeline


var app = builder.Build();

app.MapGamesEndpoints();

app.MigrateDb();

app.Run();
