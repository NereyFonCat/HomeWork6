
using System;

namespace HomeWork6
{
    // Суханов 
    // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
     
    public delegate double Fun(double x, double a);

    class Program : Delegate2 // Не знаю, правильно ли создал зависимость... 
    {
        static void Main()
        {
            Console.WriteLine("Таблица функции MyFunc:");
            Table(MyFunc, -2, 2, 4);

            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            Console.WriteLine("Таблица функции a*x^2:");
            Table(delegate (double x, double a) { return x * x * a; }, -2, 2, 4);

            Console.WriteLine("Таблица функции a*Sin(x):");
            Table(delegate (double x, double a) { return a * Math.Sin(x); }, -2, 2, 4);
        }
    }

}
