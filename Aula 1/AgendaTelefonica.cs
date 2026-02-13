using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AgendaTelefonica
    {
        Dictionary<String, Contato> dictonary { get; set; }

        public AgendaTelefonica() => dictonary = [];

        public void inserir(String nome, Contato contato)
        {
            if (dictonary.ContainsKey(nome))
            {
                Console.WriteLine("Contato já existente");
            }
            else
            {
                dictonary.Add(nome, contato);
            }

        }

        public Contato buscarNumero(String nome)
        {

            if (dictonary.ContainsKey(nome))
            {
                return dictonary[nome];
            }
            else
            {
                Console.WriteLine("Numero não achado");
                return null;
            }
        }

        public int tamanho()
        {
            return dictonary.Count;
        }

        public void remover(String nome)
        {
            dictonary.Remove(nome);
        }
    }
}