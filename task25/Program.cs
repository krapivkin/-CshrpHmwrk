// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!
Console.WriteLine ("This Program wish Help you to raise a num to a degree .Enjoy (:");

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree (int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
       res = res * a ;
    } 
    return res;
}

int numberA = ReadNumber("Enter num : ");
int numberB = ReadNumber("Enter degree : ");

int count1 = Degree(numberA, numberB);
Console.WriteLine (count1);