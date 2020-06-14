using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContexto: DbContext
    {
        //Configuracao de todas as classes como BDSet (classes de Dominio)
        //Mesmo nome que irao para p BD
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //referencia às classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            //carga dados
            modelBuilder.Entity<FormaPagamento>()
                .HasData(
                    new FormaPagamento()
                    {
                        Id = 1,
                        Nome = "Boleto",
                        Descricao = "Forma pagamento boleto"
                    },
                    new FormaPagamento()
                    {
                        Id = 2,
                        Nome = "Cartão de crédito",
                        Descricao = "Forma pagamento cartão de crédito"
                    },
                    new FormaPagamento()
                    {
                        Id = 3,
                        Nome = "Depósito",
                        Descricao = "Forma pagamento depósito"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }


    }
}
