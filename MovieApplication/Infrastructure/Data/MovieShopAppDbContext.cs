using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
    public class MovieShopAppDbContext:DbContext
    {
        public MovieShopAppDbContext(DbContextOptions<MovieShopAppDbContext> options) : base(options)
        { 
            
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Cast> Casts { get; set; }

    }
}
