using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuario pode ter nenhum, um ou muitos pedidos
        /// virtual - vermite que o EF faça sobreposicao da collection para alimenta-la em tempo de execucao 
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; } //vai estar como HasMany

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada");

        }
    }
}
