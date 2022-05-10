using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //namespace, classe, metodo
            System.Console.WriteLine("prodotto tra i due numeri: {0}",
                Mol());
        }
        static int Mol()
        {
            int v1, v2;
            System.Console.WriteLine("inserisci primo numero");
            //int v1 = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out v1))
            {
                System.Console.WriteLine("Non hai inserito un intero");
                System.Environment.Exit(1);

            }
            System.Console.WriteLine("inserisci secondo numero");
            //int v2 = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                System.Console.WriteLine("Non hai inserito un intero");
                System.Environment.Exit(1);

            }
            return v1 * v2;
        }
    }
}