using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Carro
    {
        public string? Modelo { get; set; }
        public int Ano {  get; set; }
        public float Velo {  get; set; }

        public void Acelerar()
        {
            Velo++;
            Console.WriteLine($"Velocidade é {Velo}");
        }

        public void Freiar()
        {
            Console.WriteLine($"Freiando a partir de {Velo}");
            Velo--;
        }

    }
}
