using System;

namespace Tall_and_Male
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Are you a male? (True or False): ");
            bool isMale = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Are you tall? (True or False): ");
            bool isTall = Convert.ToBoolean(Console.ReadLine());

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            } else if (isMale && !isTall){
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall){
                Console.WriteLine("You are not a male but you are tall.");
            } else
            {
                Console.WriteLine("You are not a male and not tall.");
            }
        }
    }
}
