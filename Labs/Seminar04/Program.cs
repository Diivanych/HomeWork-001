Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int curent = num * (-1);
while (curent <= num)
{
    Console.Write($"{curent} " );  //  или Console.Write(curent + " " );
    curent++;
}

// Console.WriteLine($"Квадрат числа {num} есть {quad}");