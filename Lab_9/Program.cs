using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a / b);
            }
            // catch(Exception ex)
            // catch(DivideByZeroException)
            catch (DivideByZeroException) when (a == 0 && b == 0)
            {
                // Console.WriteLine("Ошибка!");
                // Console.WriteLine(ex.Message);
                // Console.WriteLine("Деление на 0!");
                Console.WriteLine("Деление 0 на 0!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
