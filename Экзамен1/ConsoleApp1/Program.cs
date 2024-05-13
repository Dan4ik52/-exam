using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
                   Console.Write("x= ");
                   int number1 = int.Parse(Console.ReadLine());
                   Console.Write("y= ");
                   int number2 = int.Parse(Console.ReadLine());
                   int sum = number1 + number2;
                   Console.WriteLine($"{number1}+{number2}={sum}");
            */

            /* 2
                     Console.Write("x= ");
                     int number1 = int.Parse(Console.ReadLine());
                     Console.Write("y= ");
                     int number2 = int.Parse(Console.ReadLine());
                     Console.Write("z= ");
                     int number3 = int.Parse(Console.ReadLine());
                     int sum = number1 + number2 + number3;
                     Console.WriteLine($"{number1}+{number2}+{number3}={sum}");
            */


            /*3        
                    Console.Write("x= ");
                    double number1 = double.Parse(Console.ReadLine());
                    Console.Write("y= ");
                    double number2 = double.Parse(Console.ReadLine());
                    double umn = number1 * number2;
                    Console.WriteLine($"{number1}*{number2}={umn:F1}");
           */


            /*4      
                   Console.Write("x= ");
                   double number1 = double.Parse(Console.ReadLine());
                   Console.Write("y= ");
                   double number2 = double.Parse(Console.ReadLine());
                   double del = number1 / number2;
                   Console.WriteLine($"{number1:f3}/{number2:f3}={del:F3}");
            */

            /*5
                    Console.Write("a= ");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    int number2 = int.Parse(Console.ReadLine());            
                    Console.WriteLine($"{number1}+{number2}={number2}+{number1}");
            */


            /*6
                     Console.Write("a= ");
                     int number1 = int.Parse(Console.ReadLine());
                     Console.Write("b= ");
                     int number2 = int.Parse(Console.ReadLine());
                     int sum=number1+number2;номинал
                     Console.Write($"a+b={number1}+{number2}={sum}\t");
                     int min = number1 - number2;
                     Console.Write($"a-b={number1}-{number2}={min}\t");
                     int umn = number1 * number2;
                     Console.WriteLine($"a*b={number1}*{number2}={umn}");         
             */

            /*7
                    Console.Write("Как тебя зовут? ");
                    string name = Console.ReadLine();
                    Console.Write("Скольок тебе лет? ");
                    int age = int.Parse(Console.ReadLine());
                    int year = 2009;
                    Console.Write($"{name}, ты родился в {year-age} году");
            */

            /*8
                    Console.Write("Номинал купюры = ");
                    int denomination = int.Parse(Console.ReadLine());
                    Console.Write("Количесвто купюр = ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write($"Сумма денег= {denomination*quantity}р."); 
            */
            Console.ReadKey();
        }
    }
}
