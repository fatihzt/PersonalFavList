using Microsoft.EntityFrameworkCore;
using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Core
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:fatihserver.database.windows.net,1433;Initial Catalog=PersonalFavList;Persist Security Info=False;User ID=fatihzt;Password=password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FavoriteList> FavoriteList { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Song>  Song { get; set; }

    }
}