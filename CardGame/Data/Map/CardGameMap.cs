using CardGame.Entities;
using CardGame.Enums;
using CardGame.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardGame.Data.Map
{
    public class CardGameMap : IEntityTypeConfiguration<GameCards>
    {
        public void Configure(EntityTypeBuilder<GameCards> builder)
        {
            builder.HasKey(x => x.CardId);
            builder.Property(x => x.Value).HasMaxLength(56);
            builder.Property(x => x.Type).HasMaxLength(56);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}