// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine ("This Program wish Help you show the count  of even numbers in an array.Enjoy.");
int [] GetRandomArray (int size, int LeftRng, int RightRng)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRng, RightRng);
    }
    return array;
}
Console.WriteLine("Enter the number of array elements: ");
int size1 = Convert.ToInt32(Console.ReadLine());
int LeftRng = 100;
int RightRng = 1000;
int [] massive = GetRandomArray(Math.Abs(size1), LeftRng, RightRng);
Console.WriteLine(string.Join(", ", massive));

int count = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]%2 == 0) count++;
}
Console.WriteLine($"Count even numbers in array: {count}");