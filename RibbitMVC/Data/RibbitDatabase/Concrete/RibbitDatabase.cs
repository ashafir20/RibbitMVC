using System.Data.Entity;
using RibbitMVC.Models;

namespace RibbitMVC.Data.RibbitDatabase.Concrete
{
    public class RibbitDatabase : DbContext
    {
        public RibbitDatabase() : base("RibbitConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Ribbit> Ribbits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Followers)
                .WithMany(u => u.Following)
                .Map(map =>
                {
                    map.MapLeftKey("FollowingId");
                    map.MapRightKey("FollowerId");
                    map.ToTable("Follow");
                });

            modelBuilder.Entity<User>().HasMany(u => u.Ribbits);

            base.OnModelCreating(modelBuilder);
        }
    }
}