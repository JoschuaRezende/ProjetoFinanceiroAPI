using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Context.Types
{
    public class CarteiraConfiguration : IEntityTypeConfiguration<Model.Carteira>
    {
        public void Configure(EntityTypeBuilder<Carteira> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}
