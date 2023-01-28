// Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine ("This Program wish Help you to create New Array.Enjoy (:");
Console.WriteLine ("Enter eight numbers: ");
int[] FillNewArr(int size)
{
    int[] array = new int[size];
         
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int[] arrayNew = FillNewArr(8);
Console.WriteLine(string.Join (", ", arrayNew));