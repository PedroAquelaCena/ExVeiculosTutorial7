using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVeiculos.Entities
{
    public class Moto : Carro
    {
        public Moto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public void Inclinar()
        {
            Console.WriteLine("Inclinando");
        }
    }
}
