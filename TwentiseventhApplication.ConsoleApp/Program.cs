using System;
using System.Text;
using System.Collections.Generic;

namespace TwentiseventhApplication.ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                ((ISummer)calculator).Sum();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }
    public interface ISummer
    {
        public void Sum();
       
    }
    public class Calculator : ISummer
    {
        public void Sum()
        {
            int num1;
            int num2;
            Console.WriteLine($"Введите первое значение: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе значение: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine($"\n{result}");
        }
    }
}
