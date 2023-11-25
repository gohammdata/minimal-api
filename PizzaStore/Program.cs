var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddCors(options => {});
app.MapGet("/", () => "Hello World!");

app.Run();
