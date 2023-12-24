using BotOS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotOS.Persistence.Config
{
    public sealed class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Hash).IsRequired();
            builder.Property(x => x.From).IsRequired();
            builder.Property(x => x.To).IsRequired();

        }
    }
}
