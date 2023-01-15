/*Задача 4*. Напишите программу,
 которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int m = 4;
int n = 4;
int [,] matrix = new int [m,n];
void PrintArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }   
            Console.WriteLine();    
        }
}
void FillArray(int row, int column)
{
    if(matrix[row,column] == 0)
    {
        matrix[row,column] = 1;
        FillArray(row,column + 1);
        FillArray(row + 1,column);
        FillArray(row,column - 1);
        FillArray(row -1,column);
    }

}
PrintArray(matrix);
Console.WriteLine();
FillArray(0, 0);
Console.Write(($"{matrix[m, n]} "));