using Microsoft.EntityFrameworkCore;
using Padawan.ControleFinanceiro.Model;

namespace Padawan.ControleFinanceiro.Context
{
    public class BancoContext : DbContext
    {
        //Construtores da classe BancoContext
        public BancoContext()
        {
        }
        //Referencia configurações do Startup da APIS
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        //Função de Configuração do banco quando utiliza biblioteca separada
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04840\\SQLEXPRESS01;Initial Catalog=Teste2;Integrated Security=True;MultipleActiveResultSets=True");
        }
        //Responsavél por inicializar Modelos no DBSet (todos em vez de um por um)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContext).Assembly);

            modelBuilder.Entity<Banco>().HasOne(p => p.Usuario).WithMany(p => p.Bancos).HasForeignKey(p => p.IdUsuario);
            modelBuilder.Entity<Carteira>().HasOne(p => p.Banco).WithMany(p => p.Carteiras).HasForeignKey(p => p.IdBanco);
            modelBuilder.Entity<Operacao>().HasOne(p => p.Categoria).WithMany(p => p.Operacoes).HasForeignKey(p => p.IdCategoria);
            modelBuilder.Entity<Operacao>().HasOne(p => p.Carteira).WithMany(p => p.Operacoes).HasForeignKey(p => p.IdCarteira);
        }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Banco> Bancos { get; set; }
    }


 
}
