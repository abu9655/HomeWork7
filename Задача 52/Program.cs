//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void FillArrayWithRandom(int[,] matrix, int m, int n )
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void NewMatrix(int[,] matrix, int m, int n)
{
    double  sum=0;
    for (int i = 0; i < m; i++)
    {
        
        for (int j = 0; j < n; j++)
        {
          sum =sum+matrix[j,i];
        }
        sum = sum / m;
        Console.Write(sum+"; ");
        sum=0;
    }
    
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n );
Console.Write("Среднее арифметическое каждого столбца: ");
NewMatrix(matrix, m, n);
