// Программа принимает на вход два числа (N,M) и выдает таблицу кубов чисел от N до M

Console.Clear();

Console.Write("Введите число N : ");
int n=int.Parse(Console.ReadLine());
Console.Write("Введите число M : ");
int m=int.Parse(Console.ReadLine());

PrntPowTbl(n, m);

void PrntPowTbl(int n, int m)
{
    if(m<n)
        Console.Write("Число N > Числа M =(");
    else
    {
        Console.Write($"({n},{m}) -> ");
        for(int i=n; i<=m; i++)
            Console.Write($"{i*i*i} ");
    }
}