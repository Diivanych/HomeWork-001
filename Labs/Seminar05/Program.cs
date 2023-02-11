Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000) // Применили логическое "И" &&. Есть ещё логическое "ИЛИ" || 
{
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine("Число должно быть трёхзначным");
}