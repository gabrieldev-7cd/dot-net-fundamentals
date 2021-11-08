using System;

namespace HerancaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var Carro = new Carro("C#30M3LH0R");
            Carro.Teste();
            Console.ReadLine();
        }
    }

    public class Veiculo
    {
        private string numeroChassis;

        public Veiculo(string _numeroChassis)
        {
            numeroChassis = _numeroChassis;

            Console.WriteLine($"Inicializando Veiculo com o nº chassi: {_numeroChassis}");
        }

        public Veiculo()
        {
            Console.WriteLine("Inicializando veiculo sem registro");
        }
        
        public virtual void Teste()
        {
            Console.WriteLine("Método Teste Acessado!");
        }

    }

    public class Carro : Veiculo
    {
        public Carro(string numeroChassis): base(numeroChassis)
        {
            //Inicializar outros campos da classe carro;
            Console.WriteLine($"Inicializando Carro com nª chassi: {numeroChassis}");
        }

        public Carro()
        {
            Console.WriteLine("Inicializando Carro sem registro");
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("Sobrescrevi o método Teste");
        }

    }
}
