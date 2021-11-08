using System;

namespace Heranca
{
    class Conta
    {
        public int Numero { get; set; }
        private double _Saldo { get; set; }
       
        // A assinatura virtual permite a alteração do método (Polimorfismo).
        protected virtual void GetSaldo()
        {
            Console.WriteLine($"\n\nO saldo da conta de nº{Numero} é {_Saldo}");
        }

        public void SetSaldo(double saldo)
        {
            if(saldo >= 0)
            {
                _Saldo += saldo;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }

    class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }

        // Override indica a sobrescrição do método da classe pai.
        protected override void GetSaldo()
        {
            Console.WriteLine("Este é o método alteradaço e o valor de saldo agora é R$ 43462847234424,47");
        }

        public ContaPoupanca(int numero, double saldo)
        {
            Numero = numero;
            SetSaldo(saldo);
        }

        static void Main(string[] args)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca(42, 19.99);
            contaPoupanca.GetSaldo();
        }
    }
}
