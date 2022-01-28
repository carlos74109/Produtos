using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produtos.Entidades;
namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos produtos vc quer comprar? ");
            int qtdeProdutos = int.Parse(Console.ReadLine());

            List<Produtoss> produtos = new List<Produtoss>();

            for(int i = 0; i < qtdeProdutos; i++)
            {
                Console.WriteLine("o produto é novo, usado, importado (n/u/i)? ");
                string selecionarProduto = Console.ReadLine();

                Console.WriteLine("Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());

                if (selecionarProduto == "n")
                {
                    produtos.Add(new Produtoss(nomeProduto, precoProduto));

                }else if (selecionarProduto == "u")
                {

                    Console.WriteLine("Digite a data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nomeProduto, precoProduto, data));
                
                }else if (selecionarProduto == "i")
                {
                    Console.WriteLine("Digite o valor do frete: ");
                    double frete = double.Parse(Console.ReadLine());                
                    produtos.Add(new ProdutosImportados(nomeProduto, precoProduto, frete));

                }
            }

            foreach(Produtoss produtoss in produtos)
            {
                Console.WriteLine(produtoss.etiquetaPreco());
            }

        }
    }
}
