using CardGame.Data.Map;
using CardGame.Entities;
using CardGame.Model;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Data
{
    public class CardGameDBContext : DbContext
    {

        public CardGameDBContext(DbContextOptions<CardGameDBContext> options) : base(options) 
        { 
        }

        public DbSet<PlayerModel> Player { get; set; }
        public DbSet<GameCards> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerMap());
            modelBuilder.ApplyConfiguration(new CardGameMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
