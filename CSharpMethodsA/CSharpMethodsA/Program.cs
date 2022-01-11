using System;

namespace CSharpMethodsA // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string yourName;

            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();

            string favoriteColor;

            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();

            string favoriteAnimal;

            Console.WriteLine("What's your favorite animal?");
            favoriteAnimal = Console.ReadLine();

            string favoriteBand;

            Console.WriteLine("If you have a favorite band, what is their name?");
            favoriteBand = Console.ReadLine();

            string favoritePresident;

            Console.WriteLine("Finally, who is your favorite U.S President of all time?");
            favoritePresident = Console.ReadLine();

            Console.WriteLine("Hello {0}, I think it is awesome that you like {1} too! Oh nice, a " +
                "{2} is amazingly fast and pretty. Mine are elephants and lions. Ha! I had a feeling you were going to say {3} and I can't knock it. " +
                "However, N.A.S ... Nas, Nas, Nas, is the best to do it! My GUY! I knew you were super clever... " +
                "{4} is my all-time favorite too and G.O.A.T POTUS, hands down!", yourName, favoriteColor, favoriteAnimal, favoriteBand, favoritePresident);

            var result1 = Multiply(9,5);
            Console.WriteLine(result1);

            var result2 = Divide(222,22);
            Console.WriteLine(result2);

            var result3 = Modulus(56, 9);
            Console.WriteLine(result3);

            var result4 = Sum(4, 3);
            Console.WriteLine(result4);

            var result5 = Subtract(19, 7);
            Console.WriteLine(result5);

        }

        public static int Multiply(int num1, int num2)
        {
            var mult = num1 * num2;
            return mult;
        }

        public static int Divide(int num1, int num2)
        {
            var div = num1 / num2;
            return div;
        }

        public static int Modulus(int num1, int num2)
        {
            var mod = num1 % num2;
            return mod;
        }
        public static int Sum(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        public static int Subtract(int num1, int num2)
        {
            var sub = num1 - num2;
            return sub;
        }

    }
}
