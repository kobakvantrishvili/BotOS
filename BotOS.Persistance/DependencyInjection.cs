using BotOS.Domain.Common;
using BotOS.Persistence.Repo;
using BotOS.Persistence.Repo.Abstraction;
using BotOS.Persistence.Repo.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace BotOS.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepository(configuration);
        }

        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureRepositories<BotOSDbContext>(services, typeof(IEntityBase).Assembly);

            var connectionString = configuration.GetConnectionString("BotOSConnectionString");

            services.AddDbContext<BotOSDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }

        // Helper
        private static void ConfigureRepositories<TContext>(IServiceCollection services, Assembly assembly)
            where TContext : DbContext
        {
            var entityTypes = assembly.GetExportedTypes().Where(x => x.IsAssignableTo(typeof(IEntityBase)) &&
                                                                     x.IsInterface is false &&
                                                                     x.IsAbstract is false);
            foreach (var entityType in entityTypes)
            {
                var serviceType = typeof(IRepository<>).MakeGenericType(entityType);
                var implementationType = typeof(Repository<,>).MakeGenericType(typeof(TContext), entityType);
                services.AddTransient(serviceType, implementationType);
            }
        }
    }
}
