using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVeiculos.Entities
{
    public class Veiculo
    {
       public string Marca;
        public string Modelo;

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void ToString()
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo}");
        }

        public void Mover()
        {
            Console.WriteLine("Movendo..");
        }
    }
}
