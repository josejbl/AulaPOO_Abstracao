using System;


namespace Abitraçao.Classes
{
    public abstract class Pagamento
    {
        public string pagamentoDinheiro;
        private DateTime date;
        public DateTime Data{
            get{return DateTime.Now;}
        }

         protected float valor = 3000;

            
        public float Valor{
            get{return valor;}
        }
        public string Cancelar(){
            return"";
        }
    }
}