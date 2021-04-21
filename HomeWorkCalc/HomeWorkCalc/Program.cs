using System;

namespace HomeWorkCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0; double j = 0;

            Console.WriteLine("Калькулятор\r");
            Console.WriteLine("\n");

            Console.WriteLine("Введите первое число и нажмите Enter");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число и нажмите Enter");
            j = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите метематическое действие:");
            Console.WriteLine("+ - Сумма");
            Console.WriteLine("- - Разница");
            Console.WriteLine("* - Умножение");
            Console.WriteLine("/ - Деление");
            Console.Write("Введите знак математического действия ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Результат вычисления: {i} + {j} = " + (i + j));
                    break;
                case "-":
                    Console.WriteLine($"Результат вычисления: {i} - {j} = " + (i - j));
                    break;
                case "*":
                    Console.WriteLine($"Результат вычисления: {i} * {j} = " + (i * j));
                    break;
                case "/":
                    while (j == 0) {
                        Console.WriteLine("Введите число неравное 0");
                        j = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Результат вычисления: {i} / {j} = " + (i / j));
                    break;
            }
            
            Console.Write("Нажмите любую кнопку для закрытия приложения");
            Console.ReadKey();
        }
    }
}
