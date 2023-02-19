// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write($"m = ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write($"n = ");
int N = Convert.ToInt32(Console.ReadLine());

int function (int a, int b)
{
    if (a == 0 && b > 0) return b+1;
    else if (a > 0 && b == 0) return function (a-1,1);
    else if (a > 0 && b > 0) return function (a-1,(function (a, b-1)));
    else return 0;
}

Console.WriteLine($"{function (M,N)}");