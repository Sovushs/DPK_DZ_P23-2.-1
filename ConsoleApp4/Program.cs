using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Привет, мир!");
            Thread.Sleep(5000);
        }

        static int Task2(int a, int b)
        {
            return a + b;
        }

        static string Task3(string a)
        {
            return Convert.ToString(a.Length);
        }

        static int Task4(int[] array)
        {
            int sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum / array.Length;

        }

        static bool Task5(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Task6(int a, int b)
        {
            if (a > b) return 0;
            if (a < b) return 1;
            else return 2;
        }

        static string Task7(string a)
        {
            return a.ToUpper();
        }

        static int Task8(int a, int b)
        {
            return a * b;
        }

        static int Task9(string[] array)
        {
            return array.Length;
        }

        static string Task10(string variable)
        {
            return new string(variable.Reverse().ToArray());
        }

        static int Task11(int a, int b)
        {
            return a % b;
        }

        static int Task12(int[] array)
        {
            return array.Min();
        }
        static bool Task13(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        static void Task14(string[] array)
        {
            Array.Sort(array);
        }
        static int Task15(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static string Task16(string input)
        {
            return input.Replace(' ', '_');
        }
        static int[] ParseInputToArray(string input)
        {
            return input.Split(' ').Select(s => int.TryParse(s.Trim(), out int num) ? num : 0).ToArray();

        }
        static int[] Task17(int[] array1, int[] array2)
        {
            HashSet<int> set1 = new HashSet<int>(array1);
            HashSet<int> set2 = new HashSet<int>(array2);
            set1.IntersectWith(set2);
            return set1.ToArray();
        }
        static void Task18(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y', 'u', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            foreach (char letter in input)
            {
                if (Array.IndexOf(vowels, char.ToLower(letter)) != -1)
                {
                    Console.Write(letter + " ");
                }
            }
        }
        static long Task19(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                long result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
        static int[] Task20(string input)
        {
            return input.Split(' ').Select(s => int.TryParse(s.Trim(), out int num) ? num : 0).ToArray();
        }
        static int[] GetEvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            int[] evenNumbers = new int[count];
            int index = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[index] = number;
                    index++;
                }
            }
            return evenNumbers;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        {
                            int a, b;

                            Console.Clear();
                            Console.WriteLine("Задание 2");
                            Console.WriteLine("Введите первое число: ");


                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");
                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            int tefteli = Task2(a, b);
                            Console.WriteLine($"Результат сложения данных чисел: {tefteli}");

                            Thread.Sleep(5000);

                        }

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание 3");
                        Console.Write("Введите строку:");

                        Console.WriteLine($"Кол-во символов в данной строке: {Task3(Console.ReadLine())}");

                        Thread.Sleep(5000);
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 4");

                            Random rnd = new Random();
                            int[] array = new int[12];

                            Console.WriteLine("Массив: ");
                            for (int i = 0; i <= (array.Length - 1); i++)
                            {
                                array[i] = rnd.Next(1, 100);
                                Console.Write($"{array[i]} ");
                            }

                            Console.WriteLine($"\nСреднее значение элементов данного массива: {Task4(array)}");

                            Thread.Sleep(5000);
                        }

                        break;

                    case "5":
                        {
                            int a;

                            Console.Clear();
                            Console.WriteLine("Задание 5");
                            Console.WriteLine("Введите число");

                            int c;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите число: ");
                            }

                            bool ost = Task5(a);

                            if (ost == true)
                            {
                                Console.WriteLine("Число четное");
                            }
                            else
                            {
                                Console.WriteLine("Число нечетное");
                            }

                            Thread.Sleep(5000);
                            break;
                        }

                    case "6":

                        {
                            int a, b;

                            Console.Clear();
                            Console.WriteLine("Задание 6");
                            Console.WriteLine("Введите первое число: ");


                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");
                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите второе число: ");
                            }



                            if (Task6(a, b) == 0)
                            {
                                Console.WriteLine($"Число {a} больше");
                            }
                            if (Task6(a, b) == 1)
                            {
                                Console.WriteLine($"Число {b} больше");
                            }
                            if (Task6(a, b) == 2)
                            {
                                Console.WriteLine("Числа равны");
                            }

                            Thread.Sleep(5000);

                        }


                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Задание 7");
                        Console.Write("Введите строку:");

                        Console.WriteLine(Task7(Console.ReadLine()));

                        Thread.Sleep(5000);
                        break;

                    case "8":
                        {
                            int a, b;

                            Console.Clear();
                            Console.WriteLine("Задание 8");
                            Console.WriteLine("Введите первое число: ");


                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");
                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите второе число: ");
                            }

                            Console.WriteLine($"Произведение данных чисел = {Task8(a, b)}");
                            Thread.Sleep(5000);
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 9");

                            Random rnd = new Random();
                            string[] array = new string[rnd.Next(1, 10)];

                            Console.WriteLine($"Количество строк в данном массиве: {Task9(array)}");

                            Thread.Sleep(5000);
                        }

                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Задание 10");
                        Console.WriteLine("Введите строку:");

                        Console.WriteLine($"Данная строка в обратном порядке: {Task10(Console.ReadLine())}");
                        Thread.Sleep(5000);
                        break;

                    case "11":
                        {
                            int a, b;

                            Console.Clear();
                            Console.WriteLine("Задание 11");
                            Console.WriteLine("Введите первое число: ");


                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");

                            while (!int.TryParse(Console.ReadLine(), out b) || b == 0)
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите второе число: ");
                            }

                            Console.WriteLine($"Разность числа {a} и числа {b} равна {Task11(a, b)}");
                        }
                        Thread.Sleep(5000);
                        break;

                    case "12":
                        {

                            Console.Clear();
                            Console.WriteLine("Задание 12");
                            Random rnd = new Random();
                            int[] array = new int[10];



                            Console.WriteLine("Массив:");
                        }

                        break;
                    case "13":
                        {
                            Console.WriteLine("Введите строку");
                            string input = Console.ReadLine();

                            if (Task13(input))
                            {
                                Console.WriteLine("Строка является палиндромом");
                            }
                            else
                            {
                                Console.WriteLine("Строка не является палиндромом");
                            }
                            
                        }
                        Thread.Sleep(5000);
                        break;
                    case "14":
                        {
                            Console.WriteLine("Введите количество строк, которые вы хотите ввести: ");
                            int n;
                            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                            {
                                Console.WriteLine("Введите корректное целое число!");
                            }
                            string[] strings = new string[n];
                            Console.WriteLine($"Введите {n} строки (по одной в каждой строке): ");
                            for (int i = 0; i < n; i++)
                            {
                                strings[i] = Console.ReadLine();
                            }
                            Task14(strings);
                            Console.WriteLine("Отсортированный массив: ");
                            foreach (var str in strings)
                            {
                                Console.WriteLine(str);
                            }
                        }
                        Thread.Sleep(5000);
                        break;
                    case "15":
                        {
                            Console.WriteLine("Введите начальное значение диапазона");
                            int min = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите конечное значение диапазона");
                            int max = Convert.ToInt32(Console.ReadLine());
                            if (min >= max)
                            {
                                Console.WriteLine("");
                                return;
                            }
                            int randomNumber = Task15(min, max);
                            Console.WriteLine($"Случайное число в диапазоне от {min} до {max}: {randomNumber}");
                        }
                        Thread.Sleep(5000);
                        break;
                    case "16":
                        {
                            Console.WriteLine("Введите строку: ");
                            string userInput = Console.ReadLine();
                            string result = Task16(userInput);
                            Console.WriteLine("Результат:" + result);
                        }
                        Thread.Sleep(5000);
                        break;
                    case "17":
                        {
                            Console.WriteLine("Введите элементы первого массива, через пробел: ");
                            string input1 = Console.ReadLine();
                            int[] array1 = ParseInputToArray(input1);
                            Console.WriteLine("Введите элементы второго массива, через пробел: ");
                            string input2 = Console.ReadLine();
                            int[] array2 = ParseInputToArray(input2);
                            int[] result = Task17(array1, array2);
                            Console.WriteLine("Общие элементы массивов: " + string.Join(", ", result));
                        }
                        Thread.Sleep(5000);
                        break;
                    case "18":
                        {
                            Console.WriteLine("Введите строку: ");
                            string input = Console.ReadLine();
                            Task18(input);
                        }
                        Thread.Sleep(5000);
                        break;
                    case "19":
                        {
                            Console.WriteLine("Введите число: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            long factorial = Task19(number);
                            Console.WriteLine($"Факториал вашего числа - {number}, равняется - {factorial}");
                        }
                        Thread.Sleep(5000);
                        break;
                    case "20":
                        {
                            Console.WriteLine("Введите числа через пробел: ");
                            string input = Console.ReadLine();
                            int[] array = Task20(input);
                            int[] evenNumbers = GetEvenNumbers(array);
                            Console.Write("Четные числа вашего массива: ");
                            foreach (int number in evenNumbers)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        Thread.Sleep(5000);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
