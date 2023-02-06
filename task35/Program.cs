// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.WriteLine ("This Program Help you serach number of array elements in the range from 10 to 99.Enjoy.");
int [] GetRandomArray (int Size, int LeftRange, int RightRange)
{
    int[] array = new int [Size];

    for (int a = 0; a < array.Length; a++)
    {
        array[a] = new Random().Next(LeftRange, RightRange);
    }
    return array;
}

const int Size = 123;
int LeftRange = 0;
int RightRange = 150;
int [] massive = GetRandomArray(Size, LeftRange, RightRange + 1);
Console.WriteLine (string.Join(", ", massive));

int count = 0;
for (int a = 0; a < massive.Length; a++)
{
    if (massive[a] >= 10 && massive[a]<= 99) count++;
}

Console.WriteLine($"The number of array elements in the range from 10 to 99 = {count}");
Console.ReadKey();
