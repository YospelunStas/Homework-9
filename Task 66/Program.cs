// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"M = {M}; N = {N} ---> ");
Console.Write(SumNumbers(M, N));

int SumNumbers(int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return num1;
    else
    {
        num1++;
        return sum + SumNumbers(num1, num2);
    }
}