
Console.Write("Введите число от 0 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int secondMax = 0;
while(n != 0)
    {
        Console.Write("Введите число от 0 до 100: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > max)
        {
            secondMax = max;
            max = n;
        }
        else
            if (n > secondMax)
                secondMax = n;
    }
Console.WriteLine("Второе максимальное число -> " + secondMax);