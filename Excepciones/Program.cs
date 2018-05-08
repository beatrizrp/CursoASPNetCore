using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Program myProgram = null;
                // Console.WriteLine(myProgram.ToString());

                var motorDiesel = new Motor ("Diesel", 15);
                var furgo = new Vehiculo (motorDiesel);
                furgo.Arrancar();

                var motorGasolina = new Motor ("Gasolina", 20);
                var coche = new Vehiculo (motorGasolina);
                coche.Arrancar();

                var motorGas2 = new Motor ("Gasolina", 0);
                var moto = new Vehiculo (motorGas2);
                coche.Arrancar();

                throw new NullReferenceException();


            }
            catch (System.NullReferenceException ex)
            {
                // Huy Pues parece que no hay errores
                // Pues no! Hay errores pero no los capturas!
                
                Console.WriteLine("Error de referencia nula: " + ex.Source);
            }
            // catch (System.Exception)
            // {
            //     // Hay un errror, enviamos un mal de socorro...
            // }
            
            Console.WriteLine("La vida sigue...");
        }
    }

    public class MotorException : Exception
    {
       public MotorException(string message) : base(message)
       {
           
       } 
    }

    public class Vehiculo
    {
        public Motor Motor { get; set;}

        public Vehiculo (Motor motor)
        {
            Motor = motor;
        }

        public void Arrancar()
        {
            if(!string.IsNullOrEmpty(Motor.Combustible) && Motor.Litros >0)
            {
                // El motor arranca
                Console.WriteLine("Brrrrroooooooommmmm..");
            }
            else
            {
                // No podemos arrancar
                throw new ArgumentException("No se ha especificado combustible para el motor o no hay combustible.");
            }
        }
    }

    public class Motor
    {
        public string Combustible { get; set;}
        public int Litros { get; set;}

        public Motor (string combustible, int litros)
        {
            if(string.IsNullOrEmpty(combustible))
            throw new MotorException("Debe indicar un combustible");

            if(litros <= 0)
            {
                throw new ArgumentException("Litros debe ser mayor que cero.", "litros");
            }

            Combustible = combustible;
            Litros = litros;
        }
    }
}
