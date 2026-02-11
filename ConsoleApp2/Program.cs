using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AgendaTelefonica a = new();

            a.inserir("lana", "123");
            string b = a.buscarNumero("lana");
            Console.WriteLine($"{b}");



            //Carro c01 = new();
            //c01.Velo = 100;
            //c01.Acelerar();
            //c01.Freiar();

            //Carro c02 = new();
            //c02.Velo = 200;

            //Carro c03 = new()
            //{
            //    Velo = 100,
            //    Ano = 200,
            //    Modelo = "Renault"
            //};

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("A Louca");
            //int idade = 18;
            //var idade2 = 19;

            //if(idade >= 18)
            //{
            //    Console.WriteLine("A Louquissima");
            //}
            //else
            //{
            //    Console.WriteLine("Flopou Yaoguang");
            //}

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i}: A Louca do C#");
            //}
        }
    }
}
