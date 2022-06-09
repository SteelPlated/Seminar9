/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

using System;
namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Показать натуральные числа от 1 до N , N задано
            Console.Write(" задайте число : ");
            int n = int.Parse(Console.ReadLine());
            NaturalNumber(n);
            Console.ReadKey();
        }
        static void NaturalNumber(int num)
        {
            if (num == 0) return;
            NaturalNumber(num - 1);
            Console.Write($" {num} ");
        }
    }
}