//Программа которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату X для первого числа:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для первого числа:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для первого числа:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X для второго числа:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для второго числа:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для второго числа:");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Расстояние между двумя точками: {Math.Round(distance,2)}");