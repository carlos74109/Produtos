using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Entidades
{
    internal class Produtoss
    {
        public string nome;
        public double preco;

        public Produtoss()
        {
        }

        public Produtoss(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public virtual string etiquetaPreco()
        {
            return nome+ " R$" + preco;
        }
    }
}
