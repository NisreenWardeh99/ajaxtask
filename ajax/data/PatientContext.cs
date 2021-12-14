using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ajax.data
{
    public class PatientContext :DbContext
    {
        public DbSet<pateint> patient1 { set; get; }
        public DbSet<Country> country1 { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=ajax;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
