using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class AgendaTelefonica
    {
        Dictionary<String, String> dictonary = new();

        public void inserir(String nome, String numero)
        {
            dictonary.Add(nome, numero);
        }

        public String buscarNumero(String nome)
        {
            foreach (KeyValuePair<string, string> item in dictonary)
            {
                if(item.Key == nome)
                {
                    return item.Value;
                }
           
            }
            Console.WriteLine("Numero não achado");
            return null;
        }
     }
}
