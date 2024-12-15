using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CA1VNBL;database=WordStock;integrated security=true;encrypt=false;");

        }
        public DbSet<Score>Scores { get; set; }
        public DbSet<Dictionary>Dictionaries { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
    }
}
