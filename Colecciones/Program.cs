using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Colecciones
            // Lista de elementos que se trata como una unidad
            // Permite manipular su contenido

            // Matriz
            string[] listaNombres = {"Antonio", "Bea", "Mario", "Jose"};

            Console.WriteLine("Elementos en la lista: " + listaNombres.Length);

            for(int i = 0; i < listaNombres.Length; i++)
            {
                Console.WriteLine(listaNombres[i]);
            }

            //Lista
            //List<tipo>

            List<decimal> precios = new List<decimal>();
            precios.Add(23.15m);
            precios.Add(22.50m);
            precios.Add(11.23m);
            precios.Add(5.10m);

            var miPrecio = precios[2]; // 11.23      

            var p1 = new Producto("1", "Mahou", 1.50);            
            var p2 = new Producto("2", "Alhambra", 3);
            var p3 = new Producto("3", "Amstel", 2.70);

            var productos = new List<Producto>();     
            productos.Add(p1);
            productos.Add(p2);
            productos.Add(p3);
            productos.Add(new Producto("4", "Cruzcampo", 0.75));
            productos.Add(new Producto("5", "Mahou Negra", 2));

            productos.Remove(p2);
            Console.WriteLine( "¿Dónde está p3? \n Posición: " + productos.IndexOf(p3));
            

            // Lambda
            // Función anónima

            var mahou = productos.Where(p => p.Nombre.ToUpper().Contains("MAH"));
            Console.WriteLine("¿Hay Mahou? "+ mahou.Any());
            ListarProductos(mahou.ToList());

            ListarProductos(productos);
            IncrementaPrecio(productos, 5);
            ListarProductos(productos);

        }

        private static void IncrementaPrecio(List<Producto> productos, double porcentaje)
            {
                var porcentajeAAplicar = 1 + (porcentaje/100);
                foreach (var producto in productos)
                {
                    producto.Precio += producto.Precio * porcentajeAAplicar;
                }
            } 
        
        private static void ListarProductos(List<Producto> productos)
        {
            Console.WriteLine("Productos disponibles...");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Codigo + " " + producto.Nombre + " " + producto.Precio);
            }
        }
    }

    public class Producto
    {
        public string Codigo { get; set;}
        public string Nombre { get; set;}

        public double Precio { get; set;}

        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
