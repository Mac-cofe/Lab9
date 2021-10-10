using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int otvet;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Вас приветствует Калькулятор 1.0");
                Console.WriteLine("Я пока только умею складывать, вычитать, умножать и делить числа");
                Console.WriteLine("--------------------------------------------------------------");
                int x = 0; int y = 0;
                Console.Write("Введите первое целое число  ");
                while (!int.TryParse(Console.ReadLine(), out x))                                     // здесь не получилось именно через try, catch
                {
                    Console.Write("   Это должно быть целое число!\n     Повторите ввод: ");
                }
                Console.WriteLine();
                Console.Write("Введите второе целое число  ");
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("   Это должно быть целое число!\n     Повторите ввод: ");
                }
                Console.WriteLine();
                Console.WriteLine("Выберите операцию: +  -  *  / ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Ваш выбор:  ");
                char operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        {
                            Console.WriteLine("Результат: {0} + {1} = {2}", x, y, x + y);
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Результат: {0} - {1} = {2}", x, y, x - y);
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("Результат: {0} * {1} = {2}", x, y, x * y);
                            break;
                        }
                    case '/':
                        {
                            if (y != 0)
                            {
                                Console.WriteLine("Результат: {0} / {1} = {2,3:f2}", x, y, (double)x / y);    //проверка через if
                            }
                            else
                            {
                                Console.WriteLine("Ошибка деления на ноль");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Выбрана некорректная операция");
                            break;
                        }
                }
                Console.WriteLine();
                Console.WriteLine("Решим другой пример? 1 - да, 0 - нет");
                Console.Write("Ваш ответ:");
                otvet = Convert.ToInt32(Console.ReadLine());

            }
            while (otvet == 1);
            Console.WriteLine();
            Console.WriteLine("Для закрытия окна приложения нажмите Enter");
            Console.ReadKey();
        }
    }
}
