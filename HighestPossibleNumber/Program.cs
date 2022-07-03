using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HighestPossibleNumber
{/// <summary>
/// Исключение 0 или 1
/// </summary>
    public static class Program
    {

        // Ваша задача состоит в том, чтобы создать функцию, 
        // которая может принимать любое неотрицательное целое число в качестве аргумента и возвращать его с цифрами в порядке убывания.
        // По сути, переставьте цифры, чтобы получить максимально возможное число.
        // Your task is to create a function
        // which can take any non-negative integer as an argument and return it with digits in descending order.
        // Essentially rearrange the numbers to get the highest possible number.
        static void Main(string[] args)
        {


            
           
           Console.WriteLine(Program.Kata.DescendingOrder(1));
            Console.ReadLine();
        }

        public static class Kata
        {
            public static int DescendingOrder(int num)
            {
                if (num > 1)
                {


                    int[] array = new int[(long)Math.Ceiling(Math.Log10(num))];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = num % 10;
                        num /= 10;
                    }
                    Array.Sort(array);
                    int result = array[array.Length - 1];
                    for (int i = array.Length - 2; i >= 0; i--)
                    {
                        result = 10 * result + array[i];
                    }


                    return result;
                }
                else if (num == 1)
                {
                    Console.WriteLine("Вы ввели не корректное число");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректное число");
                    return 0;
                }
            }
        }

    }
}
