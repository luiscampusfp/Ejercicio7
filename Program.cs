using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un numero");
            double n= double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Logaritmo: " + CalculosNumericos.Logaritmo(n));
                Console.WriteLine("Raiz Cuadrada: " + CalculosNumericos2.RaizCuadrada(n));
            }
            catch (Exception ex) { }
            Console.ReadLine();
        }
    }

    public class CalculosNumericos {
        public static double Logaritmo(double n) {
            if (n < 0) {
                throw new ArithmeticException();
            }
            return Math.Log(n);
        }
    }

    public class CalculosNumericos2 {
        public static double RaizCuadrada(double n) {
            if (n < 0)
            {
                throw new ArithmeticException();
            }
            return Math.Sqrt(n);
        }
    }
}
