Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000) // Применили логическое "И" &&. Есть ещё логическое "ИЛИ" || 
{
    Console.WriteLine($"Последняя цифра в этом трёхзначном числе будет {num%10}");
}
else
{
    Console.WriteLine("Число должно быть трёхзначным");
}