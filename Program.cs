using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int x = int.Parse(Console.ReadLine());
            int squared = Square(x);
            Console.WriteLine("{0} squared is {1}", x, squared);
            int cubed = Cube(x);
            Console.WriteLine("{0} cubed is {1}", x, cubed);
        }


        public static int Square(int x)
        {
            int answer = x * x;
            return answer;
        }

        public static int Cube (int x)
        {
            //Utilizing the Square function to multiply it again by X, turning it into a cube.
            int answer = Square(x) * x;
            return answer;
        }



        //One way of doing things.
        //public static void TheCube(int x)
        //{
        //    for (int i = 0; i <= x; i++)
        //    {
        //       int answer = x * x * x;
        //        Console.WriteLine("The cube of {0} is {1}",x,answer);
        //        break;
        //    }
        //}

        //public static void TheSquare(int x)
        //{
        //    for (int i = 0; i < x; i++)
        //    {
        //        int answer = x * x;
        //        Console.WriteLine("The Square of {0} is {1}",x,answer);
        //        break;
        //    }
        //}
    }
}
