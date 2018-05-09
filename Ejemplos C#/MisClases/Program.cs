using System;
using MisClases.Gente;

namespace MisClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto p = new Producto("0001", "Platanito");           
            // p.Codigo = "0001";
            // p.Nombre = "Platanito";
            //p.Precio = 0.10m;

            // var p2 = new Producto()
            // {
            //     Codigo = "0002",
            //     Nombre = "Mora Negra",
            //     Precio = 0.05m
            // };

            var p2 = new Producto("0002", "Mora Negra", 0.05m);

            var p3 = new Producto("0003", "Dentadura", 1);

            var p4 = new Producto("0004", "Fresa");


            Console.WriteLine(p.GetDescripcionProducto());
            Console.WriteLine(p2.GetDescripcionProducto());
            Console.WriteLine(p3.GetDescripcionProducto());
            Console.WriteLine(p4.GetDescripcionProducto());

            var yo = new Plebeyo("Beatriz", "Ruiz Peces", 25, Genero.Mujer, "Programadora");
            var otro = new Plebeyo("Gabriel", "Cano Mora", 36, Genero.Hombre, "Electricista");
            var otromas = new Plebeyo("Angel", "Gomez Limon", 27, Genero.Hombre, "Fontanero");

            var duque = new Aristocrata("Julian", "Muñoz Recio", 57, Genero.Hombre, "Duque");
            var condesa = new Aristocrata("Isolda", "Heraldo Marques", 28, Genero.Mujer, "Condesa");
            var marquesa = new Aristocrata("Maria", "Santos Tortosa", 41, Genero.Mujer, "Marquesa");
            
            PrintDatos(yo);
            PrintDatos(otro);
            PrintDatos(duque);
            PrintDatos(marquesa);

        }

        static void PrintDatos(Persona p)
        {
            Console.WriteLine(p.GetDatos());
        }
    }
}
