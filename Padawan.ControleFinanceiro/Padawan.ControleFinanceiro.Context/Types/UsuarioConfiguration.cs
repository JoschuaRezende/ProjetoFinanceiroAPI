using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Padawan.ControleFinanceiro.Context.Types
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Model.Usuario>
    {
        public void Configure(EntityTypeBuilder<Model.Usuario> builder)
        {
            builder.HasKey(q => q.Id);
        }
    }
}