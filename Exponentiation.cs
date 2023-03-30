using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_2_3
{
    internal class Exponentiation
    {
        public double First;
        public double Second;
        public Exponentiation(double first, double second)
        { 
            First = first;
            Second = second;
        }
        void Read()
        {
            Console.WriteLine("Укажите число first:");
            First = Convert.ToDouble(Console.Read());
            Console.WriteLine("Укажите число second:");
            Second = Convert.ToDouble(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine($"Число {First} в степени {Second} будет равно {Power(First, Second)}");
        }
        public double Power(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
