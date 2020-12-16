using System;

namespace Abitraçao.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "1326554.353436475.2233242425.423243657698";

        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Reistrar(float valor, DateTime dataEmissao,string codigoDeBarras, string pagamentoDinheiro){
            Console.WriteLine($"O valor da compra fica em{this.Valor*0.88f}com desconto de 12%");
            Console.WriteLine($"Data de emissão = {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de Barras = {codigoDeBarras}");
            Console.WriteLine($"Pagamento em Dinheiro = {pagamentoDinheiro}");
        }

        internal void Reistrar(float valor, DateTime data, string codigoDeBarras)
        {
            throw new NotImplementedException();
        }
    }
}