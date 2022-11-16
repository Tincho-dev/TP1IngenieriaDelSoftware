using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TP1IngenieriaDelSoftware.Models.Modelo> Modelo { get; set; } = default!;
    }
}
