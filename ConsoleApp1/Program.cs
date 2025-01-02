using System;
using System.Collections.Generic;
using System.Linq;
namespace ConAppDesignPattern
{
    public class Adder
    {
        public static Adder instance;
        public static int instanceCount = 0;
        public int Num1
        {
            private set; get;
        }
        public int Num2
        {
            private set; get;
        }
        private Adder(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public static Adder GetInstance(int num1, int num2)
        {
            if (instance == null)
            {
                ++instanceCount;
                instance = new Adder(num1, num2);
            }
            else
            {
                instance.Num1 = num1;
                instance.Num2 = num2;
            }
            return instance;
        }


        public int Calculate()
        {
            return Num1 + Num2;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("Input num1 and num2");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                Adder addObj = Adder.GetInstance(n1, n2);
                Console.WriteLine("Working with adder instance no - {0}", Adder.instanceCount);
                Console.WriteLine($"{addObj.Num1} + {addObj.Num2} = {addObj.Calculate()}");

                Console.WriteLine("Continue? Press Y");
                char ans = Char.Parse(Console.ReadLine());
                b = (Char.ToUpper(ans) == 'Y') ? true : false;
            }
        }
    }
}