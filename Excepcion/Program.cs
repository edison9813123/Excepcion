using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion
{
    class Program
    {
        public class ExceptionTest
        {
            static double SafeDivision(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                return x / y;
            }

            public static void Main()
            { 
                //se puede cambiar los valores para que salga o no la excepcion.
                
                double a = 100, b = 0;
                double result;

                try
                {
                    result = SafeDivision(a, b);
                    Console.WriteLine("{0} divido por {1} = {2}", a, b, result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nose puede dividir por cero.");
                    
                }
            }
        }
    }
}







