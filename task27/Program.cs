// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine ("This Program wish Help you search the sum of the digits in your number.Enjoy ");
int Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int result(int a)
{
    int sum = 0;
    while (a!= 0)
    {
        sum = sum+a%10;
        a = a/10;
    }
    return sum;
}

int number = Readnumber("Enter your number here: ");
int SumAllNumbers=result(number);
Console.WriteLine(SumAllNumbers);