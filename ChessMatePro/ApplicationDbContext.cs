using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("YourConnectionStringHere");
        //}

        public class DbContextOptionsBuilder
        {
            internal void UseSqlServer(string v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
