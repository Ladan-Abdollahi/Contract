using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Reporter.DataModelLayer
{
    public  class Contract_ReporterDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(.)\\mssqllocaldb;Database=Contract_ReporterDB;Trusted_Connection=True;");
        }
    }
}
