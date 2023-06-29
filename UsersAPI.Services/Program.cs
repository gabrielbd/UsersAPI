using UsersAPI.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(o => o.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();

var app = builder.Build();



app.UseSwaggerDoc();

app.UseAuthorization();

app.MapControllers();

app.Run();
