// Программа принимает координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Clear();

Console.WriteLine("Ввод координат точки А: ");
Console.Write("Введите координату Х: ");
int ax=int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int ay=int.Parse(Console.ReadLine());
Console.Write("Введите координату Z: ");
int az=int.Parse(Console.ReadLine());

Console.WriteLine("Ввод координат точки B: ");
Console.Write("Введите координату Х: ");
int bx=int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int by=int.Parse(Console.ReadLine());
Console.Write("Введите координату Z: ");
int bz=int.Parse(Console.ReadLine());

double s=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));

Console.WriteLine($"Расстояние между точками равно {s}");