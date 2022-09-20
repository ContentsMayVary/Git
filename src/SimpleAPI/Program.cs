var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();

// Added this comment to provoke a rebuild.
