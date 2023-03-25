// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());
int M = 1;

Console.WriteLine($"{N} -> {Interval(N, M)}");

string Interval(int num1, int num2)
{
    if (num1 == num2) return num1.ToString();
    return ($"{num1}, {Interval(num1 - 1, num2)}");
}