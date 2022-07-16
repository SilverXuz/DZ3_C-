Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(x + " -> ");
for (int i = 1; i <= x; i++)
    Console.Write(i * i * i + " ");