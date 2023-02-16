﻿
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,]GetRandomArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            for (int k=0; k < array.GetLength(2); k++)
            {
                array [i,j,k] = new Random().Next(10,100);
            }
        }
    }
    return array;
}


void PrintArray (int [,,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j=0; j < array.GetLength(1); j++)
        {
            for (int k=0; k < array.GetLength(2); k++)
            {
                Console.WriteLine ($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

const int a = 2;
const int b = 2;
const int c = 2;
int[,,] array = GetRandomArray (a, b, c);
PrintArray(array);