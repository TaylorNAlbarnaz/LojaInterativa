using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDLojaInterativa.Models;

namespace CRUDLojaInterativa.Data
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<CRUDLojaInterativa.Models.Fabricante> Fabricante { get; set; } = default!;

        public DbSet<CRUDLojaInterativa.Models.Produto> Produto { get; set; }
    }
}
