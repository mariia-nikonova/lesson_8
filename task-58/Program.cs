using System.Globalization;
using System.Threading.Tasks.Dataflow;

Console.Write("Введите количество строк в матрице A: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице A: ");
int n = int.Parse(Console.ReadLine()!);
Random rand = new Random();

int[,] CreateArray(int s, int k)      //заполнение массива случайными натуральными числами
{
    int[,] array = new int [s, k];
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i,j] = rand.Next(10,99);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] myArray1=CreateArray(m,n);
Console.WriteLine();
Console.Write("Введите количество строк в матрице B: ");
int r = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице B: ");
int c = int.Parse(Console.ReadLine()!);
int[,] myArray2=CreateArray(r,c);
Console.WriteLine();



void multiMatrix (int [,] array1, int [,] array2)      
{
    int m = array1.GetLength(0);
    int n = array1.GetLength(1);
    int r = array2.GetLength(0);
    int c = array2.GetLength(1);
    int [,] array = new int [m,c];
  
    if (n!=r) 
    {
        Console.WriteLine("Матрицы А и В не совместимы");
    }
    else
    {
        Console.WriteLine("Произведение матриц А и В: ");
        Console.WriteLine();
        for(int i = 0; i < m; i++)
        {
            for (int j=0; j < c; j++)
            {
                array[i,j]=0;
                for (int k=0; k < n; k++)
                {
                    array[i,j]+=array1[i,k]*array2[k,j];
                }
            Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}

multiMatrix (myArray1,myArray2);
