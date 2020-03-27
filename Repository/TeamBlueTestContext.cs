using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;

namespace Repository
{
    public class TeamBlueTestContext : DbContext, ITeamBlueTestContext
    {
        public TeamBlueTestContext(DbContextOptions<TeamBlueTestContext> options) : base(options)
        {
        }

        public DbSet<UserInput> UserInputs { get; set; }
        public DbSet<WatchListWord> WatchListWords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamBlueTestContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
