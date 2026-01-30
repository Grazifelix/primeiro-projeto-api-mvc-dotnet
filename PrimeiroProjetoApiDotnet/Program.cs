using PrimeiroProjetoApiDotnet.Infrastructure;
using PrimeiroProjetoApiDotnet.Service;
using PrimeiroProjetoApiDotnet.Services;
using PrimeiroProjetoApiDotnet.Trasfer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddAutoMapper(typeof(BookProfiles));


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
