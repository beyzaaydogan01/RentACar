﻿
using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using System.Runtime.CompilerServices;

namespace Persistence;

public static class PersitenceServiceRegistration
{
    public static IServiceCollection AddPersitenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("nArchitecture"));
        services.AddScoped<IBrandRepository, BrandRepository>();

        return services;
    }
}
