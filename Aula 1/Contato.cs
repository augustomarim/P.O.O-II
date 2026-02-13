using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Contato(string nome, string numero, int idade)
    {
        public string nome { get; set; } = nome;
        public string numero { get; set; } = numero;
        public int idade { get; set; } = idade;

    }
}
