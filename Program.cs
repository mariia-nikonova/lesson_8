using System.Globalization;
using System.Threading.Tasks.Dataflow;

Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
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
int[,] myArray=CreateArray(m,n);


void sortedArray (int [,] array)      //сортировка элементов массива в каждой строке
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int [] myArr1 = new int [n];
    int [,] myArr2 = new int [m,n];
    Console.WriteLine();
    Console.WriteLine("Массив, элементы в строке которого отсортированы по убыванию: ");
      for(int i = 0; i < m; i++)
    {
        for (int j=0; j <n ; j++)
        {
            myArr1[j]=array[i,j];
        }
        Array.Sort(myArr1, 0, n);
        for (int k=n-1; k>=0; k--)
        {
            myArr2[i,k]=myArr1[k];
            Console.Write($"{myArr2[i,k]} ");
        }
        Console.WriteLine();
    }
}
sortedArray (myArray);