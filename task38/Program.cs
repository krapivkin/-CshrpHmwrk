//Задача 38: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

Console.WriteLine ("This Program help you search difference between max & min value of array.Enjoy.");
int[] FillRandomArray(int size)
{
    int [] array=new int[size];
    for(int i=0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,100);
    }
    return array;
}

int [] massive=FillRandomArray(5);
Console.WriteLine(string.Join(", ", massive));

int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] > max)
        {
            max = massive[i];
        }
    if (massive[i] < min)
        {
            min = massive[i];
        }
}

Console.WriteLine($"{min} is a min,{max} is max of this array");
Console.WriteLine($"Difference between max & min value = {max - min}");
Console.ReadLine();

