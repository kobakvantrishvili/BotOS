using BotOS.Domain.Entities;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotOS.Persistence.Config
{
    public sealed class OfferConfig : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderHash).IsRequired();
            builder.Property(x => x.IsFulfilled).IsRequired();
            builder.Property(x => x.Criteria).IsRequired().HasJsonValueConversion();
            builder.Property(x => x.StartTime).HasColumnType("datetime"); ;
            builder.Property(x => x.EndTime).HasColumnType("datetime"); ;
        }
    }
}
