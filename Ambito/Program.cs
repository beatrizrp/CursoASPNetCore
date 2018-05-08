﻿using System;

namespace Ambito
{
    public class Program
    {
        static int cantidad;

        static void Main(string[] args)
        {
            int edad;
            string saludo;
            long delatierraAlaluna;

            var edad2 = 16;
            var otroNumero = 43968523.0f;
            var misaludo = "Hola";
            var LongitudGrande = 1890f;

            var miCantidad = SumaOResta(true);

            Console.WriteLine("Hello World!");
            Utils.EscribeConsola("Hola Mundo!!");

            Utils.EscribeConsola(Utils.Saluda("Pepe"));
        }

        public void EscribeCantidad(){
            Utils.EscribeConsola(cantidad.ToString());
        }

        public int RestarUno(){
            return cantidad =- 1;
        }

        public int SumarDos(){
            int dos = 2;
            return cantidad += dos;
        }

        public static int SumaOResta(bool opcion){
            var sumaesto = 15;
            if(opcion) // (if (opcion == true))
             {
                 return cantidad += sumaesto;
             }
             return cantidad -= sumaesto;
        }

    }

    class Utils{
        public static void EscribeConsola(string salida){
            Console.WriteLine(salida);
        }

        public static string Saluda(string nombre){
            string saludo = "Hola " + nombre;
            return saludo;
        }

    }
}
