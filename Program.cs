using System;


namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            char oper;
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Console.WriteLine("Введите число 'a':");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие '+', '-', '*', '/', 's' (синус), 'c' (косинус), 't' (тангенс), 'k' (котангенс) , 'r'(корень):");
            oper = Convert.ToChar(Console.ReadLine());

            if (oper == 's')

            {
                c = Math.Sin(a);
                Console.WriteLine("Синус числа " + a + " равен " + c);
            }
            else if (oper == 'c')
            {
                c = Math.Cos(a);
                Console.WriteLine("Косинус числа " + a + " равен " + c);
            }
            else if (oper == 't')
            {
                c = Math.Tan(a);
                Console.WriteLine("Тангенс числа " + a + " равен " + c);
            }
            else if (oper == 'k')
            {
                c = 1 / Math.Tan(a);
                Console.WriteLine("Котангенс числа " + a + " равен " + c);
            }
            else if (oper == 'r')
            {
                if (a < 0)
                {
                    Console.WriteLine("Нельзя найти квадратный корень из отрицательного числа.");
                }
                else
                {
                    c = Math.Sqrt(a);
                    Console.WriteLine("Корень числа " + a + " равен " + c);
                }
            }

            else
                Console.Write("Введите число b: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (oper == '+')
            {
                c = a + b;
                Console.WriteLine("Сумма ваших чисел равна " + c);
               
            }
            else if (oper == '-')
            {
                c = a - b;
                Console.WriteLine("Разность ваших чисел равна " + c);
                
            }
            else if (oper == '*')
            {
                c = a * b;
                Console.WriteLine("Произведение ваших чисел равно " + c);
                
            }
            else if (oper == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    
                }
                else
                {
                    c = a / b;
                    Console.WriteLine("Частное ваших чисел равно " + c);
                   
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                


            }

            Console.ReadKey();
        }
    }
}