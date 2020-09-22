using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Padawan.ControleFinanceiro.Context.Types
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Model.Usuario>
    {
        public void Configure(EntityTypeBuilder<Model.Usuario> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Login).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Senha).HasMaxLength(50).IsRequired();
        }
    }
}