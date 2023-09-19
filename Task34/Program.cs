// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int NArray (int N)
{
    int[] A = new int[N];
    int i = 0;
    while (N > 0)
    {
        A[N-1] = new Random().Next(100,999);
        if ((A[N-1] % 2) == 0 )
        {
            i = i + 1;
        }
        N = N - 1;
    }
   
    var strА = string.Join(" ", A);
    Console.WriteLine(strА);
    return i;
}


int res = NArray(8);
Console.WriteLine("Количество четных чисел в массиве: " + res);


