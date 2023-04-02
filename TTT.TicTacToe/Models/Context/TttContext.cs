using Microsoft.EntityFrameworkCore;

namespace TTT.TicTacToe.Models.Context
{
    public class TttContext : DbContext
    {
        public TttContext(DbContextOptions<TttContext> options) : base(options) { }
        public DbSet<PlayingField> Fields { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<PlayingField>().ToTable("TicTacToe");
    }
}
