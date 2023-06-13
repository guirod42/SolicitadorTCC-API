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
    public class GestaoSolicitacaoContext : DbContext
    {
        public GestaoSolicitacaoContext(DbContextOptions<GestaoSolicitacaoContext> options) : base(options)
        {

        }

        public DbSet<Solicitacao> Solicitacao { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SolicitacaoMap());
        }
    }
}
