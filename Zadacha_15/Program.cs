Console.Write("Введите день недели и нажмите клавишу Enter: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("День недели - понедельник");
else 
    if (number == 2) Console.WriteLine("День недели - вторник");
    else
        if (number == 3) Console.WriteLine("День недели - среда");
        else
            if (number == 4) Console.WriteLine("День недели - четверг");
            else
                if (number == 5) Console.WriteLine("День недели - пятница");
                else
                    if (number == 6) Console.WriteLine("День недели - суббота - выходной!!");
                    else
                        if (number == 7) Console.WriteLine("День недели - воскресенье - выходной!!");
                        else Console.WriteLine("Введен некорректный день недели");
