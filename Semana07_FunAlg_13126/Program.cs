

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana07_FunAlg_13126
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaAlumno();
        }   
        static void NumeroPerfecto()
        {
            int suma = 0, num;
            Console.WriteLine("Ingrese el número: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma = suma + i;
                }
            }
            if (suma == num)
            {
                Console.WriteLine("Numero Perfecto");

            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
        }
        static void NumeroPerfectoWhile()
        {
            int num, suma = 0, div;
            //num=6
            Console.WriteLine("Ingrese un Número: ");
            num = int.Parse(Console.ReadLine());

            div = num-1;

            while (div>0)
            {
                if(num%div==0)
                {
                    suma = suma + div;
                }
                div--;
            }
            Console.WriteLine("Suma: " + suma);
            if (suma == num)
            {
                Console.WriteLine("Numero Perfecto");

            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
            Console.ReadKey();

        }
        static void NotaAlumno()
        {
            int num, suma = 0, div;
            //num=6
            Console.WriteLine("Ingrese un Número: ");
            num = int.Parse(Console.ReadLine());

            div = num - 1;
            do
            {
                if(num%div==0)
                {
                    suma = suma + div;
                }
                div--;
            }
            while (div>0);
            if (suma == num)
            {
                Console.WriteLine("Numero Perfecto");

            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
        }

    }
}
