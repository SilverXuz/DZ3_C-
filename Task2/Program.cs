Console.Write("Введите значение x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());
double rast = 0;

rast = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.WriteLine(rast);
