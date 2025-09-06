using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desconto_Para_cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variaveis
            string nome, cartao;
            double idade, ano, compra, compra_final, compra1 =0, compra2 =0;

            //Cabeçalho
            Console.WriteLine("===== Calculo de Desconto =====");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            //Obter dados de entrada
            Console.Write("Informe o nome do cliente: ");
            nome = Console.ReadLine();
            Console.Write("Informe o ano em que o cliente nasceu: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Será utilizado cartão de desconto S/N: ");
            cartao = Console.ReadLine();
            Console.Write("Informe o valor da compra: ");
            compra = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            //calculo da idade
            idade = 2025 - ano;

            //Estrutura de condição para idade
            if (idade < 55)
            {
                compra1 = compra;
                Console.WriteLine($"Pela idade do cliente ({idade}), ele não possui descontos");
            }
            else if (idade >= 55 && idade <= 69)
            {
                compra1 = compra * 0.05;
                Console.WriteLine($"Pela idade do cliente({idade}), ele tera 5% de desconto");
            }
            else {
                compra1 = compra * 0.07;
                Console.WriteLine($"Pela idade do cliente({idade}), ele tera 7% de desconto");
            }

            //Estrutura condicional do cartão
            if (cartao == "s" || cartao == "S") {
                compra2 = compra1  * 0.05;
                Console.WriteLine("O cliente terá mais 5% de desconto por utilizar o cartão.");
            }
            else {
                Console.WriteLine("O cliente não tem desconto de cartão fidelidade.");
            }
            compra_final = compra1 - compra2;
            Console.WriteLine($"O valor final da compra de {nome} será de {compra_final:c2}");
        }   
    }
}
