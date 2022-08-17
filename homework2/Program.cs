// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координатy x1: ");
var x1String = Console.ReadLine();
double x1 = double.Parse(x1String!);

Console.WriteLine("Введите координату y1: ");
var y1String = Console.ReadLine();
double y1 = double.Parse(y1String!);

Console.WriteLine("Введите координату z1: ");
var z1String = Console.ReadLine();
double z1 = double.Parse(z1String!);

Console.WriteLine("Введите координатy x2: ");
var x2String = Console.ReadLine();
double x2 = double.Parse(x2String!);

Console.WriteLine("Введите координату y2: ");
var y2String = Console.ReadLine();
double y2 = double.Parse(y2String!);

Console.WriteLine("Введите координату z2: ");
var z2String = Console.ReadLine();
double z2 = double.Parse(z2String!);




double sqrt = Math.Sqrt (Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками " + sqrt.ToString("N2")); // округление




