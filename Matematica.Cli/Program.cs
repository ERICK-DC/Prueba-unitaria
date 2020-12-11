using System;

namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            var primerNumero = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            var segundoNumero = Console.ReadLine();
            Console.WriteLine("La suma de los dos números es: ");
            var calculadora = new Matematica.Negocio.Calculadora();
            var resultado = calculadora.Sumar(int.Parse(primerNumero), int.Parse(segundoNumero));
            Console.WriteLine("La suma de los dos números es: "+ resultado);
        }
    }
}
