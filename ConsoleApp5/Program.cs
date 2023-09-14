using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp5
{
    internal class Program
    {
        static int Model(int x, int y)
        {
            if (y == 0)
            {

                Exception exc = new Exception("ОШИБКА: деление на 0");
                exc.HelpLink = "https://ww.ithub.bulgakov.app";
                exc.Data.Add("Время возникновения", DateTime.Now);
                exc.Data.Add("Причина", "Не корректное значение");

                throw exc;
            }
            return x / y;
        }


        static void Gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }


        static void Main()
        {
            try
            {
                Console.Write("Введите x :");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y :");

                int y = int.Parse(Console.ReadLine());


                int result = Model(x, y);
                Console.WriteLine("Результат :", result);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Red();
                Console.WriteLine("\n Error !   \n");
                Gray();
                Console.WriteLine("\n Ошибка : !   \n");
                Gray();
                Console.Write(ex.Message);
                Green();
                Console.Write("Метод ");
                Gray();

                Console.Write(ex.TargetSite);
                Green();
                Console.WriteLine("Вывод стека");
                Gray();
                Console.WriteLine("Подробности на сайте:");
                Green();
                Console.WriteLine(ex.HelpLink +"\n\n");
                if(ex.Data != null)
                {
                    Console.WriteLine("Сввединия :\n");
                    Gray();
                    foreach (DictionaryEntry d in ex.Data)
                        Console.WriteLine("-> {0} {1} ",d.Key,d.Value);
                    Console.WriteLine("\n\n");
                }
                Gray();
               Main();
            }
        }
    }
}