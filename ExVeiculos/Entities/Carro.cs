using ExVeiculos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExVeiculos.Entities
{
    public class Carro : Veiculo
    {
        public Color DaColor { get; private set; }

        public Carro(string marca, string modelo, Color colour) : base(marca, modelo)
        {
            DaColor= colour;
        }
        
        public void Acelerar()
        {
            Console.WriteLine("Carro acelerando..");
        }
    }
}
