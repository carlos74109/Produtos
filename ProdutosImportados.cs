using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entidades
{
    internal class ProdutosImportados : Produtoss
    {
        public double frete;

        public ProdutosImportados()
        {
        }

        public ProdutosImportados(string nome, double preco, double frete) : base(nome, preco)
        {
            this.frete = frete;
        }

        public double precoTotal()
        {
            return preco + frete;
        }

        public sealed override string etiquetaPreco()
        {
            return nome + " R$" + precoTotal() + " o frete no valor é de: R$" + frete + " já incluso no preço atual";
        }
    }
}
