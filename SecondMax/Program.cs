
int[] array = new int[100];
int max = 0;
int secondMax = 0;
int i = 0;
while (i < array.Length)
    {
        Console.Write("Введите число от 0 до 100(ноль не ранее третьего значения): ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        while (array[i] == 0 && i < 1)
        {
            Console.WriteLine("Это число не подходит. Ноль можно ввести не раньше третьего значения.");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        while (array[i] < 0 || array[i] > 100)
        {
            Console.WriteLine("Это число не подходит");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
            }
        else
            if (array[i] > secondMax)
                secondMax = array[i];

        if (array[i] == 0 && i > 1)
        {
            Console.WriteLine("Можете завершить ввод этим значением. Или введите следующее число от 0 до 100: ");
            Console.Write("Хотите завершить ввод? 1 - да, 2 - нет : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 1)
                {
                    Console.WriteLine("Второе максимальное число -> " + secondMax);
                    break;
                }
        }
        else
        i++;
    }
