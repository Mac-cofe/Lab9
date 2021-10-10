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
            int x = 0; int y = 0;
            Console.WriteLine("Вас приветствует Калькулятор 1.0");
            Console.WriteLine("Я пока только умею складывать, вычитать, умножать и делить числа");
            Console.WriteLine("--------------------------------------------------------------");

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
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Выберите код операции:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("Ваш выбор:  ");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.WriteLine("{0} / {1} = {2,3:f2}", x, y, x / y);  // при такой записи исключение обрабатывается, но ответ может быть вещественным. И если исправить на (double)x / y  или  Convert.ToDouble(x / y), то исключение не обрабатывается
                        }
                        catch (Exception ex) when (y == 0)              // обработка исключения
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Выбрана некорректная операция");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
