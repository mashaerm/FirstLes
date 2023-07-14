void Task0()
{
    //Напишите программу, которая на вход принимает число и выдает его квадрат

    int number = 5;

    int result = number * number;

    Console.WriteLine(result);
}

void Task1()
{
    // Напишите программу, которая на вход принимает два числа и проверяет, является ли первое исло квадратом второго

    Console.WriteLine("Введите первое число");
    int number_f = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number_s = Convert.ToInt32(Console.ReadLine());

    if (number_f == number_s * number_s)
    {
        Console.WriteLine("Первая переменная является квадратом второй");
    }

    else

    {
        Console.WriteLine("Первая переменная не является квадратом второй");
    }
}

// Напишите программу, которая будет выдавать название дня недели по задонному номеру

// Console.WriteLine("Введите число от 1 до 7");
// int number_f = Convert.ToInt32(Console.ReadLine());

// if (number_f == 1) Console.WriteLine("Понедельник");
// else if (number_f == 2) Console.WriteLine("Вторник");
// else if (number_f == 3) Console.WriteLine("Среда");
// else if (number_f == 4) Console.WriteLine("Четверг");
// else if (number_f == 5) Console.WriteLine("Пятница");
// else if (number_f == 6) Console.WriteLine("Суббота");
// else if (number_f == 7) Console.WriteLine("Воскресенье");

// else

// {
//      Console.WriteLine("Нет такого дня недели");
// }

//Напишите программу вычисления значения функции возведения числа в квадрат

int Power(int number)
{
    int result = number * number;
    return result;
}

void Task5()
{
    //Напишите программу вычисления значения функции возведения числа в квадрат
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    int result = Power(num);

    Console.WriteLine(result);
}

void Task7()
{
    //Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(num);

    int counter = -num;

    while (counter <= num)
    {
        Console.Write(counter + " ");
        counter++;
    }

}


void Task2()
{
    // Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

    Console.WriteLine("Введите первое число");
    int number_f = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number_s = Convert.ToInt32(Console.ReadLine());

    if (number_f >= number_s)
    {
        Console.WriteLine("max=" + number_f);
    }

    else
    {
        Console.WriteLine("max=" + number_s);
    }


}

void Task4()
{
    // Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел

    Console.WriteLine("Введите первое число");
    int number_f = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number_s = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");
    int number_t = Convert.ToInt32(Console.ReadLine());

    int max = 0;

    if (number_f > max)
    {
       max = number_f;
    }

    if (number_s > max)
    {
        max = number_s;
    }

    if (number_t > max)
    {
        max = number_t;
    }

    Console.WriteLine(max);
}

void Task6()
{
    // Напишите программу, которая на вход принимает число и выдает, является ли число четным

    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    int ost = num % 2;

    if (ost == 0)
    {
        Console.WriteLine("Да, четное");
    }

    else

    {
        Console.WriteLine("Нет, нечетное");
    }
}

void Task8()
{
    //Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все четные числа в промежутке от 1 до N

    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    int counter = 2;

    if (num > 1)
    {
        while (counter <= num)
    {
        Console.Write(counter + " ");
        counter = counter + 2;
    }
    }

}

void Task9()
{
    //Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывет наибольшую цифру числа

    Random rnd = new Random();

    int number = rnd.Next(10, 100);

    Console.WriteLine($"Выпало случайное число: {number}");

    int f_digit = number / 10;
    int s_digit = number % 10;

    int max;

    if (f_digit > s_digit) max = f_digit;
    else max = s_digit;

    Console.WriteLine($"Наибольшая цифра числа: {max}");

}

void Task11()
{
    //Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

    Random rnd = new Random();

    int number = rnd.Next(100, 1000);

    Console.WriteLine($"Выпало случайное число: {number}");

    int f_digit = number / 100;
    int t_digit = number % 10;

    Console.WriteLine($"Число, без второй цифры: {f_digit}{t_digit}");

}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task12()
{
    //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

    int number_f = Input("Введите первое число: ");

    int number_s = Input("Введите второе число: ");

    int div = number_s % number_f;

    if (div == 0)
    {
        Console.WriteLine($"Число {number_s} кратно числу {number_f}");
    }
    else
    {
        Console.WriteLine($"Число {number_s} не кратно числу {number_f}. Остаток от деления равен {div}");
    }

}

void Task14()
{
    //Напишите программу, которая будет принимать на вход число и проверяет, кратно ли оно одновременно 7 и 23
    // & и | или && сокращенное и || сокращенное или

    int number_f = Input("Введите первое число: ");

    if (number_f % 7 == 0 && number_f % 23 == 0)
    {
        Console.WriteLine($"Число {number_f} одновременно кратно 7 и 23 ");
    }
    else
    {
        Console.WriteLine($"Число {number_f} одновременно не кратно 7 и 23 ");
    }

}

void Task16()
{
    //Напишите программу, которая будет принимать на вход два числа и проверяет, является ли одно число квадратом другого

    int number_f = Input("Введите первое число: ");

    int number_s = Input("Введите второе число: ");

    if (number_f * number_f == number_s || number_s * number_s == number_f)
    {
        Console.WriteLine("Одно число квадрат другого числа");
    }
    else
    {
        Console.WriteLine("Ни одно из чисел не квадрат другого числа");
    }

}

void Task10()
{
    //Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

    int number = Input("Введите трехзначное число: ");

    if (number >= 100 & number < 1000)
    {
        int f_digit = number / 10;
        int s_digit = f_digit % 10;

        Console.WriteLine($"Вторая цифра числа: {s_digit}");
    }
    
    else

    {
        Console.WriteLine("Число не трехзначное");
    }

}

void Task13()
{
    //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет

    int number = Input("Введите число: ");

    number = Math.Abs(number);

    if (number > 99)
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine($"Третья цифра числа: {number % 10}");
    }

    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

}
void Task15()
{
    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

    int number = Input("Введите число: ");

    if (number >= 1 & number <= 5) Console.WriteLine("Не выходной");
    else if (number == 6 || number == 7) Console.WriteLine("Выходной");

    else

    {
        Console.WriteLine("Нет такого дня недели");
    }

}

void Task19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

    int number = Input("Введите пятизначное число: ");

    if (number >= 10000 & number < 100000)
    {
        int f_digit = number / 10000;
        int ff_digit = number % 10;
        int s_digit = number / 1000 % 10;
        int ss_digit = number / 10 % 10;

        if (f_digit == ff_digit & s_digit == ss_digit)

        {
            Console.WriteLine("Это число палиндром");
        }

        else
        {
            Console.WriteLine("Это число не палиндром");
        }

    }
    
    else

    {
        Console.WriteLine("Число не пятизначное");
    }

}

void Task211()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

    int X1 = Input("Введите X1: ");

    int Y1 = Input("Введите Y1: ");

    int Z1 = Input("Введите Z1: ");

    int X2 = Input("Введите X2: ");

    int Y2 = Input("Введите Y2: ");

    int Z2 = Input("Введите Z2: ");

    double result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));
    result = Math.Round(result, 2);
    Console.WriteLine ($"Расстояние между точками: {result}");
}

void Task23()
{
    //Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

    int number = Input("Введите число: ");

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine ($"{i}^3 = {Math.Pow(i,3)}");
    }
}

Console.Clear();
Task23();