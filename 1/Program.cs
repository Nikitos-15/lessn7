// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.  /////////...решеная 
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.WriteLine("Ведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбов: ");
int columns= Convert.ToInt32(Console.ReadLine());
int[,]array = new int [rows, columns];

CreateArray(array);
PrintArray(array);

void  CreateArray(int [,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j ] = Convert.ToInt32(new Random().Next(-100,100));
        }
    }

   
} 

void PrintArray(int[,]array)
{
for (int i = 0; i < array.GetLength(0); i++ )
 {
    for (int j = 0; j < array.GetLength(1); j++)
    {
       
        Console.Write(array[i,j]+ " ");

    }
    Console.WriteLine("");
 }
}