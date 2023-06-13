using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolicitadorTCC.Domain;

namespace SolicitadorTCC.Data.Mappings
{
    public class SolicitacaoMap : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("Solicitacao");
            builder.HasKey(x => x.SolicitacaoID);
        }
    }
}
