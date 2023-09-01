using BotOS.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BotOS.Persistence.Repo
{
    public sealed class BotOSDbContext : DbContext
    {
        public BotOSDbContext(DbContextOptions<BotOSDbContext> options) 
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            InitializeDbContext(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public void InitializeDbContext(ModelBuilder modelBuilder)
        {
            foreach (var type in typeof(IEntityBase).Assembly
             .GetExportedTypes().Where(x => x.IsGenericType is false &&
                                            x.IsInterface is false &&
                                            x.IsEnum is false))
                if (type.IsAssignableTo(typeof(IEntityBase)))
                    modelBuilder.Entity(type);
        }
    }
}
