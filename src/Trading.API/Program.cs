var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// This line registers your controller classes with the application's services.
builder.Services.AddControllers();

// These lines are for the API documentation page (Swagger/OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// THIS IS THE LINE I SUSPECT IS MISSING.
// This line actually maps the routes from your controllers so the app can use them.
app.MapControllers();

app.Run();