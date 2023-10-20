using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreRateLimit;
using Core.Interfaces;
using Microsoft.Extensions.Options;

namespace Api.Extensions
{
    public static class AplicationServiceExtensions
    {
        public static void COnfigureCors(this IServiceCollection services)=>
        services.AddCors(Options =>{
            Options.AddPolicy("CorsPoliCy"
            ,builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
        }
        );
    public static void CofigureRateLimiting(this IServiceCollection services){
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();
        services.Configure<IpRateLimitOptions>(options =>{
            options.EnableEndpointRateLimiting=true;
            options.StackBlockedRequests=false;
            options.HttpStatusCode=429;
            options.RealIpHeader="X-Real_IP";
            {
                new RateLimitRule{
                    Endpoint="*",
                    Period="10s",
                    Limit=2
                };
            }
        });
    }
    public static void AddAplicationServices(this IServiceCollection services){
        services.AddScoped<IUnitOfWork,UnitOfWork>();
    }
        
    }
}