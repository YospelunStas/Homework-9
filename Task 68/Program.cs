// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"M = {M}; N = {N} ---> A(M,N) = ");
Console.Write(Acker(M, N));

int Acker(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
    {
        if ((num1 != 0) && (num2 ==0)) 
        {
            return Acker(num1 - 1, 1);
        }
        else 
        {
            return Acker(num1 - 1, Acker(num1, num2 - 1));
        }
    }
}