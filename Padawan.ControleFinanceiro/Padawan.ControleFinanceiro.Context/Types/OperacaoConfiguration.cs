﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padawan.ControleFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padawan.ControleFinanceiro.Context.Types
{
    internal class OperacaoConfiguration : IEntityTypeConfiguration<Model.Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(p => p.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}
