using System;

namespace Lesson1_02._09._2023
{
    internal class Program
    {
        static void Main()
        {
            //Задание 1
            Console.WriteLine("Задание 1.");
            Console.WriteLine("Выведите на экран 'Мир' 'Труд' и 'Май' в двух вариантах.");
            Console.WriteLine("");
            //a)
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("");
            //б)
            Console.WriteLine("Мир");
            Console.WriteLine("{0, 6}", "Труд");
            Console.WriteLine("{0, 9}", "Май");
            //Задание 2
            Console.WriteLine("");
            Console.WriteLine("Задание 2.");
            Console.WriteLine("Ввести две числовые переменные, в случае неправильного ввода данных обработать исключение.");
            Console.WriteLine("");
            bool flag = true;
            //Тут можно использовать TryParse();
            do
            {
                try
                {
                    Console.Write("Введите первую переменную: ");
                    string var1_str = Console.ReadLine();
                    var1_str = var1_str.Replace(",", ".");
                    double var1_int = double.Parse(var1_str);
                    Console.Write("Введите вторую переменную: ");
                    string var2_str = Console.ReadLine();
                    var2_str = var2_str.Replace(",", ".");
                    double var2_int = double.Parse(var2_str);
                    Console.WriteLine("Меняю значения переменных местами.. ");
                    (var1_int, var2_int) = (var2_int, var1_int);
                    Console.WriteLine("Первая переменная: {0} Вторая переменная: {1}", var1_int, var2_int);
                    flag = false;

                }
                catch
                {
                    Console.Write("Вы неправильно ввели данные, хотите попробовать ещё раз? Yes/No: ");
                    string answer1 = Console.ReadLine();
                    bool flag2 = true;
                    do
                    {
                        if (answer1 == "No" | answer1 == "no")
                        {
                            flag = false;
                            flag2 = false;
                        }
                        else if (answer1 == "Yes" | answer1 == "yes")
                        {
                            flag2 = false;
                        }
                        else
                        {
                            Console.Write("Yes/No: ");
                            answer1 = Console.ReadLine();
                        }
                    }
                    while (flag2);
                }
            }
            while (flag);
            //Задание 3
            Console.WriteLine("");
            Console.WriteLine("Задание 3.");
            Console.WriteLine("Дан радиус, найти площать и длинну круга.");
            Console.WriteLine("");
            Console.Write("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double length = 2 * Math.PI * radius;
            Console.WriteLine("Длинна окружности: {0} Площадь круга: {1}", length, area);
            Console.Write("Вы хотите округлить значения? Yes/No: ");
            string answer2 = Console.ReadLine();
            bool flag3 = true;
            do
            {
                if (answer2 == "Yes" | answer2 == "yes")
                {
                    Console.WriteLine("Длинна окружности: {0} Площадь круга: {1}", Math.Round(length), Math.Round(area));
                    flag3 = false;
                }
                else if (answer2 == "No" | answer2 == "no")
                {
                    flag3 = false;
                }
                else
                {
                    Console.Write("Yes/No: ");
                    answer2 = Console.ReadLine();
                }
            }
            while (flag3);
            //Задание 4
            Console.WriteLine("");
            Console.WriteLine("Задание 4.");
            Console.WriteLine("Найдите значение y = cos(x).");
            Console.WriteLine("");
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine("При y = cos({0}), y = {1}",x ,y);
            //Задание 5
            Console.WriteLine("");
            Console.WriteLine("Задание 5.");
            Console.WriteLine("Найдите корни уравнения: Ax^2 + Bx + C = 0.");
            Console.WriteLine("");
            Console.Write("Введите коэффициент A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент C: ");
            double C = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("");
            Console.WriteLine("Задание 6.");
            Console.WriteLine("a) b присвоить значение c, а присвоить значение b, с присвоить значение а.");
            Console.WriteLine("b) b присвоить значение а, с присвоить значение b, а присвоить значение с.");
            Console.WriteLine("");
            Console.Write("Введите а: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            Double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Меняю значения переменных местами..");
            (a, b, c) = (b, c, a);
            Console.WriteLine("a) a = {0}, b = {1}, c = {2}", a, b, c);
            (b, c, a) = (a, b, c);
            (a, b, c) = (c, a, b);
            Console.WriteLine("б) a = {0}, b = {1}, c = {2}", a, b, c);
            //Задание 7
            Console.WriteLine("");
            Console.WriteLine("Задание 7.");
            Console.WriteLine("Выведите столбиком 4 случайных числа.");
            Console.WriteLine("");
            var random = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(random.Next());
            }
            //Задание 8
            Console.WriteLine("");
            Console.WriteLine("Задание 8.");
            Console.WriteLine("Переставить конечный символ в начало.");
            Console.WriteLine("");
            Console.Write("Введите трёхзначное число: ");
            string text = Console.ReadLine();
            string insert = text.Substring(2);
            text = text.Substring(0, text.Length - 1);
            text = insert + text;
            Console.WriteLine(text);
            //Задание 9
            Console.WriteLine("");
            Console.WriteLine("Задание 9.");
            Console.WriteLine("Посчитать стоимость продуктов.");
            Console.WriteLine("");
            int cost_sweets = 10;
            int cost_cookies = 25;
            int cost_apples = 12;
            Console.WriteLine("Стоимость 1 кг конфет: {0} руб, 1 кг печенья: {1} руб, 1 кг яблок: {2} руб,", cost_sweets, cost_cookies, cost_apples);
            Console.WriteLine("");
            Console.Write("Сколько кг конфет: ");
            int col_sweets = int.Parse(Console.ReadLine());
            Console.Write("Сколько кг печенья: ");
            int col_cookies = int.Parse(Console.ReadLine());
            Console.Write("Сколько кг яблок: ");
            int col_apples = int.Parse(Console.ReadLine());
            int Result = cost_apples * col_apples + cost_cookies * col_cookies + cost_sweets * col_sweets;
            Console.WriteLine("");
            Console.WriteLine("Итоговая стоимость вашей покупки: {0} руб", Result);
            Console.WriteLine("");
            Console.Write("Для завершения нажмите любую кнопку: ");
            Console.ReadKey();
        }
    }
}
