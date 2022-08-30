using Struggle.Common;
using Struggle.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));
#region Check Environment

var section = builder.Configuration.GetSection($"{nameof(Settings)}");
var settings = section.Get<Settings>();
#endregion Check Environment

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddData(builder.Configuration)
                .AddDataServices()
                .AddAutoMapper();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
