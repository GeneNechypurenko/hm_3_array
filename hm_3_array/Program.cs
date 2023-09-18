using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hm_3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("task 1\r\n");

                int lenght = 9;
                int[] arr = new int[lenght];

                int min = 0, max = 9;
                Random rand = new Random();

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(min, max);
                }

                Console.Write("Array elements are: ");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                int evenCount = 0;
                int oddCount = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }

                int uniqueCount = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    bool isUnique = true;

                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }

                    if (isUnique)
                    {
                        uniqueCount++;
                    }
                }

                Console.WriteLine($"Even = {evenCount}");
                Console.WriteLine($"Odd = {oddCount}");
                Console.WriteLine($"Unique = {uniqueCount}");

                Console.WriteLine("\r\n\t *** \r\n");
            }

            {
                Console.WriteLine("task 2\r\n");

                int row = 3, col = 4;
                int[,] arr2d = new int[row, col];

                Random rand = new Random();
                int minRand = 0;
                int maxRand = 99;

                for (int i = 0; i < arr2d.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                    {
                        arr2d[i, j] = rand.Next(minRand, maxRand);
                    }
                }

                for (int i = 0; i < arr2d.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                    {
                        Console.Write(arr2d[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                int minValue = arr2d[0, 0];
                int maxValue = arr2d[0, 0];

                for (int i = 0; i < arr2d.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2d.GetLength(1); j++)
                    {
                        if (minValue > arr2d[i, j])
                        {
                            minValue = arr2d[i, j];
                        }
                        if (maxValue < arr2d[i, j])
                        {
                            maxValue = arr2d[i, j];
                        }
                    }
                }

                Console.WriteLine($"\nmin element value is {minValue}");
                Console.WriteLine($"max element value is {maxValue}");

                Console.WriteLine("\r\n\t *** \r\n");
            }

            {
                Console.WriteLine("task 3\r\n");

                Console.Write("Enter string: ");
                string sentence = Console.ReadLine();

                string vowels = "AEIOUaeiou";
                int countVowels = 0;

                foreach (char character in sentence)
                {

                    if (vowels.Contains(character))
                    {
                        countVowels++;
                    }
                }

                Console.WriteLine($"Quantity of vowels in sentence = {countVowels}");

                Console.WriteLine("\r\n\t *** \r\n");
            }
        }
    }
}
