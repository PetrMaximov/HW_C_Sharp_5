// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double NArray (int N)
{
    double[] A = new double[N];
    while (N > 0)
    {
        A[N-1] = Math.Round(((new Random().NextDouble()) * new Random().Next(-100,100)), 2);
        N = N - 1;
    }


    double Max = A[0];
    double Min = A[0];

    for (int i = 1; i < A.Length; i++)
    {
        if (A[i] > Max)
        {
            Max = A[i];
        }
        if (A[i] < Min)
        {
            Min = A[i];
        }
    }
   
    var strА = string.Join(" ", A);
    Console.WriteLine(strА);
    Console.WriteLine("Минимальное число: " + Min);
    Console.WriteLine("Максимальное число: " + Max);
    return Max-Min;
}


double res = NArray(4);
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + res);
