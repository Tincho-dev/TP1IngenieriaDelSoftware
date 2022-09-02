using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TP1IngenieriaDelSoftware.Model.Modelo> Modelo { get; set; } = default!;
    }
}
