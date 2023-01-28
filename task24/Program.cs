//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 0; i <= number; i++)
{
    result = result + i ;
}
Console.Write ($"Cуммa чисел от 1 до Вашего числа: {result}");