﻿using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            short estatura;
            int edad;
            long enteroLargo;
            float enteroComaFlotante;
            double enteroDoble;

            uint enteroSinSigno; 

            string saludo = "hola";
            bool verdad;

            verdad = true;
            edad = 18;
            estatura = 170;

            int resultado = Suma(edad, estatura);

            Console.WriteLine(resultado.ToString());

        }

        private static int Suma(int a, int b){
            return (a + b);
        }
    }
}
