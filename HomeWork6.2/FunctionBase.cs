﻿
//using System.IO;

//namespace HomeWork6._2
//{
//    internal class FunctionBase
//    {
//        public delegate double function(double x);
//        public static double F1(double x)
//        {
//            return x * x - 4 * x + 16;
//        }

//        public static double F2(double x)
//        {
//            return x * x - 2 * x + 4;
//        }
//        public static double Load(string fileName) // нахождение минимума функции
//        {
//            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
//            BinaryReader bw = new BinaryReader(fs);
//            double min = double.MaxValue;
//            double d;
//            for (int i = 0; i < fs.Length / sizeof(double); i++)
//            {
//                // Считываем значение и переходим к следующему
//                d = bw.ReadDouble();
//                if (d < min) min = d;
//            }
//            bw.Close();
//            fs.Close();
//            return min;
//        }
//        public static void SaveFunc(string fileName, double a, double b, double h, function F)
//        {
//            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
//            BinaryWriter bw = new BinaryWriter(fs);
//            double x = a;
//            while (x <= b)
//            {
//                bw.Write(F(x));
//                x += h;
//            }
//            bw.Close();
//            fs.Close();
//        }
//    }
//}