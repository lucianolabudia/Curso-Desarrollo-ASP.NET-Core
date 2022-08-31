using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiPrimeraAplicacionCore.Models;

namespace MiPrimeraAplicacionCore.Data
{
    public class MiPrimeraAplicacionCoreContext : DbContext
    {
        public MiPrimeraAplicacionCoreContext (DbContextOptions<MiPrimeraAplicacionCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MiPrimeraAplicacionCore.Models.Cliente> Cliente { get; set; } = default!;
    }
}
