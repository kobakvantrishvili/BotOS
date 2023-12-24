using BotOS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotOS.Persistence.Config
{
    public sealed class CollectionConfig : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Slug).IsRequired();
            builder.Property(x => x.ContractAddress).IsRequired();
            
            builder.HasOne(x => x.Bot).WithMany(x => x.Collections).HasForeignKey(x => x.BotId);
            builder.HasMany(x => x.Nfts).WithOne(x => x.Collection).HasForeignKey(x => x.CollectionId);
        }
    }
}
