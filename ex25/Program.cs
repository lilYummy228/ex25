using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int tempValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.Write($"{array[i]}|");
            }

            Console.Write("\nНа сколько вы хотите сдвинуть массив влево? ");
            int leftShiftCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < leftShiftCount; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    tempValue = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempValue;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}|");
            }

        }
    }
}
