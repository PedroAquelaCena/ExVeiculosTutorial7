using ExVeiculos.Entities;

namespace ExVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carron = new("Bulgati", "Rx7", Entities.Enums.Color.PINK);

            Moto mottoun = new("Bieminhudabliu", "R1Milhao");

            carron.Mover();

            mottoun.Mover();

            mottoun.Inclinar();

            //upcasting 

            Veiculo carroUp = new Carro("Bmw", "M3", Entities.Enums.Color.GRAY);

            Veiculo motoUp = new Moto("Bmw", "R1200R");

            motoUp.Mover();

            carroUp.Mover();

            // Downcasting

            if (carroUp is Carro)
            {
                ((Carro)carroUp).Acelerar();
            }

            if (motoUp is Moto)
            {
                ((Moto)motoUp).Inclinar();

            }
        }
    }
}