Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());  //  ToInt32 - преобразует символ в целое число
int quad = num * num;
Console.WriteLine($"Квадрат числа {num} есть {quad}");  //  Вывод текста и переменных в одной строке
