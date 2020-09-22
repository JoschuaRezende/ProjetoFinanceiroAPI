using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Padawan.ControleFinanceiro.Context.Types
{
    public class BancoConfiguration : IEntityTypeConfiguration<Model.Banco>
    {
        public void Configure(EntityTypeBuilder<Model.Banco> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}
