Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Всё верно! Первое число есть квадрат второго");
}
else
{
    Console.WriteLine("Иди учить таблицу умножения!");
}
