using System;
using System.ComponentModel.Design;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                double xA, xB, xC, yA,yB,yC, maior;

                Console.WriteLine("Entre com as medidas do trinago X: ");
                xA = double.Parse(Console.ReadLine(),CI );
                xB = double.Parse(Console.ReadLine(), CI);
                xC = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Entre com as medidas do trinago Y: ");
                yA = double.Parse(Console.ReadLine(), CI);
                yB = double.Parse(Console.ReadLine(), CI);
                yC = double.Parse(Console.ReadLine(), CI);

                double p = (xA + xB + xC) / 2.0;
                double Areax = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
               
                p = (yA + yB + yC) / 2.0;
                double AreaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

                Console.WriteLine("Área de x = " + Areax.ToString("F4", CI));
                Console.WriteLine("Área de y = " + AreaY.ToString("F4", CI));

                if (Areax > AreaY)
                {
                    Console.WriteLine("Maior área X: ");
                }
                else
                {
                    Console.WriteLine("Maior área y: ");
                }
            }
        }
    }
}