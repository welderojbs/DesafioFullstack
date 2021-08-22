using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioFull.Models;

namespace DesafioFull.Data
{
    public class DesafioFullContext : DbContext
    {
        public DesafioFullContext (DbContextOptions<DesafioFullContext> options)
            : base(options)
        {
        }

        public DbSet<Titulos> Titulos   { get; set; }
        public DbSet<Parcelas> Parcelas { get; set; }
    }
}
