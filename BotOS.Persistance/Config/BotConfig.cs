using BotOS.Domain.Entities;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotOS.Persistence.Config
{
    public sealed class BotConfig : IEntityTypeConfiguration<Bot>
    {
        public void Configure(EntityTypeBuilder<Bot> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Address).IsRequired().HasMaxLength(42).IsFixedLength();
            builder.Property(x => x.PortfolioValue).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Tokens).HasJsonValueConversion();

            builder.HasMany(x => x.Collections).WithOne(x => x.Bot).HasForeignKey(x => x.BotId);
        }
    }
}
