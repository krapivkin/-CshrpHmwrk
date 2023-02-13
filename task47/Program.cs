// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

double[,] getRandomMatrix(int rows, int colums, int leftRange, int rightRange)
{
    double[,] matrix = new double[rows,colums];
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(leftRange, rightRange+1))/10;
            
        }
    }
    return matrix;
}
void printMatrix(double[,] matrix){
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}


double[,] array = getRandomMatrix(8,11,10,0);
printMatrix(array);