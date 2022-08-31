// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));


Console.WriteLine("Расстояние между точками равно " + distance);

