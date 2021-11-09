using System;

namespace TPFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();

            ConsoleKeyInfo continuar;
            do
            {
                
                Console.WriteLine("Continuar? (s/n)");
                continuar = Console.ReadKey(true);
            }while (continuar.KeyChar!='n' && continuar.KeyChar!='N');
        }
    }
}