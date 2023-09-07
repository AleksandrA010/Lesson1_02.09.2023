using System;
using System.Globalization;
using System.Threading;

namespace Lesson1_02._09._2023
{
    internal class Program
    {
        static string Analysis(string str, string condition)
        {
            var english = CultureInfo.GetCultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = english;
            bool flag = true;
            string result;
            do
            {
                result = str.Replace(",", ".");
                try
                {
                    double result_D = Convert.ToDouble(result);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Вы не верно ввели данные, в записи числа не должны присутствовать буквы и не относящие к числу символы.");
                    empty();
                    Console.Write(condition);
                    str = Console.ReadLine();
                }
            }
            while (flag);
            return result;
        }
        static void Blank(string description, int number, int size_center)
        {
            string[] text = description.Split(new char[] { '*' });
            Console.WriteLine("");
            Console.WriteLine("Задание {0}", number);
            for (int i = 0; i < size_center; i++)
            {
                Console.WriteLine(text[i]);
            }
            Console.WriteLine("");
        }
        static void empty()
        {
            Console.WriteLine("");
        }
        static void Main()
        {
            var english = CultureInfo.GetCultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = english;
            //Задание 1
            Blank("Выведите на экран 'Мир' 'Труд' и 'Май' в двух вариантах.", 1, 1);
            //a)
            Console.WriteLine("Мир Труд Май");
            empty();
            //б)
            Console.WriteLine("Мир");
            Console.WriteLine("{0, 6}", "Труд");
            Console.WriteLine("{0, 9}", "Май");
            //Задание 2
            Blank("Ввести две числовые переменные и поменять их местами. (Пользователь может неправильно ввести данные).", 2, 1);
            Console.Write("Введите первую переменную: ");
            double var1 = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите первую переменную: "));
            Console.Write("Введите вторую переменную: ");
            double var2 = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите вторую переменную: "));
            empty();
            Console.WriteLine("Меняю переменные местами.");
            (var1, var2) = (var2, var1);
            Console.WriteLine("Первая переменная: {0}, Вторая переменная: {1}.", var1, var2);
            //Задание 3
            Blank("Дан радиус, найти площать и длинну круга.", 3, 1);
            Console.Write("Введите радиус круга: ");
            double radius = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите радиус круга: "));
            double area = Math.PI * Math.Pow(radius, 2);
            double length = 2 * Math.PI * radius;
            Console.WriteLine("Длинна окружности: {0} Площадь круга: {1}", length, area);
            //Задание 4
            Blank("Найдите значение y = cos(x).", 4, 1);
            Console.Write("Введите значение x(радианы): ");
            double x = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите значение x(радианы): "));
            double y = Math.Cos(x);
            Console.WriteLine("При y = cos({0}), y = {1}", x, y);
            //Задание 5
            Blank("Найдите корни уравнения: Ax^2 + Bx + C = 0.", 5, 1);
            Console.Write("Введите коэффициент A: ");
            double A = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите коэффициент A: "));
            Console.Write("Введите коэффициент B: ");
            double B = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите коэффициент B: "));
            Console.Write("Введите коэффициент C: ");
            double C = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите коэффициент C: "));
            if (A == 0)
            {
                double root = (-C) / B;
                Console.WriteLine("Ответ: {0}", root);
            }
            else
            {
                double D = Math.Pow(B, 2) + (-4) * A * C;
                if (D < 0)
                {
                    Console.WriteLine("Ответ: 'Корней нет'.");
                }
                else if (D == 0)
                {
                    double root = (-B) / 2 * A;
                    Console.WriteLine("Ответ: {0}", root);
                }
                else
                {
                    double root1 = ((-B) + Math.Sqrt(D)) / (2 * A);
                    double root2 = ((-B) - Math.Sqrt(D)) / (2 * A);
                    Console.WriteLine("Ответ: {0}, {1}", root1, root2);
                }
            }
            //Задание 6
            Blank("a) b присвоить значение c, а присвоить значение b, с присвоить значение а.*" +
                "b) b присвоить значение а, с присвоить значение b, а присвоить значение с.", 6, 2);
            Console.Write("Введите а: ");
            double a = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите а: "));
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите b: "));
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите c: "));
            Console.WriteLine("Меняю значения переменных местами..");
            //a)
            (a, b, c) = (b, c, a);
            Console.WriteLine("a) a = {0}, b = {1}, c = {2}", a, b, c);
            //б)
            (b, c, a) = (a, b, c);
            (a, b, c) = (c, a, b);
            Console.WriteLine("б) a = {0}, b = {1}, c = {2}", a, b, c);
            //Задание 7
            Blank("Выведите столбиком 4 случайных числа.", 7, 1);
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(random.Next());
            }
            //Задание 8
            Blank("Поставить последний символ в начало.", 8, 1);
            bool flag = true;
            string text;
            do
            {
                Console.Write("Введите трёхзначное число: ");
                double text_Check = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите трёхзначное число: "));
                text = Convert.ToString(Math.Abs(text_Check));
                if (text.Length != 3)
                {
                    Console.WriteLine("Данное число не является трёхзначным.");
                    empty();
                }
                else
                {
                    flag = false;
                }
            }
            while (flag);
            string insert = text.Substring(2);
            text = text.Substring(0, text.Length - 1);
            text = insert + text;
            Console.WriteLine(text);
            //Задание 9
            Blank("Посчитать стоимость продуктов.", 9, 1);
            Console.Write("Введите стоимость 1 кг конфет: ");
            double cost_sweets = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите стоимость 1 кг конфет: "));
            Console.Write("Введите стоимость 1 кг печенья: ");
            double cost_cookies = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите стоимость 1 кг печенья: "));
            Console.Write("Введите стоимость 1 кг яблок: ");
            double cost_apples = Convert.ToDouble(Analysis(Console.ReadLine(), "Введите стоимость 1 кг яблок: "));
            empty();
            Console.Write("Введите количество кг конфет: ");
            double col_sweets = double.Parse(Analysis(Console.ReadLine(), "Введите количество кг конфет: "));
            Console.Write("Введите количество кг печенья: ");
            double col_cookies = double.Parse(Analysis(Console.ReadLine(), "Введите количество кг печенья: "));
            Console.Write("Введите количество кг яблок: ");
            double col_apples = double.Parse(Analysis(Console.ReadLine(), "Введите количество кг конфет: "));
            double Result = cost_apples * col_apples + cost_cookies * col_cookies + cost_sweets * col_sweets;
            empty();
            Console.WriteLine("Итоговая стоимость вашей покупки: {0} руб", Result);
            empty();
            Console.Write("Для завершения нажмите любую клавишу: ");
            Console.ReadKey();
        }
    }
}
