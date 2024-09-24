using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Data
{
    public class ZustDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
        public ZustDbContext(DbContextOptions<ZustDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ZustDB;Integrated Security=True;", b => b.MigrationsAssembly("Zust.WebUI"));
        }
    }
}
