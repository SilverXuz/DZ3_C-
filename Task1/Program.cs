Console.WriteLine("Введите пятизначное число, которое больше 9999: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 10000 || x > 99999)
{
    Console.WriteLine(x + " -> это число не больше 9999. Введите пятизначное: ");
    x = Convert.ToInt32(Console.ReadLine());
}
int x1 = Convert.ToString(x)[0];
int x2 = Convert.ToString(x)[1];
int x3 = Convert.ToString(x)[2];
int x4 = Convert.ToString(x)[3];
int x5 = Convert.ToString(x)[4];
if (x1 == x5 && x2 == x4)
    Console.WriteLine(x + " -> это число палиндром!");
else
    Console.WriteLine(x + " -> это число не палиндром!");