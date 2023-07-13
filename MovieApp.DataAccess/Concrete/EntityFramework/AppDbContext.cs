using K101MovieApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K101MovieApp.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("connection_string");
        }

        public DbSet<Film> FIlms { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> FIlms { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
    }
}
