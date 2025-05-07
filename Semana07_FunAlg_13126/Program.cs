

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
            int suma=0, num;
            Console.WriteLine("Ingrese el número: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if(num%i==0)
                {
                    suma = suma + i;
                }
            }
            if(suma==num)
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
