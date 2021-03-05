using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3PONTO1EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora operacao1 = new Calculadora();

            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela  ");
            Console.WriteLine("a soma desses números com uma mensagem explicativa, conforme exemplos.\n");

            
            Console.Write("Digite o primeiro valor para somar: ");
            double leitura1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor para somar: ");
            double leitura2 = double.Parse(Console.ReadLine());

            operacao1.Soma(leitura1, leitura2);

            Console.WriteLine("\nO Resultado sa soma é: " + operacao1.Total);

            Console.ReadKey();
        }
    }
}
