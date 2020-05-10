using System;

namespace Corretora
{
    class Program 
    {
        static void troca(ref int x, ref int y)
        {
            var tmp = x;
            x = y; y = tmp;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 100;
            Console.WriteLine("Antes da Troca\nx = " + x + "\ny = " + y);
            troca(ref x, ref y);
            Console.WriteLine("Depois da troca\nx = " + x + "\ny = " + y);
            Console.ReadLine();
        }
    }
}
