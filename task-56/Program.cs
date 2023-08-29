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
Console.WriteLine();


void sumArray (int [,] array)      //сортировка элементов массива в каждой строке
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int [] myArr1 = new int [m];
    int index=0;

    for(int i = 0; i < m; i++)
    {
        myArr1[i] = 0;
        for (int j=0; j <n ; j++)
        {
            myArr1[i]=myArr1[i]+array[i,j];
        }
        Console.Write($"{myArr1[i]} ");
    }
        int min=myArr1[0];
        for (int k=0; k<m; k++)
        {
            if (min>myArr1[k])
            {
                min=myArr1[k];
                index=k;
            }
        }
    Console.WriteLine();
    Console.Write($"Номер строки с наименьшей суммой элементов: {index} ");
}
sumArray (myArray);