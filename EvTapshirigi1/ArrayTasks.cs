using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshirigi1
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.Write("Massivin uzunlugunu daxil et: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int r = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass[{i}] = ");
                mass[i] = int.Parse(Console.ReadLine());
            }
            return mass;

        }

     
        internal int[] SquareRoot()
        { 
            int[] mass = EnterArray();
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                    Console.WriteLine(mass[i]);



            }
                    return mass;
            
        } 
    }
}

