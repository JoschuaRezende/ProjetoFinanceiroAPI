using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.ControleFinanceiro.Context.Types
{
    class CategoriaConfiguration : IEntityTypeConfiguration<Model.Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(q => q.Id);
        }
    }
}
