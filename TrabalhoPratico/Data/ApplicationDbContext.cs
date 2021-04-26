using TrabalhoPratico.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Anime>().HasData(
                new Anime { }
            );

            modelBuilder.Entity<Episodios>().HasData(
                new Episodios { }
            );

            modelBuilder.Entity<Users>().HasData(
                new Users { }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { }
            );

            modelBuilder.Entity<UsersAnimes>().HasData(
                new UsersAnimes { }
            );

            modelBuilder.Entity<UsersEpisodios>().HasData(
                new UsersEpisodios { }
            );
        }
        
    }
}
