using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива. Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.
            //int[] array = { 10, 5, 8, 3, 7, 2 };
            //int firstElement = array[0];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == firstElement)
            //    {
            //        Console.WriteLine($" Элемент со значением {firstElement} найден на позиции {i + 1}.");
            //        break;
            //    }
            //}

            //Задача 2. Дан одномерный массив. Вывести:

            //а) все неотрицательные элементы;

            //б) все элементы, не превышающие число 100;

            //в) все четные элементы.

            //int[] array = { 25, 50, 75, 100, 125, 150 };

            //Console.Write("(а): Неотрицательные элементы: ");
            //foreach (int num in array)
            //{
            //    if (num >= 0)
            //        Console.Write($"{num} ");

            //}
            //int[] array = { 25, 50, 75, 100, 125, 150 };
            //Console.Write("\n (б): Элементы, не превышающие 100: ");
            //foreach (int num in array)
            //{
            //    if (num <= 100)
            //        Console.Write($"{num} ");
            //}

            //int[] array = { 25, 50, 75, 100, 125, 150 };
            //Console.Write("\n (в): Четные элементы: ");
            //foreach (int num in array)
            //{
            //    if (num % 2 == 0)
            //        Console.Write($"{num} ");
            //}

            //Задача 3. Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2. Подсчитать количество отрицательных элементов.
            //int[] array = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int negativeCount = 0;

            //foreach (int num in array)
            //{
            //if (num < 0)
            //negativeCount++;
            //}
            //Console.WriteLine($"\n : Количество отрицательных элементов: {negativeCount}");

            //Задача 4.Составьте программу вычисления среднего арифметического элементов с нечетными номерами.
            //int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //double sum = 0;
            //int count = 0;

            //for (int i = 0; i < array.Length; i += 2)
            //{
            //    sum += array[i];
            //    count++;
            //}
            //double average = count > 0 ? sum / count : 0;
            //Console.WriteLine($": Среднее арифметическое элементов с нечетными номерами: {average}");

            //Задача 5.Составьте программу увеличения всех элементов массива в 5 раз.
            //int[] array = { 2, 4, 6, 8, 10 };

            //Console.Write(": Массив после увеличения всех элементов в 5 раз: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] *= 5;
            //    Console.Write($"{array[i]} ");
            //}
            //Console.ReadKey();
        }
    }
}
