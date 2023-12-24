using BotOS.Domain.Entities;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotOS.Persistence.Config
{
    public sealed class NftConfig : IEntityTypeConfiguration<Nft>
    {
        public void Configure(EntityTypeBuilder<Nft> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TokenId).IsRequired();
            builder.Property(x => x.IsDisabled).IsRequired();
            builder.Property(x => x.IsSuspicious).IsRequired();
            builder.Property(x => x.Traits).HasJsonValueConversion();
            builder.Property(x => x.Rarity).HasJsonValueConversion();

            builder.HasOne(x => x.Collection).WithMany(x => x.Nfts).HasForeignKey(x => x.CollectionId);
        }
    }
}
