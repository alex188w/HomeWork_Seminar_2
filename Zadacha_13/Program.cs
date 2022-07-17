Console.Write("Введите заданное число и нажмите клавишу Enter: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("В этом числе нет третьей цифры");
else
{
    while (number > 999)
    {
        number /= 10; // знак "/ =" обозначает: number = number / 10
    }
    Console.WriteLine("Третья цифра заданного чмсла: " + number % 10);
}
                