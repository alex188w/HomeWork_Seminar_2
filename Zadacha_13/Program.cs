//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Zadacha_13() //Решение с помощью цикла 
{
    Console.Write("Введите заданное число и нажмите клавишу Enter: ");
    int number =  Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number); // присвоение модуля числа
    if (number < 100) Console.WriteLine("В этом числе нет третьей цифры");
    else
    {
        while (number > 999)
        {
            number /= 10; // знак "/ =" обозначает: number = number / 10
        }
        Console.WriteLine("Третья цифра заданного чмсла: " + number % 10);
    }
}
//Zadacha_13();    

void Zadacha_13_1() //Решение с помощью массива
{
    Console.Write("Введите заданное число и нажмите клавишу Enter: ");
    string number =  Console.ReadLine();
    if (number.Length > 2)
    {
        Console.WriteLine("Третья цифра заданного чмсла: " + number[2]);
    }
    else
    Console.WriteLine("В этом числе нет третьей цифры"); 
}

Zadacha_13_1();