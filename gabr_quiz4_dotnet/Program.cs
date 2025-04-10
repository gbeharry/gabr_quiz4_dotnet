var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Database access has already been done on April 1, 2025 by Gabriel Beharry!");

app.Run();
