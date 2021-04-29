using System;

namespace HomeWork6
{
    internal class Delegate2
    {
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return x * x * a;
        }
        // Создаем метод, который принимает делегат
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
    } 
}