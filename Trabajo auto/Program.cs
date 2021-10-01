using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_auto
{
    class Motor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el Tipo de motor");

            string a = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Cual es la Potencia del motor?");

            string b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Cual es el color del auto?");

            String c = Convert.ToString(Console.ReadLine());

            String resultado;
            resultado = a + b + c;

            Console.WriteLine("Tu motor es:");
            Console.WriteLine(a);
            Console.WriteLine("La potencia del motor es:");
            Console.WriteLine(b);
            Console.WriteLine("El color de tu vehiculo es:");
            Console.WriteLine(c);

            Console.WriteLine("Profe, no pude hacerlo de la forma que lo pidió pero lo hice de esta forma espero me pueda contar algo, ya había hablado con usted sobre lo que pasó");


            Console.ReadLine();



                






        }
    }
}
