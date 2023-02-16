// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.

void PrintNumbers(int n)
{

Console.Write(n+ " ");
    if(n==1) return;
PrintNumbers(n-1);
}
int number = 1999;
PrintNumbers(number);
Console.WriteLine();
Console.WriteLine("it's simple (:");
Console.ReadKey();

