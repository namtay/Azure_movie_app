using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using budget_app.Models;

namespace budget_app.Data
{
    public class budget_appContext : DbContext
    {
        public budget_appContext (DbContextOptions<budget_appContext> options)
            : base(options)
        {
        }

        public DbSet<budget_app.Models.Movie> Movie { get; set; } = default!;
    }
}
