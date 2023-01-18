using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] _)
        {

            string nomeCompleto;
            int quartos;
            double preco;


            Console.WriteLine("Qual é o seu nome completo? ");
            nomeCompleto = (Console.ReadLine());
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura ");


            string[] v = Console.ReadLine().Split(' ');
            string ultimoNome = v[0];
            string idade = v[1];
            string altura = v[2];

            Console.WriteLine("Você escreveu: ");

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            
            Console.WriteLine(Console.ReadLine());


            Console.ReadLine();
        }
    }
}