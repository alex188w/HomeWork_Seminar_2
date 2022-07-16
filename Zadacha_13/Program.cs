Console.Write("Введите заданное число и нажмите клавишу Enter: ");
int number =  Convert.ToInt32(Console.ReadLine());
int numberThree3 = number % 10;
int numberThree4 = number / 10 % 10;
int numberThree5 = number / 100 % 10;
int numberThree6 = number / 1000 % 10;

if (number < 100) Console.WriteLine("В этом числе нет третьей цифры");
else 
    {
        if (number > 99 && number < 1000)
        Console.WriteLine("Третья цифра заданного чмсла: " + numberThree3);
        else
            if (number > 999 && number < 10000)
            Console.WriteLine("Третья цифра заданного чмсла: " + numberThree4);
            else
                if (number > 9999 && number < 100000)
                Console.WriteLine("Третья цифра заданного чмсла: " + numberThree5);
                else
                    if (number > 99999 && number < 1000000)
                    Console.WriteLine("Третья цифра заданного чмсла: " + numberThree6);
    }
// и т.д. при каждом увеличении разряда добавляем новую переменную numberThree и новое условие
