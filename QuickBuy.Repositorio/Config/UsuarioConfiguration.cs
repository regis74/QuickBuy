using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            // utiliza o padrao Fluent (encadeado . . . )
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            //relacionamento 1 para muitos entre Usuario x Pedidos
            builder
                .HasMany(u => u.Pedidos) //configura como uma collection de pedido
                .WithOne(p => p.Usuario); //ligado a um unico usuario (somente um usuario pode ter determinado pedido e nao mais do mesmo usuario para o pedido

            //builder.Property(u => u.Pedidos);

        }
    }
}
