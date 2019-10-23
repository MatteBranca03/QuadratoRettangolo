using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratoRettangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo lato");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo lato");
            double b = double.Parse(Console.ReadLine());
            double perimetro = 0;
            double area = 0;
            if (a == b)
            {
                Console.WriteLine("è un quadrato");
                perimetro = (a * 4);
                area = (a * b);
                Console.WriteLine($"il perimetro è {perimetro} e l'area è {area}");
            }
            else
            {
                Console.WriteLine("è un rettangolo");
                perimetro = (a + b) * 2;
                area = (a * b);
                Console.WriteLine($"il perimetro è {perimetro} e l'area è {area}");
            }
            
            Console.ReadLine();
        }
    }
}
