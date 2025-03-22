using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<PGNFile> PGNFiles { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext() : base("name=DefaultConnection")        
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MoveListItem>();

            modelBuilder.Entity<Game>().ToTable("Games");
            modelBuilder.Entity<PGNFile>().ToTable("PGNFiles");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Ignore<MoveListItem>();

            modelBuilder.Entity<Game>()
                .HasRequired(g => g.User)
                .WithMany(u => u.Games)
                .HasForeignKey(g => g.UserID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
