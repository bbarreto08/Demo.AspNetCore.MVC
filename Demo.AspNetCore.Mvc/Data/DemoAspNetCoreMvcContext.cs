using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.AspNetCore.Mvc.Models
{
    public class DemoAspNetCoreMvcContext : DbContext
    {
        public DemoAspNetCoreMvcContext (DbContextOptions<DemoAspNetCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Demo.AspNetCore.Mvc.Models.Filme> Filme { get; set; }
    }
}
