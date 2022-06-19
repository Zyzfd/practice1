using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("Выберете задание: ");
                Console.WriteLine("1 - Проверка на деление");
                Console.WriteLine("2 - Остаток от деления");
                Console.WriteLine("0 - Выход");
                Console.Write(">> ");
                string menu = Console.ReadLine();
                try
                {
                    int menuInt = Convert.ToInt32(menu);
                    switch (menuInt)
                    {
                        case 1:
                            {
                                Console.Write("Введите первое число: ");
                                int x1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите второе число: ");
                                int x2 = Convert.ToInt32(Console.ReadLine());
                                if (x1 % x2 == 0)
                                {
                                    Console.WriteLine("Числа делятся");
                                } else
                                {
                                    Console.WriteLine("Числа не делятся");
                                }
                                Console.ReadLine();
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Введите первое число: ");
                                int x1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите второе число: ");
                                int x2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(x1 % x2);
                                Console.ReadLine();
                            }
                            break;
                        case 0:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                throw new Exception();
                            }
                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
