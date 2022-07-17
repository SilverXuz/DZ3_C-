int[] array = new int[10]; // Поставил 10 чтобы провести проверку на лимит значений. 
int max = 0;
int secondMax = 0;
int i = 0;
while (i < array.Length-1)
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
                    break;
                }
        }
        if (i == array.Length-2 && array[i] != 0)
        {
            Console.WriteLine("Это последнее число, вы еще не вводили ноль. Ноль введен принудительно: ");
            Console.WriteLine(0);
        }
        i++;
    }
Console.WriteLine("Второе максимальное число -> " + secondMax);
