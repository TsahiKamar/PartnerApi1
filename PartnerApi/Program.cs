using Api;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using PartnerApi.Entities;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
            options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod())
        );



builder.Services.AddControllers();



// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
   //mc.AddProfile(new EnumProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddScoped<ICustomerBL, CustomerBL>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
app.UseCors("CorsPolicy");

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Index}/{id?}");


app.Run();
