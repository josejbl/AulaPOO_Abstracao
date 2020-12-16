using System;
using Abitraçao.Classes;
namespace Abitraçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da compra");
            float valorDaCompra = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Selecine o tipo de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            Console.WriteLine("3 - Dinheiro");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: 
                //Boleto
                   Boleto boleto = new Boleto();
                   // boleto.V = valorDaCompra;
                   //Pagamento P = new Pagamento();
                   
                 

                    boleto.Reistrar(boleto.Valor, boleto.Data,boleto.CodigoDeBarras );
                    // Console.WriteLine($"O Valor da Compra fica em {boleto.Valor} e a data: {boleto.Data}");
                    break ;
                case 2:
                    Credito credito = new Credito();
                    
                    break ;
                    // case 3:
                    // Pagamento dinheiro = new Pagamento();
                    
                default:
                    break;
            }
            
        }
    }
}
