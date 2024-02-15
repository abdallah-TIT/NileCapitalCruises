using NileCapitalCruises.API.Extensions;
using NileCapitalCruises.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
}); 

builder.Services.AddApplicationServices();
builder.Services.AddIdentityServices(builder.Configuration);


// Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAccessTokenMiddleware();

app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/errors/{0}");


app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();


app.MapControllers();

app.UseCors("AllowAnyOrigin");

app.Run();
