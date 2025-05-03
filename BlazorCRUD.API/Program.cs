using BlazorCRUD.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
   
var ConString = builder.Configuration.GetConnectionString("ConString");
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(ConString));

builder.Services.AddCors(options => options.AddPolicy("BlazorYTPolicy", policyBuilder => {
    policyBuilder.WithOrigins("https://localhost:7249");
    policyBuilder.AllowAnyHeader();
    policyBuilder.AllowAnyMethod();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("BlazorYTPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
