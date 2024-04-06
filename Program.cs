using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            char oper;
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Console.WriteLine("Введите число 'a':");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие '+','-','*','/':");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите число 'b':");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                result = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".");
                Console.ReadKey();
            }

            else if (oper == '-')
            {
                result = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".");
                Console.ReadKey();
            }

            else if (oper == '*')
            {
                result = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + result + ".");
                Console.ReadKey();
            }

            else if (oper == '/')
                {
                if (b == 0)
                {
                        Console.WriteLine("Деление на 0 невозможноЁ!Ё!Ц!");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("Деление " + a + " на " + b + " равно " + result + ".");
                        Console.ReadKey();
                    }
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
                Console.ReadKey();
            }

        }

    }
}