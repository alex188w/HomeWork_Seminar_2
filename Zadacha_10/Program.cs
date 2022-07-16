Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
int number =  Convert.ToInt32(Console.ReadLine());

int tens = number / 10 % 10;

Console.WriteLine("Вторая цифра этого числа: " + tens);