using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reGraLogistica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double identificadorCerveja;
            double identificadorDia;
            Venda v = new Venda();
            Console.WriteLine("---------- MENU ------------\n 1-Informar uma venda" +
                "\n 2-Consultar o catálogo de cervejas" +
                "\n 3-Sair");
               
            opcao = int.Parse(Console.ReadLine());

            do
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Infome o identificador da cerveja em que a venda foi realizada: \n 1-Skol \n 2-Brahma \n 3-Stella \n 4-Boehmia");
                    identificadorCerveja = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de produtos vendidos: ");
                    double quantidadeProd = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o dia em que a venda foi realizada: \n 1-Domingo \n 2-Segunda \n 3-Terça  \n 4-Quarta \n 5-Quinta \n 6-Sexta \n 7-Sábado ");
                    identificadorDia = double.Parse(Console.ReadLine());

                    switch (identificadorCerveja)
                    {
                        case 1:
                            Console.WriteLine("O valor de cashback para essa venda foi de: $$" + v.GetSkol(quantidadeProd, identificadorDia));
                            break;
                        case 2:
                            Console.WriteLine("O valor de cashback para essa venda foi de: $$" + v.GetBrahma(quantidadeProd, identificadorDia));
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("O valor de cashback para essa venda foi de: $$" + v.GetStella(quantidadeProd, identificadorDia));
                            break;
                        case 4:
                            Console.WriteLine("O valor de cashback para essa venda foi de: $$" + v.GetBohemia(quantidadeProd, identificadorDia));
                            break;
                    }
                    Console.WriteLine("---------- MENU ------------\n 1-Informar uma venda" +
                "\n 2-Consultar o catálogo de cervejas" +
                "\n 3-Sair");
                    opcao = int.Parse(Console.ReadLine());
                }            
                else if (opcao == 2)
                {
                    Console.WriteLine("Infome o identificador da cerveja em que deseja consultar os valores de cashback: \n 1-Skol \n 2-Brahma \n 3-Stella \n 4-Boehmia");
                    identificadorCerveja = double.Parse(Console.ReadLine());
                    switch (identificadorCerveja)
                    {
                        case 1:
                            Console.WriteLine("\n Tabela de cashback por dia da cerveja: SKOL" + 
                                "\n DOMINGO | SEGUNDA | TERÇA | QUARTA | QUINTA | SEXTA | SÁBADO \n  25%    |    7%   |  6%   |    2%  |   10%  |  15%  |  20%  ");
                            break;
                        case 2:
                            Console.WriteLine("\n Tabela de cashback por dia da cerveja: BRAHMA" +
                                "\n DOMINGO | SEGUNDA | TERÇA | QUARTA | QUINTA | SEXTA | SÁBADO \n  30%    |    5%   | 10%   |   15%  |   20%  |  25%  |  30%  ");
                            break;
                        case 3:
                            Console.WriteLine("\n Tabela de cashback por dia da cerveja: STELLA" +
                                "\n DOMINGO | SEGUNDA | TERÇA | QUARTA | QUINTA | SEXTA | SÁBADO \n  35%    |    3%   |  5%   |    8%  |   13%  |  18%  |  25%  ");
                            break;
                        case 4:
                            Console.WriteLine("\n Tabela de cashback por dia da cerveja: BOEHMIA" +
                                "\n DOMINGO | SEGUNDA | TERÇA | QUARTA | QUINTA | SEXTA | SÁBADO \n  40%    |    10%  | 15%   |   15%  |   15%  |  20%  |  40%  ");
                            break;
                    }
                    Console.WriteLine("---------- MENU ------------\n 1-Informar uma venda" +
                "\n 2-Consultar o catálogo de cervejas" +
                "\n 3-Sair");
                    opcao = int.Parse(Console.ReadLine());
                }
                Console.ReadLine();
                
            }
            while (opcao != 3);
        }
    }
}

