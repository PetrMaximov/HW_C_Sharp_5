// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int NArray (int N)
{
    int[] A = new int[N];
    int sum = 0;
    while (N > 0)
    {
        A[N-1] = new Random().Next(-10,10);
        if (((N-1) % 2) != 0 )
        {
            sum = sum + A[N-1];
        }
        N = N - 1;
    }
   
    var strА = string.Join(" ", A);
    Console.WriteLine(strА);
    return sum;
}


int res = NArray(8);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях равна = " + res);

