// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine ("This Program help you search a sum of not-even elements of array.Enjoy.");
int [] GetRandomArray (int size, int LeftRange, int RightRange)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange);
    }
    return array;
}

Console.WriteLine("Enter number of array elements: ");
int size1 = Convert.ToInt32(Console.ReadLine());

int [] massive = GetRandomArray(Math.Abs(size1), -777, 777);
Console.WriteLine(string.Join(", ", massive));

int result = 0;
for ( int i = 1; i < massive.Length; i += 2 )
{
    result += massive [i];
}

Console.WriteLine($"Sum of not-even elements of array= {result}");
Console.ReadLine();