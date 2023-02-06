// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату хА: ");
Double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yA: ");
Double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zA: ");
Double za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату хB: ");
Double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yB: ");
Double yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zB: ");
Double zb = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(xb-xa,2) + (Math.Pow(yb-ya,2)) + (Math.Pow(zb-za,2)));
Console.WriteLine($"Расстояние между точками: {Math.Round(result,2)}");

// d = √ (хb – хa) 2 + (уb – уa) 2 + (zb - za) 2)