using CardGame.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardGame.Data.Map
{
    public class PlayerMap : IEntityTypeConfiguration<PlayerModel>
    {
        public void Configure(EntityTypeBuilder<PlayerModel> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Cash).IsRequired().HasMaxLength(56);
        }
    }
}
