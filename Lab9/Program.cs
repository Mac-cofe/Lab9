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
            Console.WriteLine("Вас приветствует Калькулятор 1.0");
            Console.WriteLine("Я пока только умею складывать, вычитать, умножать и делить числа");

            Console.Write("Введите целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите код операции:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
             case 1:
                {
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.WriteLine("Такую операцию я делать не умею");
                    break;
                }


            }
    }
}
