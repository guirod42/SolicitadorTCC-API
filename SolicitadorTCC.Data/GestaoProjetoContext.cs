using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolicitadorTCC.Domain;
using SolicitadorTCC.Data.Mappings;

namespace SolicitadorTCC.Data
{
    public class GestaoProjetoContext : DbContext
    {
        public GestaoProjetoContext(DbContextOptions<GestaoProjetoContext> options) : base(options)
        {

        }

        public DbSet<Projeto> Projeto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjetoMap());
        }
    }
}
