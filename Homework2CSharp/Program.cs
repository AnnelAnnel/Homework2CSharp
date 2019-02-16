using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //countBlanks();
            //isHappy();
            //doubleSpace();
            //largerFigure();
            //mean();
            //density();
            //valueExchange();
            //evenSeven();
            //weekDay();
            //prevNextdays();


        }

        //1.	Написать программу, которая считывает символы с клавиатуры,
        //    пока не будет введена точка.Программа должна сосчитать количество
        //        введенных пользователем пробелов. 

        static void countBlanks()
        {
            int sum = 0;
            char d = '0';
            Console.WriteLine("Введите символы:");
            while (d != '.')
            {
                d = (char)Console.Read();

                if (d == ' ')
                    sum++;
            }
            Console.WriteLine(sum);
        }

        //2.	Ввести с клавиатуры номер трамвайного билета(6-значное число) 
        //    и проверить является ли данный билет счастливым(
        //если на билете напечатано шестизначное число,
        //    и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). 
        static bool isHappy()
        {
            Console.WriteLine("Введите номер билета:");
            string number = Console.ReadLine();
            int n;
            if (Int32.TryParse(number, out n) && number.Length >= 6)
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i < number.Length / 2; i++)
                {
                    sum1 += Convert.ToInt32(number[i]);
                    sum2 += Convert.ToInt32(number[number.Length - 1 - i]);

                }

                if (sum1 == sum2)
                {
                    Console.WriteLine("Счастливый");
                    return true;
                }
                else
                    Console.WriteLine("Несчастливый");
                return false;
            }

            else
            {
                Console.WriteLine("Несчастливый");
                return false;
            }
        }

        //6.	Составить программу вывода на экран в одну строку трех любых чисел
        //     с двумя пробелами между ними.

        static void doubleSpace()
        {
            Console.WriteLine("Введите число из 3 цифр:");
            string number = Console.ReadLine();
            int n;
            if (Int32.TryParse(number, out n) && number.Length == 3)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    Console.Write("{0}  ", number[i]);
                }

            }
            else if (Int32.TryParse(number, out n) && number.Length != 3)
                Console.WriteLine("В числе должны быть только три цифры");
            else
                Console.WriteLine("Это не число");

        }

        //12.	Даны радиус круга и сторона квадрата.У какой фигуры площадь больше?

        static void largerFigure()
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата:");
            double side = Double.Parse(Console.ReadLine());

            double S_circle = Math.PI * Math.Pow(radius, 2);
            double S_square = Math.Pow(side, 2);
            Console.WriteLine("{0}, {1}", S_circle, S_square);

            if (S_circle > S_square)
                Console.WriteLine("Площадь круга больше");
            if (S_circle == S_square)
                Console.WriteLine("Площади круга и квадрата равны");
            if (S_circle < S_square)
                Console.WriteLine("Площадь квадрата больше");
        }

        //22.	Даны два целых числа.Найти: 
        //a.их среднее арифметическое;
        //b.их среднее геометрическое.

        static void mean()
        {
            Console.WriteLine("Введите первое число:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Int32.Parse(Console.ReadLine());

            double a_mean = (double)(a + b) / 2;
            double g_mean = (double)Math.Sqrt(a * b);

            Console.WriteLine("Среднее арифметическое числе {0} и {1} = {2}", a, b, a_mean);
            Console.WriteLine("Среднее геометрическое числе {0} и {1} = {2}", a, b, g_mean);
        }

        //23.	Известны объем и масса тела.Определить плотность материала этого тела.
        static void density()
        {
            Console.WriteLine("Введите объем тела:");
            double volume = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу тела:");
            double mass = Double.Parse(Console.ReadLine());

            double density = mass / volume;

            Console.WriteLine("Плотность материала тела = {0}", density);
        }

        //24.	Составить программу обмена значениями трех переменных величин, а, b, c по следующей схеме: 
        //a.b присвоить значение c, а присвоить значение b, с присвоить значение, а; 
        //b.b присвоить значение, а, с присвоить значение b, а присвоить значение с.

        static void valueExchange()
        {
            Console.WriteLine("Введите число a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            Console.WriteLine("b присвоить значение c, а присвоить значение b, с присвоить значение а");

            b = b + a + c;
            a = b - a - c;
            c = b - a - c;
            b = b - a - c;

            Console.WriteLine("После перестановки A: a = {0}, b = {1}, c = {2}", a, b, c);

            Console.WriteLine("b присвоить значение а, с присвоить значение b, а присвоить значение с");

            a = a + b + c;
            c = a - b - c;
            b = a - b - c;
            a = a - b - c;

            Console.WriteLine("После перестановки B : a = {0}, b = {1}, c = {2}", a, b, c);
        }

        //32.	Дано натуральное число.Определить: 
        //a.является ли оно четным;
        //b.оканчивается ли оно цифрой 7

        static void evenSeven()
        {
            Console.WriteLine("Введите число:");
            int number = Int32.Parse(Console.ReadLine());
            string str = number.ToString();
            if (number % 2 == 0)
                Console.WriteLine("Четное. Не оканчивается на 7");
            else if (str.EndsWith("7"))
                Console.WriteLine("Нечетное. Оканчивается на 7");
            else
                Console.WriteLine("Нечетное.Не оканчивается на 7");
        }

        //34.	. Составить программу, которая в зависимости 
        //    от порядкового номера дня недели(1, 2, ..., 7)
        //    выводит на экран его название(понедельник, вторник, ..., воскресенье).

        enum Days { Понедельник = 1, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье }
        static void weekDay()
        {
            Console.WriteLine("Введите номер дня недели от 1 до 7:");

            int weekDay = Int32.Parse(Console.ReadLine());
            if (weekDay > 7 || weekDay < 1)
            {
                Console.WriteLine("Неккоректные данные");
                return;
            }
            Console.WriteLine("{0}", (Days)weekDay);
        }
        //38.	Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца) и n(число).
        //По заданным g, n и m определить: 
        //a.дату предыдущего дня;
        //b.дату следующего дня.

        static void prevNextdays()
        {
            Console.WriteLine("Введите год:");
            int g = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер число:");
            int n = Int32.Parse(Console.ReadLine());

            DateTime date = new DateTime(g, m, n);
            string ourDate = string.Format("{0:dd.MM.yyyy}", date);
            DateTime previousDay = date.AddDays(-1);
            string prev = string.Format("{0:dd.MM.yyyy}", date.AddDays(-1));
            DateTime nextDay = date.AddDays(+1);
            string next = string.Format("{0:dd.MM.yyyy}", date.AddDays(+1));
            Console.WriteLine("Сегодня {0}, вчера {1}, завтра {2}", ourDate, prev, next);
        }

    }

}

