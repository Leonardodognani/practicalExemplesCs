using System;

namespace practicalExemplesCs
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }

        }

        static void instrucaoSwitches(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                Console.WriteLine("Nenhum argumentos");
                break;

                case 1:
                Console.WriteLine("Um argumentos");
                break;

                default:
                Console.WriteLine($"{numeroDeArgumentos} argumentos");
                break;
            }
        }

        static void instrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void instrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);

            } while(!string.IsNullOrEmpty(texto));
            {
                 
            }
        }
        
    }
}
