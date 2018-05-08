using System;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Sentencias de control de código

            // If - Else

            Console.WriteLine("Pulsa una tecla...");
            var a = Console.ReadKey();
            var teclaPulsada = a.KeyChar;

            if (teclaPulsada == '5')
            {
                Console.WriteLine("Has pulsado 5");
            }
            else if (teclaPulsada == '8')
            {
                Console.WriteLine("Has pulsado 8");
            }
            else 
            {
                Console.WriteLine("Verte a saber...");
            }

            // Switch

            switch(teclaPulsada)
            {
                case 'a':
                    Console.WriteLine("Añadir elemento");
                    break;
                case 'e':
                    Console.WriteLine("Eliminar elmento");
                    break;
                case 'l':
                    Console.WriteLine("Listar elmento");
                    break;
                default:
                    break;
            }

            // Iteraciones

            // While 

            int i = 0;

            while(i < 5)
            {
                Console.WriteLine(i++);
            }

            // Do While

            int x = 0;
            do {
                Console.WriteLine(x++);
            } while(x < 7);

            // for
            Console.WriteLine("Ejecutando for");

            for(int b = 0; b < 10; b++)
            {
                Console.WriteLine(b);
            }

            Console.ReadKey();



        }
    }
}
