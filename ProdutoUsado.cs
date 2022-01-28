using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entidades
{
    internal class ProdutoUsado : Produtoss
    {

        public DateTime dataFabricacao;

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            this.dataFabricacao = dataFabricacao;
        }

        public sealed override string etiquetaPreco()
        {
            return nome + " (usado) R$" + preco +  ", ano de fabricação: " + dataFabricacao;
        }
    }
}
