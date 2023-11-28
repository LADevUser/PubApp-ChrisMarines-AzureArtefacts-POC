using System.Runtime.InteropServices;
using PublicServiceReportAPI.WebApi.Controllers;
using AutoMapper;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using PublicServiceReportAPI.WebApi.interfaces;
using PublicServiceReportAPI.WebApi.Helpers;


namespace PublicServiceReportAPI.WebApi
{
    public class Program {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.Development.json")
                            .Build();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddSingleton<IStorageProvider, StorageProvider>();
            var aiOptions = new Microsoft.ApplicationInsights.AspNetCore.Extensions.ApplicationInsightsServiceOptions();
            aiOptions.EnableAdaptiveSampling = false;
            builder.Services.AddApplicationInsightsTelemetry(aiOptions);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }           

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

    }
}