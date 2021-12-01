using System;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            teste();
            multiplica();

        }

        static void teste()
        {
            int a, b, c;
        Console.Write("estamos somando, então coloque um numero para somar: ");
          a  =   int.Parse(Console.ReadLine());
        Console.Write("agora coloque o outro numero para somar: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
        Console.WriteLine("esse foi o resultado: " + c);

        }

        static void multiplica()
        { int a, b, c;
            Console.Write("agora estamos multiplicando, coloque um numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("vezes: ");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine(" é igual a: " + c);
            Console.ReadKey();
            
        }
    }
}
