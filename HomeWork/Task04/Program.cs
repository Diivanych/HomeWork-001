Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
Console.WriteLine($"Чётными числами в диапазоне от 1 до {num} будет");
while (start <= num)
{
    if(start%2 == 0)
    {
        Console.Write($" {start} ");
    }
    start++;
}