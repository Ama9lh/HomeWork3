Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < n)
{
    i++;
    Console.WriteLine(i*i*i);
}


/* Через цикл for
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
*/