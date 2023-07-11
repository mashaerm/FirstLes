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